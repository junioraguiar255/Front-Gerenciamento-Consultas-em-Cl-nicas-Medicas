namespace SysConsultas
{
    partial class frmCadastrarPaciente
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
            txtModoFuncionalidade = new Label();
            btnValidarCep = new Button();
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            txtNumero = new TextBox();
            label10 = new Label();
            txtComplemento = new TextBox();
            label9 = new Label();
            label8 = new Label();
            cbmEstado = new ComboBox();
            txtCidade = new TextBox();
            label7 = new Label();
            txtCep = new MaskedTextBox();
            label6 = new Label();
            txtBairro = new TextBox();
            label5 = new Label();
            txtLogradouro = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            txtNome = new TextBox();
            labelUsuario = new Label();
            label2 = new Label();
            txtCpf = new MaskedTextBox();
            btnListarConsultas = new Button();
            SuspendLayout();
            // 
            // txtModoFuncionalidade
            // 
            txtModoFuncionalidade.AutoSize = true;
            txtModoFuncionalidade.ForeColor = Color.Red;
            txtModoFuncionalidade.Location = new Point(7, 7);
            txtModoFuncionalidade.Name = "txtModoFuncionalidade";
            txtModoFuncionalidade.Size = new Size(44, 15);
            txtModoFuncionalidade.TabIndex = 54;
            txtModoFuncionalidade.Text = "label11";
            // 
            // btnValidarCep
            // 
            btnValidarCep.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnValidarCep.Location = new Point(848, 46);
            btnValidarCep.Name = "btnValidarCep";
            btnValidarCep.Size = new Size(98, 26);
            btnValidarCep.TabIndex = 53;
            btnValidarCep.Text = "Validar";
            btnValidarCep.UseVisualStyleBackColor = true;
            btnValidarCep.Click += btnValidarCep_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(573, 392);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 26);
            btnLimpar.TabIndex = 52;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(654, 392);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 26);
            btnSalvar.TabIndex = 51;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(465, 392);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 26);
            btnCancelar.TabIndex = 50;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(578, 326);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(269, 26);
            txtNumero.TabIndex = 49;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(503, 333);
            label10.Name = "label10";
            label10.Size = new Size(68, 19);
            label10.TabIndex = 48;
            label10.Text = "Numero:";
            // 
            // txtComplemento
            // 
            txtComplemento.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComplemento.Location = new Point(578, 281);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(269, 26);
            txtComplemento.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(465, 288);
            label9.Name = "label9";
            label9.Size = new Size(106, 19);
            label9.TabIndex = 46;
            label9.Text = "Complemento:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(511, 245);
            label8.Name = "label8";
            label8.Size = new Size(60, 19);
            label8.TabIndex = 45;
            label8.Text = "Estado:";
            // 
            // cbmEstado
            // 
            cbmEstado.Enabled = false;
            cbmEstado.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbmEstado.FormattingEnabled = true;
            cbmEstado.Location = new Point(578, 237);
            cbmEstado.Name = "cbmEstado";
            cbmEstado.Size = new Size(269, 27);
            cbmEstado.TabIndex = 44;
            // 
            // txtCidade
            // 
            txtCidade.Enabled = false;
            txtCidade.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.Location = new Point(578, 188);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(269, 26);
            txtCidade.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(511, 195);
            label7.Name = "label7";
            label7.Size = new Size(61, 19);
            label7.TabIndex = 42;
            label7.Text = "Cidade:";
            // 
            // txtCep
            // 
            txtCep.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCep.Location = new Point(573, 46);
            txtCep.Mask = "00000-000";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(269, 26);
            txtCep.TabIndex = 41;
            txtCep.KeyDown += txtCep_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(523, 49);
            label6.Name = "label6";
            label6.Size = new Size(44, 19);
            label6.TabIndex = 40;
            label6.Text = "CEP:";
            // 
            // txtBairro
            // 
            txtBairro.Enabled = false;
            txtBairro.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBairro.Location = new Point(578, 136);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(269, 26);
            txtBairro.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(515, 142);
            label5.Name = "label5";
            label5.Size = new Size(57, 19);
            label5.TabIndex = 38;
            label5.Text = "Bairro:";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Enabled = false;
            txtLogradouro.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogradouro.Location = new Point(578, 90);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(269, 26);
            txtLogradouro.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(480, 96);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 36;
            label4.Text = "Logradouro:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(121, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 26);
            txtEmail.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 94);
            label1.Name = "label1";
            label1.Size = new Size(52, 19);
            label1.TabIndex = 34;
            label1.Text = "Email:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(121, 45);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(269, 26);
            txtNome.TabIndex = 33;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsuario.Location = new Point(52, 49);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(54, 19);
            labelUsuario.TabIndex = 32;
            labelUsuario.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(52, 143);
            label2.Name = "label2";
            label2.Size = new Size(43, 19);
            label2.TabIndex = 55;
            label2.Text = "CPF:";
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpf.Location = new Point(121, 139);
            txtCpf.Mask = "000.000.000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(269, 26);
            txtCpf.TabIndex = 56;
            // 
            // btnListarConsultas
            // 
            btnListarConsultas.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnListarConsultas.Location = new Point(361, 392);
            btnListarConsultas.Name = "btnListarConsultas";
            btnListarConsultas.Size = new Size(98, 26);
            btnListarConsultas.TabIndex = 57;
            btnListarConsultas.Text = "Consultas";
            btnListarConsultas.UseVisualStyleBackColor = true;
            btnListarConsultas.Click += btnListarConsultas_Click;
            // 
            // frmCadastrarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 450);
            Controls.Add(btnListarConsultas);
            Controls.Add(txtCpf);
            Controls.Add(label2);
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
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(labelUsuario);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadastrarPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de pacientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtModoFuncionalidade;
        private Button btnValidarCep;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnCancelar;
        private TextBox txtNumero;
        private Label label10;
        private TextBox txtComplemento;
        private Label label9;
        private Label label8;
        private ComboBox cbmEstado;
        private TextBox txtCidade;
        private Label label7;
        private MaskedTextBox txtCep;
        private Label label6;
        private TextBox txtBairro;
        private Label label5;
        private TextBox txtLogradouro;
        private Label label4;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtNome;
        private Label labelUsuario;
        private Label label2;
        private MaskedTextBox txtCpf;
        private Button btnListarConsultas;
    }
}