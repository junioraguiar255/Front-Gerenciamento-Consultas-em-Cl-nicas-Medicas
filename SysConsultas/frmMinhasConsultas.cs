using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using SysConsultas.Model;
using System.Text;
using Font = iTextSharp.text.Font;

namespace SysConsultas
{
    public partial class frmMinhasConsultas : Form
    {
        String id;
        Usuario usuario;
        List<AgendaDTO> consultas;
        public frmMinhasConsultas(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
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
                idUsuario = usuario.id
            };

            var json = JsonConvert.SerializeObject(pesquisa);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(ValoresGlobais.url + "consultas/pesquisaMinhasConsultas", content);

            if (response.IsSuccessStatusCode)
            {
                string jsonRetorno = await response.Content.ReadAsStringAsync();
                consultas = JsonConvert.DeserializeObject<List<AgendaDTO>>(jsonRetorno);

                tblMinhasConsultas.DataSource = consultas;
                tblMinhasConsultas.Refresh();
                tblMinhasConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                tblMinhasConsultas.AutoResizeColumns();
                // Permitir a seleção de apenas uma linha por vez
                tblMinhasConsultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                tblMinhasConsultas.MultiSelect = false;
                tblMinhasConsultas.ReadOnly = true;

                // Configurar o menu de contexto
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                contextMenuStrip.Items.Add("Cancelar", null, cancelarAgendamento);

                contextMenuStrip.Items.Add("Inserir Observacoes", null, inserirObservacoes);

                // Associar o menu de contexto à DataGridView
                tblMinhasConsultas.ContextMenuStrip = contextMenuStrip;

                // Manipular o evento CellMouseDown para exibir o menu de contexto
                tblMinhasConsultas.CellMouseDown += tblMinhasConsultas_CellMouseClick;

            }

        }

        private void cancelarAgendamento(object sender, EventArgs e)
        {
            frmCancelarAgendamento frm = new frmCancelarAgendamento(Convert.ToInt64(id));
            this.Dispose();
            frm.Show();
        }

        public void inserirObservacoes(object sender, EventArgs e)
        {
            frmInserirObservacoes frm = new frmInserirObservacoes(Convert.ToInt64(id));
            frm.ShowDialog();
            listarMinhasConsultas();

        }

        private void tblMinhasConsultas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Verificar se o botão direito do mouse foi clicado
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                // Selecionar a linha clicada
                tblMinhasConsultas.Rows[e.RowIndex].Selected = true;

                // Obter a posição do mouse em relação à tela
                Point position = tblMinhasConsultas.PointToScreen(new Point(e.X, e.Y));

                DataGridViewRow row = tblMinhasConsultas.Rows[e.RowIndex];
                id = row.Cells["id"].Value.ToString();

                // Exibir o menu de contexto na posição do mouse
                tblMinhasConsultas.ContextMenuStrip.Show(position);
            }
        }

        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
            if(consultas.Count <= 0)
            {
                MessageBox.Show("Nenhum informação encontrada para gerar o PDF");
                return;
            }
            GeneratePdfReport();
        }

        public void GeneratePdfReport()
        {
            // Criar um diálogo de salvamento para permitir que o usuário escolha o local onde deseja salvar o arquivo PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            // Se o usuário clicar em "OK" no diálogo de salvamento, então prosseguimos com a geração do PDF
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Criação do documento PDF
                iTextSharp.text.Document document = new iTextSharp.text.Document();
                try
                {
                    document = new iTextSharp.text.Document();
                    // Criação do escritor do documento PDF

                    PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                    // Abrindo o documento
                    document.Open();

                    // Adicionando título ao documento
                    Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18f);
                    Paragraph title = new Paragraph("Relatório de Consultas", titleFont);
                    document.Add(title);
                    document.Add(new Paragraph("\n"));

                    // Adicionando cabeçalho da tabela
                    PdfPTable table = new PdfPTable(4);
                    table.AddCell("ID");
                    table.AddCell("Nome Médico");
                    table.AddCell("Nome Paciente");
                    table.AddCell("Data");

                    // Adicionando dados das consultas à tabela
                    foreach (AgendaDTO consulta in consultas)
                    {
                        table.AddCell(consulta.id.ToString());
                        table.AddCell(consulta.medico);
                        table.AddCell(consulta.paciente);
                        table.AddCell(consulta.data.ToString("dd-MM-yyyy HH:mm"));
                    }

                    // Adicionando tabela ao documento
                    document.Add(table);
                }
                catch (DocumentException de)
                {
                    // Tratamento de exceção para erros relacionados ao documento
                    MessageBox.Show(de.Message);
                }
                catch (IOException ioe)
                {
                    // Tratamento de exceção para erros de entrada/saída
                    MessageBox.Show(ioe.Message);
                }
                finally
                {
                    // Fechando o documento
                    document.Close();
                }

                MessageBox.Show("Relatório em PDF gerado com sucesso.");
            }
        }
    }
}
