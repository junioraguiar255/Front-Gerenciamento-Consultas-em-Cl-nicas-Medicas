using Newtonsoft.Json;
using SysConsultas.Model;

namespace SysConsultas
{
    public partial class frmListarPaciente : Form
    {
        String id;

        public frmListarPaciente()
        {
            InitializeComponent();
            listarPacientesAsync();
        }

        public async Task listarPacientesAsync()
        {
            // Fazer a requisição HTTP GET
            using var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(ValoresGlobais.url + "pacientes");

            // Verificar se a requisição foi bem-sucedida
            if (response.IsSuccessStatusCode)
            {
                // Ler o conteúdo da resposta como uma string
                string jsonContent = await response.Content.ReadAsStringAsync();

                // Desserializar a string JSON em objetos C#
                ListagemPacienteDTO paciente = JsonConvert.DeserializeObject<ListagemPacienteDTO>(jsonContent);

                tblPacientes.DataSource = paciente.content;
                tblPacientes.Refresh();
                tblPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                tblPacientes.AutoResizeColumns();
                // Permitir a seleção de apenas uma linha por vez
                tblPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                tblPacientes.MultiSelect = false;
                tblPacientes.ReadOnly = true;


                // Configurar o menu de contexto
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                contextMenuStrip.Items.Add("Desativar", null, desativarPaciente);
                contextMenuStrip.Items.Add("Editar", null, editarPaciente);


                // Associar o menu de contexto à DataGridView
                tblPacientes.ContextMenuStrip = contextMenuStrip;

                // Manipular o evento CellMouseDown para exibir o menu de contexto
                tblPacientes.CellMouseDown += tblMedicos_CellMouseClick;

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
                tblPacientes.Rows[e.RowIndex].Selected = true;

                // Obter a posição do mouse em relação à tela
                Point position = tblPacientes.PointToScreen(new Point(e.X, e.Y));

                DataGridViewRow row = tblPacientes.Rows[e.RowIndex];
                id = row.Cells["id"].Value.ToString();

                // Exibir o menu de contexto na posição do mouse
                tblPacientes.ContextMenuStrip.Show(position);
            }
        }
        private void desativarPaciente(object sender, EventArgs e)
        {
            desativarPacienteAsync();
        }

        //private void editarPaciente(object sender, EventArgs e)
        //{
        //    frmCadastrarPaciente frm = new frmCadastrarPaciente(true, Convert.ToInt32(Name));
        //    this.Dispose();
        //    frm.Show();
        //}

        private void editarPaciente(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id) || !int.TryParse(id, out int idPaciente))
            {
                MessageBox.Show("ID inválido. Certifique-se de que o ID é um número válido.");
                return;
            }

            frmCadastrarPaciente frm = new frmCadastrarPaciente(true, idPaciente);
            this.Hide();
            frm.Show();
        }

        public async Task desativarPacienteAsync()
        {
            string url = $"http://localhost:8080/pacientes/{id}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Fazendo a requisição DELETE
                    HttpResponseMessage response = await client.DeleteAsync(url);

                    // Verificando se a requisição foi bem-sucedida (código de status 200-299)
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(($"Paciente com nome {id} desativado com sucesso."));
                        listarPacientesAsync();
                    }
                    else
                    {
                        MessageBox.Show(($"Falha ao desativar o paciente. Código de status: {response.StatusCode}"));
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
