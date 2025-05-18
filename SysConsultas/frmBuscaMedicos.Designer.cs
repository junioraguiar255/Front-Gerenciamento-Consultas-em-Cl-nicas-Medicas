namespace SysConsultas
{
    partial class frmBuscaMedicos
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
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnBuscaPaciente = new Button();
            txtMedico = new TextBox();
            label3 = new Label();
            txtIdMedico = new TextBox();
            label2 = new Label();
            listBoxMedicos = new ListBox();
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(567, 268);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 26);
            btnLimpar.TabIndex = 49;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(648, 268);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 26);
            btnSalvar.TabIndex = 48;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(459, 268);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 26);
            btnCancelar.TabIndex = 47;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBuscaPaciente
            // 
            btnBuscaPaciente.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscaPaciente.Location = new Point(717, 51);
            btnBuscaPaciente.Name = "btnBuscaPaciente";
            btnBuscaPaciente.Size = new Size(75, 26);
            btnBuscaPaciente.TabIndex = 46;
            btnBuscaPaciente.Text = "Buscar";
            btnBuscaPaciente.UseVisualStyleBackColor = true;
            btnBuscaPaciente.Click += btnBuscaPaciente_Click;
            // 
            // txtMedico
            // 
            txtMedico.Enabled = false;
            txtMedico.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedico.Location = new Point(164, 196);
            txtMedico.Name = "txtMedico";
            txtMedico.Size = new Size(547, 26);
            txtMedico.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 203);
            label3.Name = "label3";
            label3.Size = new Size(147, 19);
            label3.TabIndex = 44;
            label3.Text = "Médico selecionado:";
            // 
            // txtIdMedico
            // 
            txtIdMedico.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdMedico.Location = new Point(11, 302);
            txtIdMedico.Name = "txtIdMedico";
            txtIdMedico.PlaceholderText = "Digite o Nome do Medico";
            txtIdMedico.Size = new Size(184, 26);
            txtIdMedico.TabIndex = 43;
            txtIdMedico.Visible = false;
            txtIdMedico.KeyDown += txtIdMedico_KeyDown;
            txtIdMedico.KeyPress += txtIdPaciente_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 51);
            label2.Name = "label2";
            label2.Size = new Size(145, 19);
            label2.TabIndex = 42;
            label2.Text = "Selecione o Médico:";
            // 
            // listBoxMedicos
            // 
            listBoxMedicos.FormattingEnabled = true;
            listBoxMedicos.ItemHeight = 15;
            listBoxMedicos.Location = new Point(164, 51);
            listBoxMedicos.Name = "listBoxMedicos";
            listBoxMedicos.Size = new Size(547, 139);
            listBoxMedicos.TabIndex = 50;
            // 
            // frmBuscaMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 340);
            Controls.Add(listBoxMedicos);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(btnBuscaPaciente);
            Controls.Add(txtMedico);
            Controls.Add(label3);
            Controls.Add(txtIdMedico);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBuscaMedicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Busca de médicos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnBuscaPaciente;
        private TextBox txtMedico;
        private Label label3;
        private TextBox txtIdMedico;
        private Label label2;
        private ListBox listBoxMedicos;
    }
}