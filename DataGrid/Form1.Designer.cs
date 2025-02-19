namespace DataGrid
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            btn = new Button();
            label1 = new Label();
            CURP = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.GrayText;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btn, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(CURP, 0, 1);
            tableLayoutPanel1.Location = new Point(2, 7);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 78.37838F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.6216221F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 419F));
            tableLayoutPanel1.Size = new Size(927, 457);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btn
            // 
            btn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn.Location = new Point(2, 217);
            btn.Margin = new Padding(2);
            btn.Name = "btn";
            btn.Size = new Size(923, 60);
            btn.TabIndex = 1;
            btn.Text = "Verificar";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 2;
            label1.Text = "Ingrese su CURP";
            // 
            // CURP
            // 
            CURP.Location = new Point(3, 32);
            CURP.Name = "CURP";
            CURP.Size = new Size(405, 27);
            CURP.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Archivo CSV|*.csv|Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(933, 466);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private OpenFileDialog openFileDialog1;
        private Button btn;
        private Label label1;
        private TextBox CURP;
    }
}
