namespace SysConsultas
{
    partial class frmCancelarAgendamento
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
            label5 = new Label();
            cbmMotivo = new ComboBox();
            SuspendLayout();
            // 
            // btnBuscaMedico
            // 
            btnBuscaMedico.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscaMedico.Location = new Point(669, 183);
            btnBuscaMedico.Name = "btnBuscaMedico";
            btnBuscaMedico.Size = new Size(75, 26);
            btnBuscaMedico.TabIndex = 51;
            btnBuscaMedico.Text = "Buscar";
            btnBuscaMedico.UseVisualStyleBackColor = true;
            // 
            // txtMedico
            // 
            txtMedico.Enabled = false;
            txtMedico.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedico.Location = new Point(102, 183);
            txtMedico.Name = "txtMedico";
            txtMedico.Size = new Size(547, 26);
            txtMedico.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 187);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 49;
            label4.Text = "Medico:";
            // 
            // btnBuscaPaciente
            // 
            btnBuscaPaciente.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscaPaciente.Location = new Point(669, 134);
            btnBuscaPaciente.Name = "btnBuscaPaciente";
            btnBuscaPaciente.Size = new Size(75, 26);
            btnBuscaPaciente.TabIndex = 48;
            btnBuscaPaciente.Text = "Buscar";
            btnBuscaPaciente.UseVisualStyleBackColor = true;
            // 
            // txtPaciente
            // 
            txtPaciente.Enabled = false;
            txtPaciente.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaciente.Location = new Point(102, 134);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new Size(547, 26);
            txtPaciente.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 138);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 46;
            label3.Text = "Paciente:";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(489, 277);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 26);
            btnSalvar.TabIndex = 44;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(385, 277);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 26);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 42);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 40;
            label1.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(102, 38);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(188, 26);
            dateTimePicker1.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(33, 92);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 52;
            label5.Text = "Motivo:";
            // 
            // cbmMotivo
            // 
            cbmMotivo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbmMotivo.FormattingEnabled = true;
            cbmMotivo.Location = new Point(102, 84);
            cbmMotivo.Name = "cbmMotivo";
            cbmMotivo.Size = new Size(269, 27);
            cbmMotivo.TabIndex = 53;
            // 
            // frmCancelarAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 446);
            Controls.Add(cbmMotivo);
            Controls.Add(label5);
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
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCancelarAgendamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cancelar Agendamento";
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
        private Label label5;
        private ComboBox cbmMotivo;
    }
}