namespace HelpDagrotech.UI.Formularios.Hijos
{
    partial class FrmSalidaMat
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
            panelsalidamat = new Panel();
            panel9 = new Panel();
            txtbuscarSalidaMat = new TextBox();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            panel6 = new Panel();
            dvgsalidamaterial = new DataGridView();
            panel7 = new Panel();
            panel8 = new Panel();
            label12 = new Label();
            panel4 = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            bttguardarsalida = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            comboBox1 = new ComboBox();
            panel5 = new Panel();
            label11 = new Label();
            panel1 = new Panel();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtFechaSalida = new DateTimePicker();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            CboxTiposalida = new ComboBox();
            Cboxterrenosalida = new ComboBox();
            Cboxempleadosalida = new ComboBox();
            panel3 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panelsalidamat.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgsalidamaterial).BeginInit();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelsalidamat
            // 
            panelsalidamat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelsalidamat.BackColor = Color.FromArgb(224, 224, 224);
            panelsalidamat.Controls.Add(panel9);
            panelsalidamat.Controls.Add(panel6);
            panelsalidamat.Controls.Add(panel4);
            panelsalidamat.Controls.Add(panel1);
            panelsalidamat.Controls.Add(panel2);
            panelsalidamat.Location = new Point(0, 0);
            panelsalidamat.Name = "panelsalidamat";
            panelsalidamat.Size = new Size(1185, 578);
            panelsalidamat.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel9.BackColor = Color.FromArgb(192, 255, 192);
            panel9.Controls.Add(txtbuscarSalidaMat);
            panel9.Controls.Add(iconPictureBox7);
            panel9.Location = new Point(53, 435);
            panel9.Name = "panel9";
            panel9.Size = new Size(435, 40);
            panel9.TabIndex = 9;
            // 
            // txtbuscarSalidaMat
            // 
            txtbuscarSalidaMat.BackColor = Color.FromArgb(192, 255, 192);
            txtbuscarSalidaMat.Location = new Point(49, 8);
            txtbuscarSalidaMat.Name = "txtbuscarSalidaMat";
            txtbuscarSalidaMat.PlaceholderText = "Buscar Salida de material";
            txtbuscarSalidaMat.Size = new Size(369, 27);
            txtbuscarSalidaMat.TabIndex = 1;
            // 
            // iconPictureBox7
            // 
            iconPictureBox7.BackColor = Color.FromArgb(192, 255, 192);
            iconPictureBox7.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox7.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox7.IconSize = 43;
            iconPictureBox7.Location = new Point(0, 0);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(43, 48);
            iconPictureBox7.TabIndex = 0;
            iconPictureBox7.TabStop = false;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel6.Controls.Add(dvgsalidamaterial);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(3, 476);
            panel6.Name = "panel6";
            panel6.Size = new Size(1455, 102);
            panel6.TabIndex = 20;
            panel6.Paint += panel6_Paint;
            // 
            // dvgsalidamaterial
            // 
            dvgsalidamaterial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dvgsalidamaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgsalidamaterial.Location = new Point(0, 64);
            dvgsalidamaterial.Name = "dvgsalidamaterial";
            dvgsalidamaterial.RowHeadersWidth = 51;
            dvgsalidamaterial.Size = new Size(1452, 56);
            dvgsalidamaterial.TabIndex = 1;
            dvgsalidamaterial.CellContentClick += dvgsalidamaterial_CellContentClick;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.Olive;
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(label12);
            panel7.Location = new Point(0, 15);
            panel7.Name = "panel7";
            panel7.Size = new Size(1455, 50);
            panel7.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Location = new Point(1115, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(228, 226);
            panel8.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Algerian", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(612, 12);
            label12.Name = "label12";
            label12.Size = new Size(230, 25);
            label12.TabIndex = 2;
            label12.Text = "SALIDA MOVIMIENTO";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Honeydew;
            panel4.Controls.Add(iconButton3);
            panel4.Controls.Add(flowLayoutPanel1);
            panel4.Controls.Add(numericUpDown2);
            panel4.Controls.Add(numericUpDown1);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(3, 261);
            panel4.Name = "panel4";
            panel4.Size = new Size(1182, 147);
            panel4.TabIndex = 19;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.Red;
            iconButton3.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(1156, 90);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(150, 54);
            iconButton3.TabIndex = 2;
            iconButton3.Text = "CERRAR \r\nVENTANA";
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(bttguardarsalida);
            flowLayoutPanel1.Controls.Add(iconButton2);
            flowLayoutPanel1.Location = new Point(849, 87);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(464, 57);
            flowLayoutPanel1.TabIndex = 21;
            // 
            // bttguardarsalida
            // 
            bttguardarsalida.BackColor = Color.FromArgb(0, 64, 0);
            bttguardarsalida.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttguardarsalida.ForeColor = Color.White;
            bttguardarsalida.IconChar = FontAwesome.Sharp.IconChar.Save;
            bttguardarsalida.IconColor = Color.White;
            bttguardarsalida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bttguardarsalida.ImageAlign = ContentAlignment.MiddleLeft;
            bttguardarsalida.Location = new Point(3, 3);
            bttguardarsalida.Name = "bttguardarsalida";
            bttguardarsalida.Size = new Size(142, 54);
            bttguardarsalida.TabIndex = 0;
            bttguardarsalida.Text = "GUARDAR";
            bttguardarsalida.TextAlign = ContentAlignment.MiddleRight;
            bttguardarsalida.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(0, 192, 0);
            iconButton2.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(151, 3);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(150, 54);
            iconButton2.TabIndex = 1;
            iconButton2.Text = "NUEVO MOVIMIENTO";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(367, 100);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 20;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(609, 102);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 64, 0);
            label6.Location = new Point(592, 76);
            label6.Name = "label6";
            label6.Size = new Size(57, 23);
            label6.TabIndex = 9;
            label6.Text = "Precio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(0, 64, 0);
            label9.Location = new Point(350, 76);
            label9.Name = "label9";
            label9.Size = new Size(79, 23);
            label9.TabIndex = 5;
            label9.Text = "Cantidad";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(0, 64, 0);
            label10.Location = new Point(50, 76);
            label10.Name = "label10";
            label10.Size = new Size(73, 23);
            label10.TabIndex = 4;
            label10.Text = "Material";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(50, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 28);
            comboBox1.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Green;
            panel5.Controls.Add(label11);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1182, 53);
            panel5.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Algerian", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(579, 9);
            label11.Name = "label11";
            label11.Size = new Size(230, 25);
            label11.TabIndex = 1;
            label11.Text = "SALIDA MOVIMIENTO";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(iconPictureBox3);
            panel1.Controls.Add(iconPictureBox2);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(txtFechaSalida);
            panel1.Controls.Add(iconPictureBox6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(CboxTiposalida);
            panel1.Controls.Add(Cboxterrenosalida);
            panel1.Controls.Add(Cboxempleadosalida);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(3, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 187);
            panel1.TabIndex = 1;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.Honeydew;
            iconPictureBox3.ForeColor = Color.Green;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            iconPictureBox3.IconColor = Color.Green;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 27;
            iconPictureBox3.Location = new Point(642, 104);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(40, 27);
            iconPictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox3.TabIndex = 18;
            iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Honeydew;
            iconPictureBox2.ForeColor = Color.Green;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.MapLocationDot;
            iconPictureBox2.IconColor = Color.Green;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 28;
            iconPictureBox2.Location = new Point(320, 104);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(40, 28);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox2.TabIndex = 17;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Honeydew;
            iconPictureBox1.ForeColor = Color.Green;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            iconPictureBox1.IconColor = Color.Green;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 28;
            iconPictureBox1.Location = new Point(18, 104);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 28);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox1.TabIndex = 16;
            iconPictureBox1.TabStop = false;
            // 
            // txtFechaSalida
            // 
            txtFechaSalida.Location = new Point(997, 105);
            txtFechaSalida.Margin = new Padding(3, 4, 3, 4);
            txtFechaSalida.Name = "txtFechaSalida";
            txtFechaSalida.Size = new Size(246, 27);
            txtFechaSalida.TabIndex = 15;
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.Honeydew;
            iconPictureBox6.ForeColor = Color.Green;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            iconPictureBox6.IconColor = Color.Green;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 27;
            iconPictureBox6.Location = new Point(951, 105);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(40, 27);
            iconPictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox6.TabIndex = 12;
            iconPictureBox6.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 64, 0);
            label7.Location = new Point(981, 81);
            label7.Name = "label7";
            label7.Size = new Size(60, 23);
            label7.TabIndex = 9;
            label7.Text = "Fecha ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 64, 0);
            label5.Location = new Point(688, 81);
            label5.Name = "label5";
            label5.Size = new Size(165, 23);
            label5.TabIndex = 6;
            label5.Text = "Tipo de Movimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 64, 0);
            label4.Location = new Point(366, 81);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 5;
            label4.Text = "Terreno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 64, 0);
            label3.Location = new Point(64, 81);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 4;
            label3.Text = "Empleado";
            // 
            // CboxTiposalida
            // 
            CboxTiposalida.FormattingEnabled = true;
            CboxTiposalida.Location = new Point(688, 104);
            CboxTiposalida.Name = "CboxTiposalida";
            CboxTiposalida.Size = new Size(221, 28);
            CboxTiposalida.TabIndex = 3;
            // 
            // Cboxterrenosalida
            // 
            Cboxterrenosalida.FormattingEnabled = true;
            Cboxterrenosalida.Location = new Point(366, 104);
            Cboxterrenosalida.Name = "Cboxterrenosalida";
            Cboxterrenosalida.Size = new Size(220, 28);
            Cboxterrenosalida.TabIndex = 2;
            // 
            // Cboxempleadosalida
            // 
            Cboxempleadosalida.FormattingEnabled = true;
            Cboxempleadosalida.Location = new Point(64, 104);
            Cboxempleadosalida.Name = "Cboxempleadosalida";
            Cboxempleadosalida.Size = new Size(210, 28);
            Cboxempleadosalida.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Green;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1182, 66);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(576, 11);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 1;
            label2.Text = " MOVIMIENTO";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 0);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1185, 62);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 26);
            label1.Name = "label1";
            label1.Size = new Size(525, 25);
            label1.TabIndex = 0;
            label1.Text = "GESTION DE MOVIMIENTO Y SALIDA MOVIMIENTO ";
            // 
            // FrmSalidaMat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 578);
            Controls.Add(panelsalidamat);
            Name = "FrmSalidaMat";
            Text = "FrmSalidaMat";
            Paint += FrmSalidaMat_Paint;
            panelsalidamat.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgsalidamaterial).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelsalidamat;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox CboxTiposalida;
        private ComboBox Cboxterrenosalida;
        private ComboBox Cboxempleadosalida;
        private Panel panel4;
        private Label label6;
        private Label label9;
        private Label label10;
        private ComboBox comboBox1;
        private Panel panel5;
        private Label label11;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private DateTimePicker txtFechaSalida;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private Label label7;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Panel panel6;
        private DataGridView dvgsalidamaterial;
        private Panel panel7;
        private Label label12;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton bttguardarsalida;
        private Panel panel8;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel9;
        private TextBox txtbuscarSalidaMat;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
    }
}