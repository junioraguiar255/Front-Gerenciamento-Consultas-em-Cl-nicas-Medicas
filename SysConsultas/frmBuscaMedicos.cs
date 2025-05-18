using Newtonsoft.Json;
using SysConsultas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysConsultas
{
    public partial class frmBuscaMedicos : Form
    {
        public Medico medico { get; private set; }
        bool encontrado = false;
        public frmBuscaMedicos()
        {
            InitializeComponent();
            CarregarMedicosAsync();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public async Task editarCadastroAsync(string id, string nome)
        {
            string url = "";

            // Verifica se o ID está preenchido e faz a busca por ID
            if (!string.IsNullOrEmpty(id))
            {
                url = $"http://localhost:8080/medicos/{id}";
            }
            // Se o ID não for informado, verifica o nome e faz a busca por nome
            else if (!string.IsNullOrEmpty(nome))
            {
                url = $"http://localhost:8080/medicos/nome/{nome}"; // Exemplo de URL para busca por nome
            }
            else
            {
                MessageBox.Show("Por favor, forneça o nome do Médico .");
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        medico = JsonConvert.DeserializeObject<Medico>(json);
                        txtIdMedico.Text = medico.Nome.ToString();
                        txtMedico.Text = medico.Nome.ToString();

                        encontrado = true;
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        MessageBox.Show($"Médico não encontrado");
                        txtIdMedico.Focus();
                        encontrado = false;
                    }
                    else
                    {
                        MessageBox.Show($"Falha ao buscar o médico. Código de status: {response.StatusCode}");
                        encontrado = false;
                    }
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show($"Erro ao fazer a requisição GET: {e.Message}");
                    encontrado = false;
                }
            }
        }


        private async void buscarMedico()
        {
            if (string.IsNullOrEmpty(txtIdMedico.Text) || txtIdMedico.Text == "0")
            {
                MessageBox.Show("Digite o ID do médico para o agendamento da consulta");
                txtIdMedico.Focus();
                return;
            }

            await editarCadastroAsync(txtIdMedico.Text, "");
            if (encontrado)
            {
                // Atualiza o ListBox com o médico encontrado
                listBoxMedicos.Items.Clear();
                listBoxMedicos.Items.Add(medico);
            }
        }


        //private void buscarMedico()
        //{
        //    string id = txtIdMedico.Text;
        //    string nome = txtMedico.Text;

        //    // Verificar se o ID está preenchido e não é 0
        //    if (!string.IsNullOrEmpty(nome) && nome != "0")
        //    {
        //        _ = editarCadastroAsync(nome, "");
        //    }
        //    // Verificar se o Nome está preenchido
        //    else if (!string.IsNullOrEmpty(nome))
        //    {
        //        _ = editarCadastroAsync("", nome);
        //    }
        //    else
        //    {
        //        // Se ambos ID e Nome estiverem vazios ou inválidos, exibir mensagem de erro
        //        MessageBox.Show("Por favor, forneça um ID ou nome do médico para buscar o cadastro.");
        //        txtIdMedico.Focus();
        //    }
        //}


        private async void btnBuscaPaciente_Click(object sender, EventArgs e)
        {
            await BuscarMedicoSelecionadoAsync();
        }

        private void txtIdPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar se a tecla pressionada não é um dígito numérico e não é a tecla Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                // Se não for um dígito numérico, cancelar a entrada de caracteres
                e.Handled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listBoxMedicos.ClearSelected();
            txtMedico.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (encontrado)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Selecione um médico válido.");
            }
        }

        private void txtIdMedico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarMedico();
            }
        }
        public class MedicosResponse
        {
            public List<Medico> Content { get; set; }
        }


        private async Task CarregarMedicosAsync()
        {
            string url = "http://localhost:8080/medicos"; // URL para obter todos os médicos

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        MedicosResponse resposta = JsonConvert.DeserializeObject<MedicosResponse>(json);

                        // Limpa o ListBox antes de adicionar os médicos
                        listBoxMedicos.Items.Clear();

                        // Adiciona os médicos ao ListBox
                        foreach (var med in resposta.Content)
                        {
                            listBoxMedicos.Items.Add(med); // Adiciona o objeto Médico ao ListBox
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Falha ao carregar médicos. Código de status: {response.StatusCode}");
                    }
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show($"Erro ao fazer a requisição GET: {e.Message}");
                }
            }
        }



        // Método para buscar o médico selecionado no ListBox
        private async Task BuscarMedicoSelecionadoAsync()
        {
            if (listBoxMedicos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um médico da lista.");
                return;
            }

            // Obtém o médico selecionado
            Medico medicoSelecionado = (Medico)listBoxMedicos.SelectedItem;

            // Exibe o nome do médico no TextBox (opcional)
            txtMedico.Text = medicoSelecionado.Nome;

            // Define o médico selecionado como o médico atual
            medico = medicoSelecionado;
            encontrado = true;
        }

        private void listBoxMedicos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _ = BuscarMedicoSelecionadoAsync();
            }
        }
    }
}
