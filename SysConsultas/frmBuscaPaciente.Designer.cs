namespace SysConsultas
{
    partial class frmBuscaPaciente
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
            label2 = new Label();
            txtIdPaciente = new TextBox();
            txtPaciente = new TextBox();
            label3 = new Label();
            btnBuscaPaciente = new Button();
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            listBoxPacientes = new ListBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(146, 19);
            label2.TabIndex = 9;
            label2.Text = "Selecione o Paciente";
            // 
            // txtIdPaciente
            // 
            txtIdPaciente.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdPaciente.Location = new Point(12, 302);
            txtIdPaciente.Name = "txtIdPaciente";
            txtIdPaciente.PlaceholderText = "Digite o Nome do paciente";
            txtIdPaciente.Size = new Size(184, 26);
            txtIdPaciente.TabIndex = 35;
            txtIdPaciente.Visible = false;
            txtIdPaciente.KeyDown += txtIdPaciente_KeyDown;
            txtIdPaciente.KeyPress += txtIdPaciente_KeyPress;
            // 
            // txtPaciente
            // 
            txtPaciente.Enabled = false;
            txtPaciente.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaciente.Location = new Point(155, 225);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new Size(547, 26);
            txtPaciente.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 228);
            label3.Name = "label3";
            label3.Size = new Size(150, 19);
            label3.TabIndex = 36;
            label3.Text = "Paciente Selecionado";
            // 
            // btnBuscaPaciente
            // 
            btnBuscaPaciente.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscaPaciente.Location = new Point(713, 50);
            btnBuscaPaciente.Name = "btnBuscaPaciente";
            btnBuscaPaciente.Size = new Size(75, 26);
            btnBuscaPaciente.TabIndex = 38;
            btnBuscaPaciente.Text = "Buscar";
            btnBuscaPaciente.UseVisualStyleBackColor = true;
            btnBuscaPaciente.Click += btnBuscaPaciente_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(534, 257);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 26);
            btnLimpar.TabIndex = 41;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(615, 257);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 26);
            btnSalvar.TabIndex = 40;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(426, 257);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 26);
            btnCancelar.TabIndex = 39;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // listBoxPacientes
            // 
            listBoxPacientes.FormattingEnabled = true;
            listBoxPacientes.ItemHeight = 15;
            listBoxPacientes.Location = new Point(155, 50);
            listBoxPacientes.Name = "listBoxPacientes";
            listBoxPacientes.Size = new Size(547, 169);
            listBoxPacientes.TabIndex = 43;
            // 
            // frmBuscaPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 340);
            Controls.Add(listBoxPacientes);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(btnBuscaPaciente);
            Controls.Add(txtPaciente);
            Controls.Add(label3);
            Controls.Add(txtIdPaciente);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBuscaPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Busca Paciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtIdPaciente;
        private TextBox txtPaciente;
        private Label label3;
        private Button btnBuscaPaciente;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnCancelar;
        private ListBox listBoxPacientes;
    }
}