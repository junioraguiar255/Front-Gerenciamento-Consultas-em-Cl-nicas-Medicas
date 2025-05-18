using iTextSharp.text.pdf;
using iTextSharp.text;
using Newtonsoft.Json;
using SysConsultas.Model;
using System.Text;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace SysConsultas
{
    public partial class frmInserirObservacoes : Form
    {
        long idConsulta;
        Consulta consulta;

        public frmInserirObservacoes(long id)
        {
            InitializeComponent();
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
                        txtMedico.Text = consulta.medico;
                        txtPaciente.Text = consulta.paciente;
                        txtObservacoes.Text = consulta.observacoes;
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
            if (string.IsNullOrEmpty(txtObservacoes.Text))
            {
                MessageBox.Show("Por favor, preencha a observação da consulta.");
                return;
            }

            cadastrarAsync();
        }

        public async Task cadastrarAsync()
        {
            var observacaoConsulta = new ObservacaoConsultaDTO
            {
                idConsulta = idConsulta,
                observacao = txtObservacoes.Text
            };

            var json = JsonConvert.SerializeObject(observacaoConsulta);

            using var httpClient = new HttpClient();
            var content = new StringContent(json, Encoding.UTF8, "application/json");


            Task<HttpResponseMessage> responseTask = null;
            String mensagemOk;
            String mensagemErro;

            responseTask = httpClient.PutAsync(ValoresGlobais.url + "consultas/inserirObservacao", content);
            mensagemOk = "Observacao inserida com suceso ";
            mensagemErro = "Erro ao editar consulta ";


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

        private void btnHistoricoObservacoes_Click(object sender, EventArgs e)
        {
            frmListarAgendamento frm = new frmListarAgendamento(true, idConsulta);
            frm.ShowDialog();
        }

        private void btnAtestado_Click(object sender, EventArgs e)
        {
            GenerateMedicalCertificate();
        }

        public void GenerateMedicalCertificate()
        {
            // Solicita ao médico a quantidade de dias de atestado
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Quantos dias de atestado deseja conceder?",
                "Emitir Atestado Médico",
                "1"
            );

            if (int.TryParse(input, out int diasAtestado) && diasAtestado > 0)
            {
                // Criar um diálogo de salvamento para escolher onde salvar o PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Criar documento PDF
                    iTextSharp.text.Document document = new iTextSharp.text.Document();
                    try
                    {
                        PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                        document.Open();

                        // Adicionando título ao documento
                        iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18f);
                        Paragraph title = new Paragraph("Atestado Médico", titleFont);
                        title.Alignment = Element.ALIGN_CENTER;
                        document.Add(title);
                        document.Add(new Paragraph("\n"));

                        // Informações do paciente e atestado
                        iTextSharp.text.Font normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12f);
                       


                            document.Add(new Paragraph($"Paciente: {txtPaciente.Text}", normalFont));
                            document.Add(new Paragraph($"Médico: {txtMedico.Text}", normalFont));
                            document.Add(new Paragraph($"Data: {DateTime.Now:dd-MM-yyyy HH:mm}", normalFont));
                            document.Add(new Paragraph($"\nDeclaro para os devidos fins que o(a) paciente acima está incapacitado(a) " +
                                                       $"para suas atividades pelo período de {diasAtestado} dia(s), a partir desta data.", normalFont));


                        document.Add(new Paragraph("\n\nAssinatura do Médico: _______________________", normalFont));
                    }
                    catch (DocumentException de)
                    {
                        MessageBox.Show(de.Message);
                    }
                    catch (IOException ioe)
                    {
                        MessageBox.Show(ioe.Message);
                    }
                    finally
                    {
                        document.Close();
                    }

                    MessageBox.Show("Atestado médico gerado com sucesso.");
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido de dias para o atestado.");
            }
        }

    }
}
