namespace HelpDagrotech.UI.Formularios.Hijos
{
    partial class FrmDecodificacion
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
            panel1 = new Panel();
            panel9 = new Panel();
            txtbuscarSalidaMat = new TextBox();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            bttguardarDeco = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            dvgdeco = new DataGridView();
            panel3 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            label7 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txxtetapa = new TextBox();
            CantAreanum = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Cboxcultivo = new ComboBox();
            Cboxmaterial = new ComboBox();
            panel4 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgdeco).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CantAreanum).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(dvgdeco);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1188, 434);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(192, 255, 192);
            panel9.Controls.Add(txtbuscarSalidaMat);
            panel9.Controls.Add(iconPictureBox7);
            panel9.Location = new Point(33, 308);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(381, 30);
            panel9.TabIndex = 10;
            // 
            // txtbuscarSalidaMat
            // 
            txtbuscarSalidaMat.BackColor = Color.FromArgb(192, 255, 192);
            txtbuscarSalidaMat.Location = new Point(43, 6);
            txtbuscarSalidaMat.Margin = new Padding(3, 2, 3, 2);
            txtbuscarSalidaMat.Name = "txtbuscarSalidaMat";
            txtbuscarSalidaMat.PlaceholderText = "Buscar Salida de material";
            txtbuscarSalidaMat.Size = new Size(323, 23);
            txtbuscarSalidaMat.TabIndex = 1;
            txtbuscarSalidaMat.TextChanged += txtbuscarSalidaMat_TextChanged;
            // 
            // iconPictureBox7
            // 
            iconPictureBox7.BackColor = Color.FromArgb(192, 255, 192);
            iconPictureBox7.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox7.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox7.IconSize = 36;
            iconPictureBox7.Location = new Point(0, 0);
            iconPictureBox7.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(38, 36);
            iconPictureBox7.TabIndex = 0;
            iconPictureBox7.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(bttguardarDeco);
            flowLayoutPanel1.Controls.Add(iconButton3);
            flowLayoutPanel1.Controls.Add(iconButton4);
            flowLayoutPanel1.ForeColor = Color.White;
            flowLayoutPanel1.Location = new Point(621, 295);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(334, 50);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // bttguardarDeco
            // 
            bttguardarDeco.BackColor = Color.FromArgb(192, 192, 0);
            bttguardarDeco.IconChar = FontAwesome.Sharp.IconChar.Save;
            bttguardarDeco.IconColor = Color.White;
            bttguardarDeco.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bttguardarDeco.ImageAlign = ContentAlignment.MiddleLeft;
            bttguardarDeco.Location = new Point(3, 2);
            bttguardarDeco.Margin = new Padding(3, 2, 3, 2);
            bttguardarDeco.Name = "bttguardarDeco";
            bttguardarDeco.Size = new Size(109, 48);
            bttguardarDeco.TabIndex = 0;
            bttguardarDeco.Text = "GUARDAR";
            bttguardarDeco.TextAlign = ContentAlignment.MiddleRight;
            bttguardarDeco.UseVisualStyleBackColor = false;
            bttguardarDeco.Click += bttguardarDeco_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.Green;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(118, 2);
            iconButton3.Margin = new Padding(3, 2, 3, 2);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(100, 48);
            iconButton3.TabIndex = 1;
            iconButton3.Text = "EDITAR";
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.Red;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(224, 2);
            iconButton4.Margin = new Padding(3, 2, 3, 2);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(100, 48);
            iconButton4.TabIndex = 2;
            iconButton4.Text = "BORRAR";
            iconButton4.TextAlign = ContentAlignment.MiddleRight;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // dvgdeco
            // 
            dvgdeco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dvgdeco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgdeco.Location = new Point(10, 370);
            dvgdeco.Margin = new Padding(3, 2, 3, 2);
            dvgdeco.Name = "dvgdeco";
            dvgdeco.RowHeadersWidth = 51;
            dvgdeco.Size = new Size(1167, 260);
            dvgdeco.TabIndex = 2;
            dvgdeco.CellContentClick += dvgdeco_CellContentClick;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Honeydew;
            panel3.Controls.Add(iconButton2);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(txxtetapa);
            panel3.Controls.Add(CantAreanum);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(Cboxcultivo);
            panel3.Controls.Add(Cboxmaterial);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(10, 51);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1167, 232);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // iconButton2
            // 
            iconButton2.ForeColor = Color.Olive;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ShareSquare;
            iconButton2.IconColor = Color.Olive;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 100;
            iconButton2.ImageAlign = ContentAlignment.TopCenter;
            iconButton2.Location = new Point(1030, 137);
            iconButton2.Margin = new Padding(3, 2, 3, 2);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(121, 93);
            iconButton2.TabIndex = 15;
            iconButton2.Text = "Reporte de Decodificacion";
            iconButton2.TextAlign = ContentAlignment.BottomCenter;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(label7);
            panel5.Controls.Add(iconButton1);
            panel5.Location = new Point(23, 64);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(257, 148);
            panel5.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 64, 0);
            label7.Location = new Point(56, 8);
            label7.Name = "label7";
            label7.Size = new Size(124, 19);
            label7.TabIndex = 15;
            label7.Text = "RECETAS ACTIVAS";
            // 
            // iconButton1
            // 
            iconButton1.ForeColor = Color.FromArgb(0, 64, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Seedling;
            iconButton1.IconColor = Color.FromArgb(0, 64, 0);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 150;
            iconButton1.Location = new Point(38, 28);
            iconButton1.Margin = new Padding(3, 2, 3, 2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(171, 112);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "0%";
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // txxtetapa
            // 
            txxtetapa.Location = new Point(710, 178);
            txxtetapa.Margin = new Padding(3, 2, 3, 2);
            txxtetapa.Multiline = true;
            txxtetapa.Name = "txxtetapa";
            txxtetapa.Size = new Size(292, 26);
            txxtetapa.TabIndex = 13;
            // 
            // CantAreanum
            // 
            CantAreanum.Location = new Point(319, 173);
            CantAreanum.Margin = new Padding(3, 2, 3, 2);
            CantAreanum.Name = "CantAreanum";
            CantAreanum.Size = new Size(287, 23);
            CantAreanum.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 64, 0);
            label6.Location = new Point(715, 156);
            label6.Name = "label6";
            label6.Size = new Size(113, 19);
            label6.TabIndex = 11;
            label6.Text = "Etapa Aplicación";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 64, 0);
            label5.Location = new Point(715, 86);
            label5.Name = "label5";
            label5.Size = new Size(109, 19);
            label5.TabIndex = 10;
            label5.Text = "Nombre Cultivo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 64, 0);
            label4.Location = new Point(319, 156);
            label4.Name = "label4";
            label4.Size = new Size(107, 19);
            label4.TabIndex = 9;
            label4.Text = "Cantgidad/Area";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 64, 0);
            label3.Location = new Point(319, 86);
            label3.Name = "label3";
            label3.Size = new Size(116, 19);
            label3.TabIndex = 8;
            label3.Text = "Nombre Material";
            // 
            // Cboxcultivo
            // 
            Cboxcultivo.FormattingEnabled = true;
            Cboxcultivo.Location = new Point(715, 103);
            Cboxcultivo.Margin = new Padding(3, 2, 3, 2);
            Cboxcultivo.Name = "Cboxcultivo";
            Cboxcultivo.Size = new Size(288, 23);
            Cboxcultivo.TabIndex = 6;
            // 
            // Cboxmaterial
            // 
            Cboxmaterial.FormattingEnabled = true;
            Cboxmaterial.Location = new Point(319, 103);
            Cboxmaterial.Margin = new Padding(3, 2, 3, 2);
            Cboxmaterial.Name = "Cboxmaterial";
            Cboxmaterial.Size = new Size(288, 23);
            Cboxmaterial.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Green;
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1167, 59);
            panel4.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Green;
            label2.Font = new Font("Algerian", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(348, 14);
            label2.Name = "label2";
            label2.Size = new Size(263, 21);
            label2.TabIndex = 2;
            label2.Text = "GESTION DE DECODIFICACION";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 0);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1188, 46);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 16);
            label1.Name = "label1";
            label1.Size = new Size(263, 21);
            label1.TabIndex = 1;
            label1.Text = "GESTION DE DECODIFICACION";
            // 
            // FrmDecodificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 434);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmDecodificacion";
            Text = "FrmDecodificacion";
            Load += FrmDecodificacion_Load;
            panel1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgdeco).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CantAreanum).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private ComboBox Cboxcultivo;
        private ComboBox Cboxmaterial;
        private Panel panel4;
        private Label label2;
        private Label label3;
        private TextBox txxtetapa;
        private NumericUpDown CantAreanum;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridView dvgdeco;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton bttguardarDeco;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Panel panel9;
        private TextBox txtbuscarSalidaMat;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}