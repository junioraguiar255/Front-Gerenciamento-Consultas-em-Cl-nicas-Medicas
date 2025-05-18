using Newtonsoft.Json;
using SysConsultas.Model;
using System.Text;

namespace SysConsultas
{
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparFormulario();
        }

        private void limparFormulario()
        {
            txtSenha.Text = string.Empty;
            txtUsuario.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSenha.Text) ||
               string.IsNullOrEmpty(txtUsuario.Text))
            {

                // Se algum dos campos estiver vazio, exiba uma mensagem para o usuário ou faça alguma outra ação
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            cadastrarAsync();

        }

        public async Task cadastrarAsync()
        {
            var usuario = new Usuario
            {
                login = txtUsuario.Text,
                senha = txtSenha.Text,
                admin = checkAdmin.Checked ? true : false
            };

            var json = JsonConvert.SerializeObject(usuario);

            using var httpClient = new HttpClient();
            var content = new StringContent(json, Encoding.UTF8, "application/json");


            Task<HttpResponseMessage> responseTask = null;

            responseTask = httpClient.PostAsync(ValoresGlobais.url + "usuarios", content);

            HttpResponseMessage response = await responseTask;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Usuário cadastrado com sucesso");
                limparFormulario();
            }
            else
            {
                MessageBox.Show("Erro ao tentar inserir o usuário: " + response.StatusCode);
            }
        }

    }
}
