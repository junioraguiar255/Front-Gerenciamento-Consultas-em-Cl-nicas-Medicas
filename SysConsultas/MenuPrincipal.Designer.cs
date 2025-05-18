namespace SysConsultas
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuArquivo = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuCadastro = new ToolStripMenuItem();
            medicosToolStripMenuItem = new ToolStripMenuItem();
            pacientesToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            menuRelatorio = new ToolStripMenuItem();
            medicosCadastradosToolStripMenuItem = new ToolStripMenuItem();
            pacientesCadastradosToolStripMenuItem = new ToolStripMenuItem();
            menuConsulta = new ToolStripMenuItem();
            agendarToolStripMenuItem = new ToolStripMenuItem();
            consultarAgendamentosToolStripMenuItem = new ToolStripMenuItem();
            menuMinhaConsulta = new ToolStripMenuItem();
            visualizarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuArquivo, menuCadastro, menuRelatorio, menuConsulta, menuMinhaConsulta });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuArquivo
            // 
            menuArquivo.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            menuArquivo.Name = "menuArquivo";
            menuArquivo.Size = new Size(61, 20);
            menuArquivo.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // menuCadastro
            // 
            menuCadastro.DropDownItems.AddRange(new ToolStripItem[] { medicosToolStripMenuItem, pacientesToolStripMenuItem, usuáriosToolStripMenuItem });
            menuCadastro.Name = "menuCadastro";
            menuCadastro.Size = new Size(71, 20);
            menuCadastro.Text = "Cadastros";
            menuCadastro.Visible = false;
            // 
            // medicosToolStripMenuItem
            // 
            medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            medicosToolStripMenuItem.Size = new Size(124, 22);
            medicosToolStripMenuItem.Text = "Medicos";
            medicosToolStripMenuItem.Click += medicosToolStripMenuItem_Click;
            // 
            // pacientesToolStripMenuItem
            // 
            pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            pacientesToolStripMenuItem.Size = new Size(124, 22);
            pacientesToolStripMenuItem.Text = "Pacientes";
            pacientesToolStripMenuItem.Click += pacientesToolStripMenuItem_Click;
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(124, 22);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // menuRelatorio
            // 
            menuRelatorio.DropDownItems.AddRange(new ToolStripItem[] { medicosCadastradosToolStripMenuItem, pacientesCadastradosToolStripMenuItem });
            menuRelatorio.Name = "menuRelatorio";
            menuRelatorio.Size = new Size(71, 20);
            menuRelatorio.Text = "Relatórios";
            menuRelatorio.Visible = false;
            // 
            // medicosCadastradosToolStripMenuItem
            // 
            medicosCadastradosToolStripMenuItem.Name = "medicosCadastradosToolStripMenuItem";
            medicosCadastradosToolStripMenuItem.Size = new Size(192, 22);
            medicosCadastradosToolStripMenuItem.Text = "Medicos cadastrados";
            medicosCadastradosToolStripMenuItem.Click += medicosCadastradosToolStripMenuItem_Click;
            // 
            // pacientesCadastradosToolStripMenuItem
            // 
            pacientesCadastradosToolStripMenuItem.Name = "pacientesCadastradosToolStripMenuItem";
            pacientesCadastradosToolStripMenuItem.Size = new Size(192, 22);
            pacientesCadastradosToolStripMenuItem.Text = "Pacientes Cadastrados";
            pacientesCadastradosToolStripMenuItem.Click += pacientesCadastradosToolStripMenuItem_Click;
            // 
            // menuConsulta
            // 
            menuConsulta.DropDownItems.AddRange(new ToolStripItem[] { agendarToolStripMenuItem, consultarAgendamentosToolStripMenuItem });
            menuConsulta.Name = "menuConsulta";
            menuConsulta.Size = new Size(66, 20);
            menuConsulta.Text = "Consulta";
            menuConsulta.Visible = false;
            // 
            // agendarToolStripMenuItem
            // 
            agendarToolStripMenuItem.Name = "agendarToolStripMenuItem";
            agendarToolStripMenuItem.Size = new Size(207, 22);
            agendarToolStripMenuItem.Text = "Agendar";
            agendarToolStripMenuItem.Click += agendarToolStripMenuItem_Click;
            // 
            // consultarAgendamentosToolStripMenuItem
            // 
            consultarAgendamentosToolStripMenuItem.Name = "consultarAgendamentosToolStripMenuItem";
            consultarAgendamentosToolStripMenuItem.Size = new Size(207, 22);
            consultarAgendamentosToolStripMenuItem.Text = "Consultar agendamentos";
            consultarAgendamentosToolStripMenuItem.Click += consultarAgendamentosToolStripMenuItem_Click;
            // 
            // menuMinhaConsulta
            // 
            menuMinhaConsulta.DropDownItems.AddRange(new ToolStripItem[] { visualizarToolStripMenuItem });
            menuMinhaConsulta.Name = "menuMinhaConsulta";
            menuMinhaConsulta.Size = new Size(111, 20);
            menuMinhaConsulta.Text = "Minhas consultas";
            menuMinhaConsulta.Visible = false;
            // 
            // visualizarToolStripMenuItem
            // 
            visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            visualizarToolStripMenuItem.Size = new Size(123, 22);
            visualizarToolStripMenuItem.Text = "Visualizar";
            visualizarToolStripMenuItem.Click += visualizarToolStripMenuItem_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            WindowState = FormWindowState.Maximized;
            Load += MenuPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuArquivo;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem menuCadastro;
        private ToolStripMenuItem medicosToolStripMenuItem;
        private ToolStripMenuItem menuRelatorio;
        private ToolStripMenuItem medicosCadastradosToolStripMenuItem;
        private ToolStripMenuItem pacientesToolStripMenuItem;
        private ToolStripMenuItem pacientesCadastradosToolStripMenuItem;
        private ToolStripMenuItem menuConsulta;
        private ToolStripMenuItem agendarToolStripMenuItem;
        private ToolStripMenuItem consultarAgendamentosToolStripMenuItem;
        private ToolStripMenuItem menuMinhaConsulta;
        private ToolStripMenuItem visualizarToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
    }
}