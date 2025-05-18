namespace SysConsultas
{
    partial class frmListarMedico
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
            components = new System.ComponentModel.Container();
            tblMedicos = new DataGridView();
            bindingSource1 = new BindingSource(components);
            tabPage1 = new TabPage();
            tabControl1 = new TabControl();
            ((System.ComponentModel.ISupportInitialize)tblMedicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tblMedicos
            // 
            tblMedicos.BackgroundColor = SystemColors.Control;
            tblMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMedicos.Location = new Point(15, 3);
            tblMedicos.Name = "tblMedicos";
            tblMedicos.RowTemplate.Height = 25;
            tblMedicos.Size = new Size(1010, 405);
            tblMedicos.TabIndex = 0;
            tblMedicos.CellMouseClick += tblMedicos_CellMouseClick;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tblMedicos);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1071, 433);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listagem";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 7);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1079, 461);
            tabControl1.TabIndex = 1;
            // 
            // frmListarMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 574);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListarMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listagem de medicos cadastrados";
            ((System.ComponentModel.ISupportInitialize)tblMedicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tblMedicos;
        private BindingSource bindingSource1;
        private TabPage tabPage1;
        private TabControl tabControl1;
    }
}