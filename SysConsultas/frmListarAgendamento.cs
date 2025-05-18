using Newtonsoft.Json;
using SysConsultas.Model;
using System.Text;

namespace SysConsultas
{
    public partial class frmListarAgendamento : Form
    {
        String id;
        bool consultaPorIdConsultaID;
        bool consultaPorIdPaciente;
        List<AgendaDTO> consultas;
        public frmListarAgendamento(bool isConsultaIndividual = false, long idConsulta = 0, bool isPacienteIndividual = false)
        {
            InitializeComponent();
            consultaPorIdConsultaID = isConsultaIndividual;
            consultaPorIdPaciente = isPacienteIndividual;
            if (isConsultaIndividual || isPacienteIndividual)
            {
                id = idConsulta.ToString();
            }

            listarAgendamentosAsync();

        }

        private void tblMedicos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Verificar se o botão direito do mouse foi clicado
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                // Selecionar a linha clicada
                tblMedicos.Rows[e.RowIndex].Selected = true;

                // Obter a posição do mouse em relação à tela
                Point position = tblMedicos.PointToScreen(new Point(e.X, e.Y));

                DataGridViewRow row = tblMedicos.Rows[e.RowIndex];
                id = row.Cells["id"].Value.ToString();

                // Exibir o menu de contexto na posição do mouse
                tblMedicos.ContextMenuStrip.Show(position);
            }
        }

        public async Task listarAgendamentosAsync()
        {
            // Fazer a requisição HTTP GET
            using var httpClient = new HttpClient();
            String requisicao;

            if (consultaPorIdConsultaID)
            {
                requisicao = ValoresGlobais.url + "consultas/individual/" + id;
            }
            else if (consultaPorIdPaciente)
            {
                requisicao = ValoresGlobais.url + "consultas/individualPaciente/" + id;
            }
            else
            {
                requisicao = ValoresGlobais.url + "consultas";
            }

            var response = await httpClient.GetAsync(requisicao);

            // Verificar se a requisição foi bem-sucedida
            if (response.IsSuccessStatusCode)
            {
                // Ler o conteúdo da resposta como uma string
                string jsonContent = await response.Content.ReadAsStringAsync();

                // Desserializar a string JSON em objetos C#
                ListagemConsultaDTO medicos = JsonConvert.DeserializeObject<ListagemConsultaDTO>(jsonContent);

                tblMedicos.DataSource = medicos.content;
                tblMedicos.Refresh();
                tblMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                tblMedicos.AutoResizeColumns();
                // Permitir a seleção de apenas uma linha por vez
                tblMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                tblMedicos.MultiSelect = false;
                tblMedicos.ReadOnly = true;


                // Configurar o menu de contexto
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                contextMenuStrip.Items.Add("Cancelar", null, cancelarAgendamento);


                // Associar o menu de contexto à DataGridView
                tblMedicos.ContextMenuStrip = contextMenuStrip;

                // Manipular o evento CellMouseDown para exibir o menu de contexto
                tblMedicos.CellMouseDown += tblMedicos_CellMouseClick;

            }
            else
            {
                MessageBox.Show(($"Erro ao obter a lista de médicos: {response.StatusCode}"));
            }
        }


        private void cancelarAgendamento(object sender, EventArgs e)
        {
            frmCancelarAgendamento frm = new frmCancelarAgendamento(Convert.ToInt64(id));
            this.Dispose();
            frm.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            listarMinhasConsultas();
        }

        public async Task listarMinhasConsultas()
        {

            // Fazer a requisição HTTP GET
            using var httpClient = new HttpClient();


            var pesquisa = new PesquisaConsultasPorDatasDTO
            {
                dataInicio = dataInicio.Value.Date.ToString("yyyy-MM-ddTHH:mm:ss"),
                dataFim = dataFim.Value.Date.ToString("yyyy-MM-ddT23:59:59"),
                idUsuario = 0
            };

            var json = JsonConvert.SerializeObject(pesquisa);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(ValoresGlobais.url + "consultas/pesquisaMinhasConsultas", content);

            if (response.IsSuccessStatusCode)
            {
                string jsonRetorno = await response.Content.ReadAsStringAsync();
                consultas = JsonConvert.DeserializeObject<List<AgendaDTO>>(jsonRetorno);

                tblMedicos.DataSource = consultas;
                tblMedicos.Refresh();
                tblMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                tblMedicos.AutoResizeColumns();
                // Permitir a seleção de apenas uma linha por vez
                tblMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                tblMedicos.MultiSelect = false;
                tblMedicos.ReadOnly = true;

                // Configurar o menu de contexto
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                contextMenuStrip.Items.Add("Cancelar", null, cancelarAgendamento);


                // Associar o menu de contexto à DataGridView
                tblMedicos.ContextMenuStrip = contextMenuStrip;

                // Manipular o evento CellMouseDown para exibir o menu de contexto
                tblMedicos.CellMouseDown += tblMedicos_CellMouseClick;

            }

        }
    }
}
