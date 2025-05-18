namespace SysConsultas
{
    partial class frmListarAgendamento
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tblMedicos = new DataGridView();
            label2 = new Label();
            dataFim = new DateTimePicker();
            label1 = new Label();
            dataInicio = new DateTimePicker();
            btnPesquisar = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblMedicos).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 48);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1117, 490);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tblMedicos);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1109, 462);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listagem";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tblMedicos
            // 
            tblMedicos.BackgroundColor = SystemColors.Control;
            tblMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMedicos.Location = new Point(15, 3);
            tblMedicos.Name = "tblMedicos";
            tblMedicos.RowTemplate.Height = 25;
            tblMedicos.Size = new Size(1088, 449);
            tblMedicos.TabIndex = 0;
            tblMedicos.CellMouseClick += tblMedicos_CellMouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(418, 20);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 15;
            label2.Text = "Data Fim:";
            // 
            // dataFim
            // 
            dataFim.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataFim.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataFim.Format = DateTimePickerFormat.Short;
            dataFim.Location = new Point(500, 16);
            dataFim.Name = "dataFim";
            dataFim.Size = new Size(188, 26);
            dataFim.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(128, 20);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 13;
            label1.Text = "Data Inicio:";
            // 
            // dataInicio
            // 
            dataInicio.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataInicio.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataInicio.Format = DateTimePickerFormat.Short;
            dataInicio.Location = new Point(222, 16);
            dataInicio.Name = "dataInicio";
            dataInicio.Size = new Size(190, 26);
            dataInicio.TabIndex = 12;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPesquisar.Location = new Point(705, 16);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(117, 26);
            btnPesquisar.TabIndex = 33;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // frmListarAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 550);
            Controls.Add(btnPesquisar);
            Controls.Add(label2);
            Controls.Add(dataFim);
            Controls.Add(label1);
            Controls.Add(dataInicio);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListarAgendamento";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Listagem de agendamentos";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tblMedicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView tblMedicos;
        private Label label2;
        private DateTimePicker dataFim;
        private Label label1;
        private DateTimePicker dataInicio;
        private Button btnPesquisar;
    }
}