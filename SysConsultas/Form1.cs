using Newtonsoft.Json;
using SysConsultas.Model;
using System.Text;

namespace SysConsultas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtUsuario.Focus();
            txtUsuario.SelectAll();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            // Chamando o m�todo Autenticar de forma ass�ncrona
            await Autenticar();
        }

        private async Task Autenticar()
        {
            // Obter dados do usu�rio do formul�rio
            var usuario = new Usuario
            {
                login = txtUsuario.Text,
                senha = txtSenha.Text
            };


            // Converter o objeto Usuario para JSON
            var jsonContent = JsonConvert.SerializeObject(usuario);

            // Criar um objeto StringContent para enviar o JSON no corpo da requisi��o
            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            // Criar um objeto HttpClient
            using var httpClient = new HttpClient();

            // Definir a URL da sua API
            string apiUrl = ValoresGlobais.url + "usuarios/valida-login";

            try
            {
                // Fazer uma requisi��o POST passando o JSON no corpo da requisi��o
                var response = await httpClient.PostAsync(apiUrl, httpContent);

                // Verificar se a resposta foi bem-sucedida (c�digo 2xx)
                if (response.IsSuccessStatusCode)
                {

                    string json = await response.Content.ReadAsStringAsync();

                    Usuario usuarioRetorno = JsonConvert.DeserializeObject<Usuario>(json);
                    MenuPrincipal menu = new MenuPrincipal(usuarioRetorno);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    // Se a resposta n�o foi bem-sucedida, mostrar o c�digo de status
                    Console.WriteLine($"Ocorreu um erro. C�digo de status: {response.StatusCode}");
                    MessageBox.Show("Login ou senha incorretos");
                }
            }
            catch (Exception ex)
            {
                // Lidar com exce��es, se houver
                Console.WriteLine($"Ocorreu uma exce��o: {ex.Message}");
                MessageBox.Show($"Ocorreu uma exce��o: {ex.Message}");
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
                txtSenha.SelectAll();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}