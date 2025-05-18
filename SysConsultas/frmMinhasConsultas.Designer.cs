namespace SysConsultas
{
    partial class frmMinhasConsultas
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
            label1 = new Label();
            dataInicio = new DateTimePicker();
            label2 = new Label();
            dataFim = new DateTimePicker();
            btnPesquisar = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tblMinhasConsultas = new DataGridView();
            btnGerarPDF = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblMinhasConsultas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 30);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 9;
            label1.Text = "Data Inicio:";
            // 
            // dataInicio
            // 
            dataInicio.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataInicio.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataInicio.Format = DateTimePickerFormat.Short;
            dataInicio.Location = new Point(159, 26);
            dataInicio.Name = "dataInicio";
            dataInicio.Size = new Size(190, 26);
            dataInicio.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(378, 28);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 11;
            label2.Text = "Data Fim:";
            // 
            // dataFim
            // 
            dataFim.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataFim.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataFim.Format = DateTimePickerFormat.Short;
            dataFim.Location = new Point(460, 24);
            dataFim.Name = "dataFim";
            dataFim.Size = new Size(188, 26);
            dataFim.TabIndex = 10;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPesquisar.Location = new Point(689, 23);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(117, 26);
            btnPesquisar.TabIndex = 32;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 58);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1141, 592);
            tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tblMinhasConsultas);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1133, 564);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listagem";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tblMinhasConsultas
            // 
            tblMinhasConsultas.BackgroundColor = SystemColors.Control;
            tblMinhasConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMinhasConsultas.Location = new Point(15, 3);
            tblMinhasConsultas.Name = "tblMinhasConsultas";
            tblMinhasConsultas.RowTemplate.Height = 25;
            tblMinhasConsultas.Size = new Size(1112, 546);
            tblMinhasConsultas.TabIndex = 0;
            tblMinhasConsultas.CellMouseClick += tblMinhasConsultas_CellMouseClick;
            // 
            // btnGerarPDF
            // 
            btnGerarPDF.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGerarPDF.Location = new Point(812, 23);
            btnGerarPDF.Name = "btnGerarPDF";
            btnGerarPDF.Size = new Size(117, 26);
            btnGerarPDF.TabIndex = 34;
            btnGerarPDF.Text = "Gerar PDF";
            btnGerarPDF.UseVisualStyleBackColor = true;
            btnGerarPDF.Click += btnGerarPDF_Click;
            // 
            // frmMinhasConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 662);
            Controls.Add(btnGerarPDF);
            Controls.Add(tabControl1);
            Controls.Add(btnPesquisar);
            Controls.Add(label2);
            Controls.Add(dataFim);
            Controls.Add(label1);
            Controls.Add(dataInicio);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMinhasConsultas";
            Text = "Minhas Consultas";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tblMinhasConsultas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dataInicio;
        private Label label2;
        private DateTimePicker dataFim;
        private Button btnPesquisar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView tblMinhasConsultas;
        private Button btnGerarPDF;
    }
}