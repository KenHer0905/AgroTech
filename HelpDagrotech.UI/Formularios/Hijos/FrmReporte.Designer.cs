namespace HelpDagrotech.UI.Formularios.Hijos
{
    partial class FrmReporte
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
            panelbuscador = new Panel();
            txtxbuscar = new TextBox();
            txtbuscador = new TextBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            dgvListado = new DataGridView();
            Panelpaginas = new TableLayoutPanel();
            buttondespues = new FontAwesome.Sharp.IconButton();
            buttosiguiente = new FontAwesome.Sharp.IconButton();
            buttosegundo = new FontAwesome.Sharp.IconButton();
            lblpaginas = new Label();
            buttonprimero = new FontAwesome.Sharp.IconButton();
            lbltotalpaginas = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            label11 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel = new Panel();
            panelbuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            Panelpaginas.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panelbuscador
            // 
            panelbuscador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelbuscador.BackColor = Color.White;
            panelbuscador.BorderStyle = BorderStyle.FixedSingle;
            panelbuscador.Controls.Add(txtxbuscar);
            panelbuscador.Controls.Add(txtbuscador);
            panelbuscador.Controls.Add(iconPictureBox2);
            panelbuscador.Location = new Point(18, 83);
            panelbuscador.Name = "panelbuscador";
            panelbuscador.Size = new Size(559, 40);
            panelbuscador.TabIndex = 5;
            // 
            // txtxbuscar
            // 
            txtxbuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtxbuscar.ForeColor = Color.Gray;
            txtxbuscar.Location = new Point(49, 3);
            txtxbuscar.Name = "txtxbuscar";
            txtxbuscar.PlaceholderText = "Busca Registro";
            txtxbuscar.Size = new Size(489, 27);
            txtxbuscar.TabIndex = 2;
            txtxbuscar.TextAlign = HorizontalAlignment.Right;
            txtxbuscar.TextChanged += txtxbuscar_TextChanged;
            // 
            // txtbuscador
            // 
            txtbuscador.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbuscador.ForeColor = Color.Gray;
            txtbuscador.Location = new Point(46, -29);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.PlaceholderText = "Busca Registro";
            txtbuscador.Size = new Size(248, 27);
            txtbuscador.TabIndex = 1;
            txtbuscador.TextAlign = HorizontalAlignment.Right;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 36;
            iconPictureBox2.Location = new Point(3, 0);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(40, 36);
            iconPictureBox2.TabIndex = 0;
            iconPictureBox2.TabStop = false;
            // 
            // dgvListado
            // 
            dgvListado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListado.BackgroundColor = Color.Honeydew;
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(3, 377);
            dgvListado.Name = "dgvListado";
            dgvListado.RowHeadersWidth = 51;
            dgvListado.Size = new Size(1251, 280);
            dgvListado.TabIndex = 7;
            // 
            // Panelpaginas
            // 
            Panelpaginas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panelpaginas.BackColor = Color.Honeydew;
            Panelpaginas.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            Panelpaginas.ColumnCount = 6;
            Panelpaginas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 67F));
            Panelpaginas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            Panelpaginas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 166F));
            Panelpaginas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 164F));
            Panelpaginas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 82F));
            Panelpaginas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            Panelpaginas.Controls.Add(buttondespues, 3, 0);
            Panelpaginas.Controls.Add(buttosiguiente, 1, 0);
            Panelpaginas.Controls.Add(buttosegundo, 0, 0);
            Panelpaginas.Controls.Add(lblpaginas, 2, 0);
            Panelpaginas.Controls.Add(buttonprimero, 4, 0);
            Panelpaginas.Controls.Add(lbltotalpaginas, 5, 0);
            Panelpaginas.Location = new Point(29, 1234);
            Panelpaginas.Name = "Panelpaginas";
            Panelpaginas.RowCount = 1;
            Panelpaginas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Panelpaginas.Size = new Size(2122, 47);
            Panelpaginas.TabIndex = 9;
            // 
            // buttondespues
            // 
            buttondespues.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttondespues.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            buttondespues.IconColor = Color.Black;
            buttondespues.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttondespues.Location = new Point(1604, 4);
            buttondespues.Name = "buttondespues";
            buttondespues.Size = new Size(158, 39);
            buttondespues.TabIndex = 12;
            buttondespues.UseVisualStyleBackColor = true;
            // 
            // buttosiguiente
            // 
            buttosiguiente.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttosiguiente.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            buttosiguiente.IconColor = Color.Black;
            buttosiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttosiguiente.Location = new Point(1936, 4);
            buttosiguiente.Name = "buttosiguiente";
            buttosiguiente.Size = new Size(114, 39);
            buttosiguiente.TabIndex = 11;
            buttosiguiente.UseVisualStyleBackColor = true;
            // 
            // buttosegundo
            // 
            buttosegundo.IconChar = FontAwesome.Sharp.IconChar.FastForward;
            buttosegundo.IconColor = Color.Black;
            buttosegundo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttosegundo.Location = new Point(2057, 4);
            buttosegundo.Name = "buttosegundo";
            buttosegundo.Size = new Size(61, 39);
            buttosegundo.TabIndex = 10;
            buttosegundo.UseVisualStyleBackColor = true;
            // 
            // lblpaginas
            // 
            lblpaginas.AutoSize = true;
            lblpaginas.ForeColor = Color.FromArgb(0, 64, 0);
            lblpaginas.Location = new Point(1825, 1);
            lblpaginas.Name = "lblpaginas";
            lblpaginas.Size = new Size(104, 20);
            lblpaginas.TabIndex = 7;
            lblpaginas.Text = "Paginas 0 de 0";
            lblpaginas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonprimero
            // 
            buttonprimero.IconChar = FontAwesome.Sharp.IconChar.FastBackward;
            buttonprimero.IconColor = Color.Black;
            buttonprimero.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonprimero.Location = new Point(1521, 4);
            buttonprimero.Name = "buttonprimero";
            buttonprimero.Size = new Size(76, 39);
            buttonprimero.TabIndex = 9;
            buttonprimero.UseVisualStyleBackColor = true;
            // 
            // lbltotalpaginas
            // 
            lbltotalpaginas.AutoSize = true;
            lbltotalpaginas.ForeColor = Color.FromArgb(0, 64, 0);
            lbltotalpaginas.Location = new Point(1380, 1);
            lbltotalpaginas.Name = "lbltotalpaginas";
            lbltotalpaginas.Size = new Size(134, 20);
            lbltotalpaginas.TabIndex = 8;
            lbltotalpaginas.Text = "Total de paginas: 0";
            lbltotalpaginas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.Honeydew;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 166F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 164F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.Controls.Add(iconButton1, 3, 0);
            tableLayoutPanel1.Controls.Add(iconButton2, 1, 0);
            tableLayoutPanel1.Controls.Add(iconButton3, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(iconButton4, 4, 0);
            tableLayoutPanel1.Controls.Add(label4, 5, 0);
            tableLayoutPanel1.Location = new Point(0, 659);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1257, 47);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(739, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(158, 39);
            iconButton1.TabIndex = 12;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(1071, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(114, 39);
            iconButton2.TabIndex = 11;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.FastForward;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(1192, 4);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(61, 39);
            iconButton3.TabIndex = 10;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(0, 64, 0);
            label3.Location = new Point(960, 1);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 7;
            label3.Text = "Paginas 0 de 0";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconButton4
            // 
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.FastBackward;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.Location = new Point(656, 4);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(76, 39);
            iconButton4.TabIndex = 9;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(0, 64, 0);
            label4.Location = new Point(515, 1);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 8;
            label4.Text = "Total de paginas: 0";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1257, 77);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 64, 0);
            label1.Font = new Font("Algerian", 13.8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 21);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 0;
            label1.Text = "REPORTE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Honeydew;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(iconPictureBox1);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(3, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(397, 231);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(280, 147);
            label5.Name = "label5";
            label5.Size = new Size(40, 31);
            label5.TabIndex = 2;
            label5.Text = "10";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(41, 152);
            label2.Name = "label2";
            label2.Size = new Size(233, 50);
            label2.TabIndex = 1;
            label2.Text = ":REPORTES TOTALES\r\n\r\n";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Honeydew;
            iconPictureBox1.ForeColor = Color.Black;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            iconPictureBox1.IconColor = Color.Black;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 144;
            iconPictureBox1.ImageLocation = "";
            iconPictureBox1.Location = new Point(63, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(234, 144);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Honeydew;
            panel3.Controls.Add(iconButton5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(numericUpDown2);
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(419, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(834, 242);
            panel3.TabIndex = 13;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.Olive;
            iconButton5.ForeColor = Color.White;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton5.IconColor = Color.White;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.ImageAlign = ContentAlignment.MiddleRight;
            iconButton5.Location = new Point(555, 175);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(145, 64);
            iconButton5.TabIndex = 11;
            iconButton5.Text = "IMPRIMIR";
            iconButton5.TextAlign = ContentAlignment.MiddleLeft;
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 64, 0);
            panel4.Controls.Add(label11);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(834, 70);
            panel4.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Algerian", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(18, 11);
            label11.Name = "label11";
            label11.Size = new Size(233, 50);
            label11.TabIndex = 3;
            label11.Text = ":REPORTES TOTALES\r\n\r\n";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(406, 121);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(119, 27);
            numericUpDown2.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(226, 197);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(147, 27);
            numericUpDown1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(226, 121);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 37);
            textBox2.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(18, 197);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(179, 28);
            comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(18, 130);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 28);
            comboBox1.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label10.Location = new Point(235, 174);
            label10.Name = "label10";
            label10.Size = new Size(79, 19);
            label10.TabIndex = 4;
            label10.Text = "Sub Tota";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label9.Location = new Point(432, 98);
            label9.Name = "label9";
            label9.Size = new Size(59, 19);
            label9.TabIndex = 3;
            label9.Text = "Precio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label8.Location = new Point(226, 98);
            label8.Name = "label8";
            label8.Size = new Size(146, 19);
            label8.TabIndex = 2;
            label8.Text = "Cantidad Vendida";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label7.Location = new Point(18, 174);
            label7.Name = "label7";
            label7.Size = new Size(77, 19);
            label7.TabIndex = 1;
            label7.Text = "Cosecha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label6.Location = new Point(18, 98);
            label6.Name = "label6";
            label6.Size = new Size(117, 19);
            label6.TabIndex = 0;
            label6.Text = "Control Venta";
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.BackColor = Color.FromArgb(224, 224, 224);
            panel.Controls.Add(panel3);
            panel.Controls.Add(panel2);
            panel.Controls.Add(panel1);
            panel.Controls.Add(tableLayoutPanel1);
            panel.Controls.Add(Panelpaginas);
            panel.Controls.Add(dgvListado);
            panel.Controls.Add(panelbuscador);
            panel.Location = new Point(-6, 1);
            panel.Name = "panel";
            panel.RightToLeft = RightToLeft.Yes;
            panel.Size = new Size(1257, 727);
            panel.TabIndex = 1;
            // 
            // FrmReporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 732);
            Controls.Add(panel);
            Name = "FrmReporte";
            Text = "FrmReporte";
            Shown += FrmReporte_Shown;
            Paint += FrmReporte_Paint;
            panelbuscador.ResumeLayout(false);
            panelbuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            Panelpaginas.ResumeLayout(false);
            Panelpaginas.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelbuscador;
        public TextBox txtxbuscar;
        public TextBox txtbuscador;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private DataGridView dgvListado;
        private TableLayoutPanel Panelpaginas;
        private FontAwesome.Sharp.IconButton buttondespues;
        private FontAwesome.Sharp.IconButton buttosiguiente;
        private FontAwesome.Sharp.IconButton buttosegundo;
        public Label lblpaginas;
        private FontAwesome.Sharp.IconButton buttonprimero;
        public Label lbltotalpaginas;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        public Label label3;
        private FontAwesome.Sharp.IconButton iconButton4;
        public Label label4;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label5;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Panel panel4;
        private Label label11;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        public Panel panel;
    }
}