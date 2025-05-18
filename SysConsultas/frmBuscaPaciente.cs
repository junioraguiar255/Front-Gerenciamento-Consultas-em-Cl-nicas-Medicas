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
    public partial class frmBuscaPaciente : Form
    {

        // Propriedade para armazenar o paciente
        public Paciente paciente { get; private set; }
        bool encontrado = false;
        public frmBuscaPaciente()
        {
            InitializeComponent();
            CarregarPacientesAsync();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (encontrado)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Selecione um paciente válido.");
            }
        }

        public async Task editarCadastroAsync(string id, string nome)
        {
            string url = "";

            // Verifica se o ID está preenchido e faz a busca por ID
            if (!string.IsNullOrEmpty(id))
            {
                url = $"http://localhost:8080/pacientes/{id}";
            }
            // Se o ID não for informado, verifica o nome e faz a busca por nome
            else if (!string.IsNullOrEmpty(nome))
            {
                url = $"http://localhost:8080/pacientes/nome/{nome}"; // Exemplo de URL para busca por nome
            }
            else
            {
                MessageBox.Show("Por favor, forneça o nome do paciente.");
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
                        paciente = JsonConvert.DeserializeObject<Paciente>(json);

                        txtIdPaciente.Text = paciente.Nome.ToString();
                        txtPaciente.Text = paciente.Nome;
                        encontrado = true;
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        MessageBox.Show($"Nome do paciente não encontrado");
                        txtIdPaciente.Focus();
                        encontrado = false;
                    }
                    else
                    {
                        MessageBox.Show($"Falha ao buscar o paciente. Código de status: {response.StatusCode}");
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

        private async void buscarPaciente()
        {
            string nome = txtPaciente.Text;

            // Verificar se o ID está preenchido e não é 0
            if (!string.IsNullOrEmpty(nome) && nome != "0")
            {
                _ = editarCadastroAsync(nome, "");
            }
            // Verificar se o Nome está preenchido
            else if (!string.IsNullOrEmpty(nome))
            {
                _ = editarCadastroAsync("", nome);
            }
            if (string.IsNullOrEmpty(txtIdPaciente.Text) || txtIdPaciente.Text == "0")
            {
                MessageBox.Show("Digite o Nome do paciente para o agendamento da consulta");
                txtIdPaciente.Focus();
                return;
            }

            await editarCadastroAsync(txtIdPaciente.Text, "");
            if (encontrado)
            {
                // Atualiza o ListBox com o médico encontrado
                listBoxPacientes.Items.Clear();
                listBoxPacientes.Items.Add(paciente);
            }
        }

        private async void btnBuscaPaciente_Click(object sender, EventArgs e)
        {
            await BuscarPacienteSelecionadoAsync();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listBoxPacientes.ClearSelected();
            txtPaciente.Clear();
            txtIdPaciente.Clear();
        }

        private void txtIdPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarPaciente();
            }
        }

        public class PaginaPacientes
        {
            public List<Paciente> Content { get; set; }
        }

        private async Task CarregarPacientesAsync()
        {
            string url = "http://localhost:8080/pacientes"; // URL para obter todos os pacientes

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();

                        // Desserializa o JSON para a classe PaginaPacientes, que contém o campo "content"
                        PaginaPacientes pagina = JsonConvert.DeserializeObject<PaginaPacientes>(json);

                        // Limpa o ListBox antes de adicionar os pacientes
                        listBoxPacientes.Items.Clear();

                        // Adiciona os pacientes ao ListBox
                        foreach (var paciente in pagina.Content)
                        {
                            listBoxPacientes.Items.Add(paciente); // Adiciona o objeto Paciente ao ListBox
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Falha ao carregar pacientes. Código de status: {response.StatusCode}");
                    }
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show($"Erro ao fazer a requisição GET: {e.Message}");
                }
            }
        }


        private async Task BuscarPacienteSelecionadoAsync()
        {
            if (listBoxPacientes.SelectedItem == null)
            {
                MessageBox.Show("Selecione um paciente da lista.");
                return;
            }

            // Obtém o paciente selecionado
            Paciente pacienteSelecionado = (Paciente)listBoxPacientes.SelectedItem;

            // Exibe o nome do paciente no TextBox (opcional)
            txtPaciente.Text = pacienteSelecionado.Nome;

            // Define o paciente selecionado como o paciente atual
            paciente = pacienteSelecionado;
            encontrado = true;
        }

        private void listBoxPacientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _ = BuscarPacienteSelecionadoAsync();
            }
        }


    }
}
