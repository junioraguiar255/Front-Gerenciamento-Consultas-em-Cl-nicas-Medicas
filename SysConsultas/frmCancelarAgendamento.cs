using Newtonsoft.Json;
using SysConsultas.Model;
using System.Text;


namespace SysConsultas
{
    public partial class frmCancelarAgendamento : Form
    {
        Consulta consulta;
        long idConsulta;

        public frmCancelarAgendamento(long id)
        {
            InitializeComponent();
            List<string> motivos = new List<string> { "PACIENTE_DESISTIU", "MEDICO_CANCELOU", "DESASTRES_NATURAIS", "FERIADO", "PROBLEMAS_ESTRUTURAIS", "OUTROS", "AGENDADO" };
            cbmMotivo.DataSource = motivos;
            editarCadastroAsync(id);
            idConsulta = id;
        }

        public async Task editarCadastroAsync(long id)
        {
            string url = $"http://localhost:8080/consultas/{id}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        consulta = JsonConvert.DeserializeObject<Consulta>(json);
                        dateTimePicker1.Value = consulta.data;
                        cbmMotivo.SelectedItem = consulta.motivoCancelamento;
                        txtMedico.Text = consulta.medico;
                        txtPaciente.Text = consulta.paciente;
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        MessageBox.Show($"ID do agendamento não encontrado");
                    }
                    else
                    {
                        MessageBox.Show($"Falha ao buscar o agendamento. Código de status: {response.StatusCode}");
                    }
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show($"Erro ao fazer a requisição GET: {e.Message}");
                }
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cadastrarAsync();
        }

        public async Task cadastrarAsync()
        {
            var cancelamento = new CancelamentoConsultaDTO
            {
                idConsulta = idConsulta,
                motivo = cbmMotivo.SelectedItem.ToString()
            };

            var json = JsonConvert.SerializeObject(cancelamento);

            using var httpClient = new HttpClient();
            var content = new StringContent(json, Encoding.UTF8, "application/json");


            Task<HttpResponseMessage> responseTask = null;
            String mensagemOk;
            String mensagemErro;

            responseTask = httpClient.PutAsync(ValoresGlobais.url + "consultas", content);
            mensagemOk = "Agendamento editado Com sucesso ";
            mensagemErro = "Erro ao editar agendamento ";


            // Espera até que a tarefa seja concluída
            HttpResponseMessage response = await responseTask;


            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(mensagemOk);
                this.Dispose();
            }
            else
            {
                MessageBox.Show(mensagemErro + response.StatusCode);
            }
        }
        
    }
}
