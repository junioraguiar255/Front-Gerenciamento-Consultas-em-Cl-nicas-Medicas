namespace SysConsultas
{
    partial class frmCadastrarMedico
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
            txtNome = new TextBox();
            labelUsuario = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            txtCrm = new TextBox();
            label2 = new Label();
            cbmEspecialidade = new ComboBox();
            label3 = new Label();
            txtLogradouro = new TextBox();
            label4 = new Label();
            txtBairro = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtCep = new MaskedTextBox();
            txtCidade = new TextBox();
            label7 = new Label();
            label8 = new Label();
            cbmEstado = new ComboBox();
            txtComplemento = new TextBox();
            label9 = new Label();
            txtNumero = new TextBox();
            label10 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnLimpar = new Button();
            btnValidarCep = new Button();
            txtModoFuncionalidade = new Label();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(129, 42);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(269, 26);
            txtNome.TabIndex = 5;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsuario.Location = new Point(60, 46);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(54, 19);
            labelUsuario.TabIndex = 4;
            labelUsuario.Text = "Nome:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(129, 87);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 26);
            txtEmail.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(60, 91);
            label1.Name = "label1";
            label1.Size = new Size(52, 19);
            label1.TabIndex = 6;
            label1.Text = "Email:";
            // 
            // txtCrm
            // 
            txtCrm.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrm.Location = new Point(129, 136);
            txtCrm.Name = "txtCrm";
            txtCrm.Size = new Size(269, 26);
            txtCrm.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(60, 140);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 8;
            label2.Text = "CRM:";
            // 
            // cbmEspecialidade
            // 
            cbmEspecialidade.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbmEspecialidade.FormattingEnabled = true;
            cbmEspecialidade.Location = new Point(129, 189);
            cbmEspecialidade.Name = "cbmEspecialidade";
            cbmEspecialidade.Size = new Size(269, 27);
            cbmEspecialidade.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 192);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 11;
            label3.Text = "Especialidade:";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Enabled = false;
            txtLogradouro.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogradouro.Location = new Point(586, 87);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(269, 26);
            txtLogradouro.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(488, 93);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 12;
            label4.Text = "Logradouro:";
            // 
            // txtBairro
            // 
            txtBairro.Enabled = false;
            txtBairro.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBairro.Location = new Point(586, 133);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(269, 26);
            txtBairro.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(523, 139);
            label5.Name = "label5";
            label5.Size = new Size(57, 19);
            label5.TabIndex = 14;
            label5.Text = "Bairro:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(531, 46);
            label6.Name = "label6";
            label6.Size = new Size(44, 19);
            label6.TabIndex = 16;
            label6.Text = "CEP:";
            // 
            // txtCep
            // 
            txtCep.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCep.Location = new Point(581, 43);
            txtCep.Mask = "00000-000";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(269, 26);
            txtCep.TabIndex = 18;
            txtCep.KeyDown += txtCep_KeyDown_1;
            // 
            // txtCidade
            // 
            txtCidade.Enabled = false;
            txtCidade.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.Location = new Point(586, 185);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(269, 26);
            txtCidade.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(519, 192);
            label7.Name = "label7";
            label7.Size = new Size(61, 19);
            label7.TabIndex = 19;
            label7.Text = "Cidade:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(519, 242);
            label8.Name = "label8";
            label8.Size = new Size(60, 19);
            label8.TabIndex = 22;
            label8.Text = "Estado:";
            // 
            // cbmEstado
            // 
            cbmEstado.Enabled = false;
            cbmEstado.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbmEstado.FormattingEnabled = true;
            cbmEstado.Location = new Point(586, 234);
            cbmEstado.Name = "cbmEstado";
            cbmEstado.Size = new Size(269, 27);
            cbmEstado.TabIndex = 21;
            // 
            // txtComplemento
            // 
            txtComplemento.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComplemento.Location = new Point(586, 278);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(269, 26);
            txtComplemento.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(473, 285);
            label9.Name = "label9";
            label9.Size = new Size(106, 19);
            label9.TabIndex = 23;
            label9.Text = "Complemento:";
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(586, 323);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(269, 26);
            txtNumero.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(511, 330);
            label10.Name = "label10";
            label10.Size = new Size(68, 19);
            label10.TabIndex = 25;
            label10.Text = "Numero:";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(662, 389);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 26);
            btnSalvar.TabIndex = 28;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(473, 389);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 26);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(581, 389);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 26);
            btnLimpar.TabIndex = 29;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnValidarCep
            // 
            btnValidarCep.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnValidarCep.Location = new Point(856, 43);
            btnValidarCep.Name = "btnValidarCep";
            btnValidarCep.Size = new Size(98, 26);
            btnValidarCep.TabIndex = 30;
            btnValidarCep.Text = "Validar";
            btnValidarCep.UseVisualStyleBackColor = true;
            btnValidarCep.Click += btnValidarCep_Click;
            // 
            // txtModoFuncionalidade
            // 
            txtModoFuncionalidade.AutoSize = true;
            txtModoFuncionalidade.ForeColor = Color.Red;
            txtModoFuncionalidade.Location = new Point(15, 4);
            txtModoFuncionalidade.Name = "txtModoFuncionalidade";
            txtModoFuncionalidade.Size = new Size(44, 15);
            txtModoFuncionalidade.TabIndex = 31;
            txtModoFuncionalidade.Text = "label11";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(129, 301);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(269, 26);
            txtSenha.TabIndex = 35;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(129, 256);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(269, 26);
            txtUsuario.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(57, 304);
            label11.Name = "label11";
            label11.Size = new Size(55, 19);
            label11.TabIndex = 33;
            label11.Text = "Senha:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(46, 259);
            label12.Name = "label12";
            label12.Size = new Size(66, 19);
            label12.TabIndex = 32;
            label12.Text = "Usuário:";
            // 
            // frmCadastrarMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 475);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(txtModoFuncionalidade);
            Controls.Add(btnValidarCep);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNumero);
            Controls.Add(label10);
            Controls.Add(txtComplemento);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(cbmEstado);
            Controls.Add(txtCidade);
            Controls.Add(label7);
            Controls.Add(txtCep);
            Controls.Add(label6);
            Controls.Add(txtBairro);
            Controls.Add(label5);
            Controls.Add(txtLogradouro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbmEspecialidade);
            Controls.Add(txtCrm);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(labelUsuario);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadastrarMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de medicos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label labelUsuario;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtCrm;
        private Label label2;
        private ComboBox cbmEspecialidade;
        private Label label3;
        private TextBox txtLogradouro;
        private Label label4;
        private TextBox txtBairro;
        private Label label5;
        private Label label6;
        private MaskedTextBox txtCep;
        private TextBox txtCidade;
        private Label label7;
        private Label label8;
        private ComboBox cbmEstado;
        private TextBox txtComplemento;
        private Label label9;
        private TextBox txtNumero;
        private Label label10;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnLimpar;
        private Button btnValidarCep;
        private Label txtModoFuncionalidade;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label label11;
        private Label label12;
    }
}