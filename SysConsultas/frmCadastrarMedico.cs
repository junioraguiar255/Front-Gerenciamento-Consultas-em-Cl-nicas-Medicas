using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using RestSharp;
using SysConsultas.Model;
using System.Diagnostics;
using System.Text;

namespace SysConsultas
{
    public partial class frmCadastrarMedico : Form
    {

        bool modoEdicao;
        int idMedico = 0;
        public frmCadastrarMedico(bool ehModoEdicao = false, int id = 0)
        {
            InitializeComponent();


            modoEdicao = ehModoEdicao;
            cbmEspecialidade.Items.Clear();

            List<string> especialidades = new List<string> { "ORTOPEDIA", "CARDIOLOGIA", "GINECOLOGIA", "DERMATOLOGIA" };
            cbmEspecialidade.DataSource = especialidades;
            List<string> estados = new List<string> { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };
            cbmEstado.DataSource = estados;
            cbmEspecialidade.Refresh();
            cbmEstado.Refresh();
            cbmEspecialidade.SelectedIndex = 0;
            cbmEstado.SelectedIndex = 0;
            if (ehModoEdicao)
            {
                txtModoFuncionalidade.Text = "Modo de edição";
                btnSalvar.Text = "Editar";
                editarCadastroAsync(id);
                idMedico = id;
                txtUsuario.Visible = false;
                txtSenha.Visible = false;
                label12.Visible = false;
                label11.Visible = false;
                return;
            }
            txtModoFuncionalidade.Text = "Modo de inclusão";

        }

        public async Task editarCadastroAsync(int id)
        {
            string url = $"http://localhost:8080/medicos/{id}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        Medico medico = JsonConvert.DeserializeObject<Medico>(json);

                        txtNome.Text = medico.Nome;
                        txtEmail.Text = medico.Email;
                        txtCrm.Text = medico.Crm;
                        txtLogradouro.Text = medico.Endereco.logradouro;
                        txtBairro.Text = medico.Endereco.bairro;
                        txtCep.Text = medico.Endereco.cep;
                        txtCidade.Text = medico.Endereco.cidade;
                        txtComplemento.Text = medico.Endereco.complemento;
                        txtNumero.Text = medico.Endereco.numero;
                        cbmEspecialidade.SelectedItem = medico.Especialidade;
                        cbmEstado.SelectedItem = medico.Endereco.uf;
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
            txtCrm.Clear();
            cbmEspecialidade.SelectedIndex = 0;
            txtLogradouro.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            cbmEstado.SelectedIndex = 0;
            txtComplemento.Clear();
            txtNumero.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
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

            var cadastroMedico = new CadastroMedicoDTO
            {
                nome = txtNome.Text,
                email = txtEmail.Text,
                crm = txtCrm.Text,
                especialidade = EspecialidadeUtils.CriarEspecialidade(cbmEspecialidade.SelectedIndex),
                endereco = endereco
            };

            if (modoEdicao)
            {
                cadastroMedico.id = idMedico;
            }
            else
            {
                cadastroMedico.login = txtUsuario.Text;
                cadastroMedico.senha = txtSenha.Text;
            }

            var json = JsonConvert.SerializeObject(cadastroMedico);

            using var httpClient = new HttpClient();
            var content = new StringContent(json, Encoding.UTF8, "application/json");


            Task<HttpResponseMessage> responseTask = null;

            String mensagemOk;
            String mensagemErro;

            if (modoEdicao)
            {
                responseTask = httpClient.PutAsync(ValoresGlobais.url + "medicos", content);
                mensagemOk = "Médico Editado Com sucesso ";
                mensagemErro = "Erro ao Editar Médico ";

            }
            else
            {
                responseTask = httpClient.PostAsync(ValoresGlobais.url + "medicos", content);
                mensagemOk = "Médico Cadastrado Com sucesso ";
                mensagemErro = "Erro ao Cadastrar Médico ";
            }

            // Espera até que a tarefa seja concluída
            HttpResponseMessage response = await responseTask;


            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(mensagemOk);
                limparFormulario();
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
                string.IsNullOrEmpty(txtCrm.Text) ||
                string.IsNullOrEmpty(txtCep.Text) ||
                string.IsNullOrEmpty(txtCidade.Text) ||
                string.IsNullOrEmpty(txtNumero.Text))
            {

                // Se algum dos campos estiver vazio, exiba uma mensagem para o usuário ou faça alguma outra ação
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
            else
            {
                if (modoEdicao == false){
                    if ((string.IsNullOrEmpty(txtUsuario.Text) ||
                    string.IsNullOrEmpty(txtSenha.Text)))
                    {
                        MessageBox.Show("Digite o login e senha do médico.");
                        return;
                    }
                }
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
                      //  cbmEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
                        cbmEstado.Refresh();
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

        private void txtCep_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clicouValidarCep();
            }
        }
    }


}
