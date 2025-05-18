using Newtonsoft.Json;
using RestSharp;
using SysConsultas.Model;
using System.Text;

namespace SysConsultas
{
    public partial class frmCadastrarPaciente : Form
    {
        bool modoEdicao;
        int idPaciente = 0;

        public frmCadastrarPaciente(bool ehModoEdicao = false, int id = 0)
        {
            InitializeComponent();

            modoEdicao = ehModoEdicao;
            List<string> estados = new List<string> { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };
            cbmEstado.DataSource = estados;
            cbmEstado.Refresh();
            cbmEstado.SelectedIndex = 0;
            if (ehModoEdicao)
            {
                txtModoFuncionalidade.Text = "Modo de edição";
                btnSalvar.Text = "Editar";
                editarCadastroAsync(id);
                idPaciente = id;
                return;
            }
            txtModoFuncionalidade.Text = "Modo de inclusão";

        }

        public async Task editarCadastroAsync(int id)
        {
            string url = $"http://localhost:8080/pacientes/{id}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        Paciente paciente = JsonConvert.DeserializeObject<Paciente>(json);

                        txtNome.Text = paciente.Nome;
                        txtEmail.Text = paciente.Email;
                        txtCpf.Text = paciente.Cpf;
                        txtLogradouro.Text = paciente.Endereco.logradouro;
                        txtBairro.Text = paciente.Endereco.bairro;
                        txtCep.Text = paciente.Endereco.cep;
                        txtCidade.Text = paciente.Endereco.cidade;
                        txtComplemento.Text = paciente.Endereco.complemento;
                        txtNumero.Text = paciente.Endereco.numero;
                        cbmEstado.SelectedItem = paciente.Endereco.uf;
                    }
                    else
                    {
                        MessageBox.Show($"Falha ao buscar o médico. Código de status: {response.StatusCode}");
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

        public void limparFormulario()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
            txtLogradouro.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            cbmEstado.SelectedIndex = 0;
            txtComplemento.Clear();
            txtNumero.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparFormulario();
        }

        public async Task cadastrarAsync()
        {
            var endereco = new EnderecoDTO
            {
                logradouro = txtLogradouro.Text,
                bairro = txtBairro.Text,
                cep = txtCep.Text,
                cidade = txtCidade.Text,
                uf = cbmEstado.SelectedItem.ToString(),
                complemento = txtComplemento.Text,
                numero = txtNumero.Text
            };

            var cadastroPaciente = new CadastroPacienteDTO
            {
                nome = txtNome.Text,
                email = txtEmail.Text,
                cpf = txtCpf.Text.Replace(",", "."),
                endereco = endereco
            };

            if (modoEdicao)
            {
                cadastroPaciente.id = idPaciente;
            }

            var json = JsonConvert.SerializeObject(cadastroPaciente);

            using var httpClient = new HttpClient();
            var content = new StringContent(json, Encoding.UTF8, "application/json");


            Task<HttpResponseMessage> responseTask = null;

            String mensagemOk;
            String mensagemErro;

            if (modoEdicao)
            {
                responseTask = httpClient.PutAsync(ValoresGlobais.url + "pacientes", content);
                mensagemOk = "Paciente Editado Com sucesso ";
                mensagemErro = "Erro ao Editar Paciente ";

            }
            else
            {
                responseTask = httpClient.PostAsync(ValoresGlobais.url + "pacientes", content);
                mensagemOk = "Paciente Cadastrado Com sucesso ";
                mensagemErro = "Erro ao Cadastrar Paciente ";
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
                MessageBox.Show(mensagemErro + response.StatusCode);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text) ||
               string.IsNullOrEmpty(txtEmail.Text) ||
               string.IsNullOrEmpty(txtCpf.Text) ||
               string.IsNullOrEmpty(txtLogradouro.Text) ||
               string.IsNullOrEmpty(txtBairro.Text) ||
               string.IsNullOrEmpty(txtCep.Text) ||
               string.IsNullOrEmpty(txtCidade.Text) ||
               string.IsNullOrEmpty(txtComplemento.Text) ||
               string.IsNullOrEmpty(txtNumero.Text))
            {
                // Se algum dos campos estiver vazio, exiba uma mensagem para o usuário ou faça alguma outra ação
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
            else
            {
                cadastrarAsync();

            }
        }

        private void btnValidarCep_Click(object sender, EventArgs e)
        {
            clicouValidarCep();
        }

        private void txtCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clicouValidarCep();
            }
        }

        private void clicouValidarCep()
        {
            string cep = txtCep.Text; // Substitua pelo CEP que deseja verificar

            var client = new RestClient($"https://viacep.com.br/ws/{cep}/json/");
            var request = new RestRequest(Method.GET); // Método GET atribuído à propriedade Method

            IRestResponse<Endereco> response = client.Execute<Endereco>(request); // A resposta é do tipo IRestResponse<Endereco>

            if (response.IsSuccessful)
            {
                // Obtemos o objeto deserializando a resposta JSON
                var endereco = response.Data;

                if (!response.Content.Contains("erro"))
                {
                    txtLogradouro.Text = endereco.logradouro;
                    txtBairro.Text = endereco.bairro;
                    txtCidade.Text = endereco.localidade;
                    //cbmEstado.Items.Clear();
                    cbmEstado.Refresh();
                    cbmEstado.SelectedItem = endereco.uf;
                    txtComplemento.Text = endereco.complemento;
                    txtComplemento.Focus();
                    txtComplemento.SelectAll();
                    txtLogradouro.Enabled = false;
                    txtLogradouro.Focus();
                    txtLogradouro.SelectAll();
                    txtBairro.Enabled = false;
                    txtCidade.Enabled = false;
                    cbmEstado.Enabled = false;
                    //MessageBox.Show(cbmEstado.SelectedItem.ToString());
                }
                else
                {
                    DialogResult result = MessageBox.Show("Cep não encontrado, deseja continuar mesmo assim?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Verificar qual botão foi pressionado
                    if (result == DialogResult.Yes)
                    {
                        // O usuário clicou em "Sim"
                        // cbmEstado.Items.Clear();
                        // cbmEstado.Refresh();
                        //  cbmEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
                        //  cbmEstado.Refresh();
                        txtLogradouro.Enabled = true;
                        txtLogradouro.Focus();
                        txtLogradouro.SelectAll();
                        txtBairro.Enabled = true;
                        txtCidade.Enabled = true;
                        cbmEstado.Enabled = true;

                    }
                    else
                    {
                        txtCep.Clear();
                        txtCep.Focus();
                        txtCep.SelectAll();
                    }

                }
            }
            else
            {
                MessageBox.Show("Erro ao consultar o CEP.");
            }
        }

        private void btnListarConsultas_Click(object sender, EventArgs e)
        {
            frmListarAgendamento frm = new frmListarAgendamento(false, idPaciente,true);
            frm.ShowDialog();
        }
    }
}
