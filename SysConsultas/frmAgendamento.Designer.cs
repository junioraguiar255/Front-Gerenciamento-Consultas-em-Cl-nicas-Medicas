namespace SysConsultas
{
    partial class frmAgendamento
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            cbmHorario = new ComboBox();
            btnLimpar = new Button();
            btnCancelar = new Button();
            txtPaciente = new TextBox();
            label3 = new Label();
            btnBuscaPaciente = new Button();
            btnBuscaMedico = new Button();
            txtMedico = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ckParticular = new CheckBox();
            ckPlanoDeSaude = new CheckBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(98, 51);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(188, 26);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 60);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 7;
            label1.Text = "Data:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 105);
            label2.Name = "label2";
            label2.Size = new Size(48, 19);
            label2.TabIndex = 8;
            label2.Text = "Hora:";
            // 
            // cbmHorario
            // 
            cbmHorario.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbmHorario.FormattingEnabled = true;
            cbmHorario.Location = new Point(98, 97);
            cbmHorario.Name = "cbmHorario";
            cbmHorario.Size = new Size(188, 27);
            cbmHorario.TabIndex = 22;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(372, 351);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 26);
            btnLimpar.TabIndex = 32;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(264, 351);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 26);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtPaciente
            // 
            txtPaciente.Enabled = false;
            txtPaciente.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaciente.Location = new Point(98, 152);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new Size(547, 26);
            txtPaciente.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 161);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 33;
            label3.Text = "Paciente:";
            // 
            // btnBuscaPaciente
            // 
            btnBuscaPaciente.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscaPaciente.Location = new Point(665, 152);
            btnBuscaPaciente.Name = "btnBuscaPaciente";
            btnBuscaPaciente.Size = new Size(75, 26);
            btnBuscaPaciente.TabIndex = 35;
            btnBuscaPaciente.Text = "Buscar";
            btnBuscaPaciente.UseVisualStyleBackColor = true;
            btnBuscaPaciente.Click += btnBuscaPaciente_Click;
            // 
            // btnBuscaMedico
            // 
            btnBuscaMedico.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscaMedico.Location = new Point(665, 201);
            btnBuscaMedico.Name = "btnBuscaMedico";
            btnBuscaMedico.Size = new Size(75, 26);
            btnBuscaMedico.TabIndex = 38;
            btnBuscaMedico.Text = "Buscar";
            btnBuscaMedico.UseVisualStyleBackColor = true;
            btnBuscaMedico.Click += btnBuscaMedico_Click;
            // 
            // txtMedico
            // 
            txtMedico.Enabled = false;
            txtMedico.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedico.Location = new Point(98, 201);
            txtMedico.Name = "txtMedico";
            txtMedico.Size = new Size(547, 26);
            txtMedico.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 210);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 36;
            label4.Text = "Medico:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 257);
            label5.Name = "label5";
            label5.Size = new Size(77, 19);
            label5.TabIndex = 40;
            label5.Text = "Convênio:";
            // 
            // ckParticular
            // 
            ckParticular.AutoSize = true;
            ckParticular.Checked = true;
            ckParticular.CheckState = CheckState.Checked;
            ckParticular.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckParticular.Location = new Point(107, 257);
            ckParticular.Name = "ckParticular";
            ckParticular.Size = new Size(85, 23);
            ckParticular.TabIndex = 41;
            ckParticular.Text = "Particular";
            ckParticular.UseVisualStyleBackColor = true;
            ckParticular.CheckedChanged += ckParticular_CheckedChanged;
            // 
            // ckPlanoDeSaude
            // 
            ckPlanoDeSaude.AutoSize = true;
            ckPlanoDeSaude.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckPlanoDeSaude.Location = new Point(198, 257);
            ckPlanoDeSaude.Name = "ckPlanoDeSaude";
            ckPlanoDeSaude.Size = new Size(123, 23);
            ckPlanoDeSaude.TabIndex = 42;
            ckPlanoDeSaude.Text = "Plano de Saúde";
            ckPlanoDeSaude.UseVisualStyleBackColor = true;
            ckPlanoDeSaude.CheckedChanged += ckPlanoDeSaude_CheckedChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(467, 351);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 26);
            btnSalvar.TabIndex = 43;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // frmAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 519);
            Controls.Add(btnSalvar);
            Controls.Add(ckPlanoDeSaude);
            Controls.Add(ckParticular);
            Controls.Add(label5);
            Controls.Add(btnBuscaMedico);
            Controls.Add(txtMedico);
            Controls.Add(label4);
            Controls.Add(btnBuscaPaciente);
            Controls.Add(txtPaciente);
            Controls.Add(label3);
            Controls.Add(btnLimpar);
            Controls.Add(btnCancelar);
            Controls.Add(cbmHorario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAgendamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private ComboBox cbmHorario;
        private Button btnLimpar;
        private Button btnCancelar;
        private TextBox txtPaciente;
        private Label label3;
        private Button btnBuscaPaciente;
        private Button btnBuscaMedico;
        private TextBox txtMedico;
        private Label label4;
        private Label label5;
        private CheckBox ckParticular;
        private CheckBox ckPlanoDeSaude;
        private Button btnSalvar;
    }
}