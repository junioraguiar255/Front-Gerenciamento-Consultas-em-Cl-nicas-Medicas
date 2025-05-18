namespace SysConsultas
{
    partial class frmCadastroUsuario
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
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            label11 = new Label();
            label12 = new Label();
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            checkAdmin = new CheckBox();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(151, 107);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(269, 26);
            txtSenha.TabIndex = 48;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(151, 62);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(269, 26);
            txtUsuario.TabIndex = 47;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(79, 110);
            label11.Name = "label11";
            label11.Size = new Size(55, 19);
            label11.TabIndex = 46;
            label11.Text = "Senha:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(68, 65);
            label12.Name = "label12";
            label12.Size = new Size(66, 19);
            label12.TabIndex = 45;
            label12.Text = "Usuário:";
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(289, 223);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 26);
            btnLimpar.TabIndex = 44;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(370, 223);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 26);
            btnSalvar.TabIndex = 43;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(181, 223);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 26);
            btnCancelar.TabIndex = 42;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // checkAdmin
            // 
            checkAdmin.AutoSize = true;
            checkAdmin.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkAdmin.Location = new Point(151, 150);
            checkAdmin.Name = "checkAdmin";
            checkAdmin.Size = new Size(123, 23);
            checkAdmin.TabIndex = 49;
            checkAdmin.Text = "Administrador";
            checkAdmin.UseVisualStyleBackColor = true;
            // 
            // frmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 296);
            Controls.Add(checkAdmin);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de usuários";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label label11;
        private Label label12;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnCancelar;
        private CheckBox checkAdmin;
    }
}