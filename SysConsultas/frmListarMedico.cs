using Newtonsoft.Json;
using SysConsultas.Model;

namespace SysConsultas
{
    public partial class frmListarMedico : Form
    {
        String id;
        public frmListarMedico()
        {
            InitializeComponent();
            listarMedicosAsync();
        }



        public async Task listarMedicosAsync()
        {
            // Fazer a requisição HTTP GET
            using var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(ValoresGlobais.url+"medicos");

            // Verificar se a requisição foi bem-sucedida
            if (response.IsSuccessStatusCode)
            {
                // Ler o conteúdo da resposta como uma string
                string jsonContent = await response.Content.ReadAsStringAsync();

                // Desserializar a string JSON em objetos C#
                ListagemMedicoDTO medicos = JsonConvert.DeserializeObject<ListagemMedicoDTO>(jsonContent);

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
                contextMenuStrip.Items.Add("Desativar", null, desativarMedico);
                contextMenuStrip.Items.Add("Editar", null, editarMedico);


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

        private void desativarMedico(object sender, EventArgs e)
        {
            desativarMedicoAsync();
        }

        private void editarMedico(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id) || !int.TryParse(id, out int medicoId))
            {
                MessageBox.Show("ID inválido. Certifique-se de que o ID é um número válido.");
                return;
            }

            frmCadastrarMedico frm = new frmCadastrarMedico(true, medicoId);
            this.Hide();
            frm.Show();
        }

        public async Task desativarMedicoAsync()
        {
            string url = $"http://localhost:8080/medicos/{id}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Fazendo a requisição DELETE
                    HttpResponseMessage response = await client.DeleteAsync(url);

                    // Verificando se a requisição foi bem-sucedida (código de status 200-299)
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(($"Médico com ID {id} desativado com sucesso."));
                        listarMedicosAsync();
                    }
                    else
                    {
                        MessageBox.Show(($"Falha ao desativar o médico. Código de status: {response.StatusCode}"));
                    }
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show(($"Erro ao fazer a requisição DELETE: {e.Message}"));
                }
            }
        }
    }
}
