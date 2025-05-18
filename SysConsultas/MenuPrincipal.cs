using SysConsultas.Model;

namespace SysConsultas
{
    public partial class MenuPrincipal : Form
    {
        Usuario usuario;
        public MenuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            inicializaPermissoes(usuario);
            this.usuario = usuario;
        }

        public void inicializaPermissoes(Usuario usuario)
        {
            if (usuario.medico)
            {
                menuMinhaConsulta.Visible = true;
            }
            else
            {
                menuCadastro.Visible = true;
                menuConsulta.Visible = true;
                menuRelatorio.Visible = true;
            }

            usuáriosToolStripMenuItem.Visible = usuario.admin;

        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarMedico cadastrarMedico = new frmCadastrarMedico();
            cadastrarMedico.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void medicosCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarMedico frmListarMedico = new frmListarMedico();
            frmListarMedico.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarPaciente frmCadastrarPaciente = new frmCadastrarPaciente();
            frmCadastrarPaciente.Show();
        }

        private void pacientesCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarPaciente frmListar = new frmListarPaciente();
            frmListar.Show();
        }

        private void agendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgendamento frmAgendamento = new frmAgendamento();
            frmAgendamento.Show();
        }

        private void consultarAgendamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarAgendamento frmListarAgendamento = new frmListarAgendamento();
            frmListarAgendamento.Show();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMinhasConsultas frm = new frmMinhasConsultas(usuario);
            frm.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario frm = new frmCadastroUsuario();
            frm.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
