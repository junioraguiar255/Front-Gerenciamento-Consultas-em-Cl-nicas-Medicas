namespace SysConsultas
{
    partial class frmInserirObservacoes
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
            btnBuscaMedico = new Button();
            txtMedico = new TextBox();
            label4 = new Label();
            btnBuscaPaciente = new Button();
            txtPaciente = new TextBox();
            label3 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            txtObservacoes = new RichTextBox();
            btnHistoricoObservacoes = new Button();
            btnAtestado = new Button();
            SuspendLayout();
            // 
            // btnBuscaMedico
            // 
            btnBuscaMedico.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscaMedico.Location = new Point(670, 150);
            btnBuscaMedico.Name = "btnBuscaMedico";
            btnBuscaMedico.Size = new Size(75, 26);
            btnBuscaMedico.TabIndex = 63;
            btnBuscaMedico.Text = "Buscar";
            btnBuscaMedico.UseVisualStyleBackColor = true;
            // 
            // txtMedico
            // 
            txtMedico.Enabled = false;
            txtMedico.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedico.Location = new Point(103, 150);
            txtMedico.Name = "txtMedico";
            txtMedico.Size = new Size(547, 26);
            txtMedico.TabIndex = 62;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(34, 154);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 61;
            label4.Text = "Medico:";
            // 
            // btnBuscaPaciente
            // 
            btnBuscaPaciente.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscaPaciente.Location = new Point(670, 101);
            btnBuscaPaciente.Name = "btnBuscaPaciente";
            btnBuscaPaciente.Size = new Size(75, 26);
            btnBuscaPaciente.TabIndex = 60;
            btnBuscaPaciente.Text = "Buscar";
            btnBuscaPaciente.UseVisualStyleBackColor = true;
            // 
            // txtPaciente
            // 
            txtPaciente.Enabled = false;
            txtPaciente.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaciente.Location = new Point(103, 101);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new Size(547, 26);
            txtPaciente.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(34, 105);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 58;
            label3.Text = "Paciente:";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(670, 428);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 26);
            btnSalvar.TabIndex = 57;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(566, 428);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 26);
            btnCancelar.TabIndex = 56;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 61);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 55;
            label1.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(103, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(188, 26);
            dateTimePicker1.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 212);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 64;
            label2.Text = "Observações:";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtObservacoes.Location = new Point(139, 212);
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(511, 194);
            txtObservacoes.TabIndex = 65;
            txtObservacoes.Text = "";
            // 
            // btnHistoricoObservacoes
            // 
            btnHistoricoObservacoes.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistoricoObservacoes.Location = new Point(462, 428);
            btnHistoricoObservacoes.Name = "btnHistoricoObservacoes";
            btnHistoricoObservacoes.Size = new Size(98, 26);
            btnHistoricoObservacoes.TabIndex = 66;
            btnHistoricoObservacoes.Text = "Histórico";
            btnHistoricoObservacoes.UseVisualStyleBackColor = true;
            btnHistoricoObservacoes.Click += btnHistoricoObservacoes_Click;
            // 
            // btnAtestado
            // 
            btnAtestado.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtestado.Location = new Point(358, 428);
            btnAtestado.Name = "btnAtestado";
            btnAtestado.Size = new Size(98, 26);
            btnAtestado.TabIndex = 67;
            btnAtestado.Text = "Atestado";
            btnAtestado.UseVisualStyleBackColor = true;
            btnAtestado.Click += btnAtestado_Click;
            // 
            // frmInserirObservacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 505);
            Controls.Add(btnAtestado);
            Controls.Add(btnHistoricoObservacoes);
            Controls.Add(txtObservacoes);
            Controls.Add(label2);
            Controls.Add(btnBuscaMedico);
            Controls.Add(txtMedico);
            Controls.Add(label4);
            Controls.Add(btnBuscaPaciente);
            Controls.Add(txtPaciente);
            Controls.Add(label3);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInserirObservacoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inserir observação Medica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscaMedico;
        private TextBox txtMedico;
        private Label label4;
        private Button btnBuscaPaciente;
        private TextBox txtPaciente;
        private Label label3;
        private Button btnSalvar;
        private Button btnCancelar;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private RichTextBox txtObservacoes;
        private Button btnHistoricoObservacoes;
        private Button btnAtestado;
    }
}