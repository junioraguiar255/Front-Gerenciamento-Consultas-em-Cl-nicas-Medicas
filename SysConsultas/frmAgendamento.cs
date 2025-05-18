using Newtonsoft.Json;
using SysConsultas.Model;
using System.Net;
using System.Text;

namespace SysConsultas
{
    public partial class frmAgendamento : Form
    {
        Paciente paciente;
        Medico medico;
        DateTime horarioComData;
        bool modoEdicao = false;
        public frmAgendamento()
        {
            InitializeComponent();
            AdicionarHorariosComerciaisAoComboBox();
            cbmHorario.SelectedIndex = 1;
        }

        private void AdicionarHorariosComerciaisAoComboBox()
        {
            cbmHorario.Items.Clear(); // Limpa os itens existentes

            // Horário de início e fim para cada intervalo de horário comercial
            TimeSpan inicioManha = new TimeSpan(8, 0, 0);
            TimeSpan fimManha = new TimeSpan(12, 0, 0);
            TimeSpan inicioTarde = new TimeSpan(14, 0, 0);
            TimeSpan fimTarde = new TimeSpan(18, 0, 0);

            // Adicionar horários da manhã
            AdicionarHorariosAoComboBox(inicioManha, fimManha);

            // Adicionar horários da tarde
            AdicionarHorariosAoComboBox(inicioTarde, fimTarde);
        }
        private void AdicionarHorariosAoComboBox(TimeSpan inicio, TimeSpan fim)
        {
            DateTime dataAtual = DateTime.Today.Add(inicio); // Começa no primeiro horário do dia
            while (dataAtual.TimeOfDay < fim)
            {
                cbmHorario.Items.Add(dataAtual.ToString("HH:mm")); // Adiciona o horário ao ComboBox
                dataAtual = dataAtual.AddMinutes(15); // Incrementa 15 minutos para o próximo horário
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {


        }

        public async Task cadastrarAsync()
        {

            string dataHoraFormatada = horarioComData.ToString("yyyy-MM-ddTHH:mm:ss");
            var agendamento = new AgendamentoConsultaDTO
            {
                idMedico = medico.Id,
                idPaciente = paciente.Id,
                data = dataHoraFormatada,
                motivo_cancelamento = "6",
                convenio = (ckParticular.Checked) ? "Particular" : "Plano de Saúde"

            };

            if (modoEdicao)
            {
                //cadastroPaciente.id = idPaciente;
            }

            var json = JsonConvert.SerializeObject(agendamento);

            using var httpClient = new HttpClient();
            var content = new StringContent(json, Encoding.UTF8, "application/json");


            Task<HttpResponseMessage> responseTask = null;

            String mensagemOk;
            String mensagemErro;

            if (modoEdicao)
            {
                //responseTask = httpClient.PutAsync(ValoresGlobais.url + "consultas", content);
                mensagemOk = "Paciente Editado Com sucesso ";
                mensagemErro = "Erro ao Editar Paciente ";

            }
            else
            {
                responseTask = httpClient.PostAsync(ValoresGlobais.url + "consultas", content);
                mensagemOk = "Consulta Cadastrado Com sucesso ";
                mensagemErro = "Erro ao Cadastrar Agendamento ";
            }

            // Espera até que a tarefa seja concluída
            HttpResponseMessage response = await responseTask;


            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(mensagemOk);
                limparFormulario();
                if (modoEdicao)
                    this.Dispose();
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync(); // Captura o corpo da resposta
                if (response.StatusCode == HttpStatusCode.Conflict) // Verifica se o status é 409
                {
                    MessageBox.Show("Erro: Já existe um agendamento para esse médico nesse horário");
                }
                else
                {
                    MessageBox.Show(mensagemErro + " Status: " + response.StatusCode + "\nErro: " + errorMessage);
                }
            }
        }

        private void btnBuscaPaciente_Click(object sender, EventArgs e)
        {
            using (var buscarIdForm = new frmBuscaPaciente())
            {
                var result = buscarIdForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    paciente = buscarIdForm.paciente;
                    txtPaciente.Text = paciente.Id + " - " + paciente.Nome;
                }
                else
                {
                    txtPaciente.Clear();
                }
            }
        }

        private void btnBuscaMedico_Click(object sender, EventArgs e)
        {
            using (var buscarIdForm = new frmBuscaMedicos())
            {
                var result = buscarIdForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    medico = buscarIdForm.medico;
                    txtMedico.Text = medico.Id + " - " + medico.Nome;
                }
                else
                {
                    txtMedico.Clear();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparFormulario();
        }

        private void limparFormulario()
        {
            dateTimePicker1.Value = DateTime.Now;
            cbmHorario.SelectedIndex = 1;
            txtMedico.Clear();
            txtPaciente.Clear();
            dateTimePicker1.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ckParticular_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            ckPlanoDeSaude.Checked = !checkBox.Checked;

        }

        private void ckPlanoDeSaude_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            ckParticular.Checked = !checkBox.Checked;

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            // Combinar data selecionada com horário selecionado
            if (cbmHorario.SelectedItem != null)
            {
                string horarioSelecionado = cbmHorario.SelectedItem.ToString();
                DateTime dataSelecionada = dateTimePicker1.Value.Date;
                horarioComData = dataSelecionada.Add(TimeSpan.Parse(horarioSelecionado));

            }

            if (txtMedico.Text.Length == 0 || txtMedico.Text == "" || txtPaciente.Text.Length == 0 || txtPaciente.Text == "")
            {
                MessageBox.Show($"Defina um paciente e um medico para a consulta");
                return;
            }

            cadastrarAsync();
        }
    }
}
