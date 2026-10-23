namespace HelpDagrotech.UI.Formularios
{
    partial class FrmMaterial
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
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            dgvmaterial = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconcancelma = new FontAwesome.Sharp.IconButton();
            IconGuardarm = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            panel7 = new Panel();
            txtxprecio = new TextBox();
            label9 = new Label();
            comboBox2 = new ComboBox();
            label8 = new Label();
            inpixmas = new FontAwesome.Sharp.IconPictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            panel6 = new Panel();
            txtminimost = new TextBox();
            panel5 = new Panel();
            txtstock = new TextBox();
            panel4 = new Panel();
            txtdescrip = new TextBox();
            panel3 = new Panel();
            txtmaterial = new TextBox();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel8 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvmaterial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inpixmas).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(iconPictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 591);
            panel1.TabIndex = 0;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(0, 64, 0);
            iconPictureBox2.Cursor = Cursors.Hand;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 40;
            iconPictureBox2.Location = new Point(12, 12);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(40, 40);
            iconPictureBox2.TabIndex = 19;
            iconPictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Honeydew;
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(dgvmaterial);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(iconcancelma);
            panel2.Controls.Add(IconGuardarm);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(inpixmas);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(1013, 515);
            panel2.TabIndex = 1;
            // 
            // dgvmaterial
            // 
            dgvmaterial.AllowUserToDeleteRows = false;
            dgvmaterial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvmaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmaterial.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvmaterial.Location = new Point(20, 484);
            dgvmaterial.Name = "dgvmaterial";
            dgvmaterial.ReadOnly = true;
            dgvmaterial.RowHeadersWidth = 51;
            dgvmaterial.Size = new Size(880, 188);
            dgvmaterial.TabIndex = 19;
            // 
            // Column1
            // 
            Column1.HeaderText = "NombreMaterial";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Categoria";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Descripcion";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Stock";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Stock Minimo";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Precio";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Unidad medida";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Honeydew;
            iconPictureBox1.ForeColor = Color.FromArgb(0, 64, 0);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            iconPictureBox1.IconColor = Color.FromArgb(0, 64, 0);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(20, 8);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 18;
            iconPictureBox1.TabStop = false;
            // 
            // iconcancelma
            // 
            iconcancelma.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconcancelma.BackColor = Color.Silver;
            iconcancelma.IconChar = FontAwesome.Sharp.IconChar.None;
            iconcancelma.IconColor = Color.Black;
            iconcancelma.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconcancelma.Location = new Point(777, 395);
            iconcancelma.Name = "iconcancelma";
            iconcancelma.Size = new Size(118, 55);
            iconcancelma.TabIndex = 17;
            iconcancelma.Text = "Cancelar";
            iconcancelma.UseVisualStyleBackColor = false;
            // 
            // IconGuardarm
            // 
            IconGuardarm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IconGuardarm.BackColor = Color.MistyRose;
            IconGuardarm.IconChar = FontAwesome.Sharp.IconChar.Save;
            IconGuardarm.IconColor = Color.Black;
            IconGuardarm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconGuardarm.ImageAlign = ContentAlignment.MiddleLeft;
            IconGuardarm.Location = new Point(777, 312);
            IconGuardarm.Name = "IconGuardarm";
            IconGuardarm.Size = new Size(118, 55);
            IconGuardarm.TabIndex = 15;
            IconGuardarm.Text = "Guardar";
            IconGuardarm.TextAlign = ContentAlignment.MiddleRight;
            IconGuardarm.UseVisualStyleBackColor = false;
            IconGuardarm.Click += IconGuardarm_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(0, 64, 0);
            label10.Location = new Point(37, 378);
            label10.Name = "label10";
            label10.Size = new Size(57, 23);
            label10.TabIndex = 14;
            label10.Text = "Precio";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.Controls.Add(txtxprecio);
            panel7.Location = new Point(24, 404);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 55);
            panel7.TabIndex = 13;
            // 
            // txtxprecio
            // 
            txtxprecio.Location = new Point(12, 6);
            txtxprecio.Multiline = true;
            txtxprecio.Name = "txtxprecio";
            txtxprecio.Size = new Size(234, 49);
            txtxprecio.TabIndex = 2;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(0, 64, 0);
            label9.Location = new Point(416, 378);
            label9.Name = "label9";
            label9.Size = new Size(128, 23);
            label9.TabIndex = 12;
            label9.Text = "Unidad Medida";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Kg", "Lt" });
            comboBox2.Location = new Point(3, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(212, 28);
            comboBox2.TabIndex = 11;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.MistyRose;
            label8.ForeColor = Color.FromArgb(0, 64, 0);
            label8.Location = new Point(837, 218);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 10;
            label8.Text = "Subir Foto";
            // 
            // inpixmas
            // 
            inpixmas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            inpixmas.BackColor = Color.MistyRose;
            inpixmas.ForeColor = Color.FromArgb(0, 64, 0);
            inpixmas.IconChar = FontAwesome.Sharp.IconChar.Add;
            inpixmas.IconColor = Color.FromArgb(0, 64, 0);
            inpixmas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            inpixmas.IconSize = 172;
            inpixmas.Location = new Point(777, 56);
            inpixmas.Name = "inpixmas";
            inpixmas.Size = new Size(188, 172);
            inpixmas.SizeMode = PictureBoxSizeMode.CenterImage;
            inpixmas.TabIndex = 9;
            inpixmas.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 64, 0);
            label7.Location = new Point(416, 286);
            label7.Name = "label7";
            label7.Size = new Size(116, 23);
            label7.TabIndex = 5;
            label7.Text = "Stock Minimo";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 64, 0);
            label6.Location = new Point(36, 81);
            label6.Name = "label6";
            label6.Size = new Size(141, 23);
            label6.TabIndex = 8;
            label6.Text = "Nombre Material";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 64, 0);
            label5.Location = new Point(373, 85);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 7;
            label5.Text = "Categoria";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 64, 0);
            label4.Location = new Point(36, 181);
            label4.Name = "label4";
            label4.Size = new Size(98, 23);
            label4.TabIndex = 6;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 64, 0);
            label3.Location = new Point(37, 286);
            label3.Name = "label3";
            label3.Size = new Size(52, 23);
            label3.TabIndex = 5;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 64, 0);
            label2.Location = new Point(67, 15);
            label2.Name = "label2";
            label2.Size = new Size(146, 23);
            label2.TabIndex = 4;
            label2.Text = "Registrar Material";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Fertilizante", "Urea", "Pesticidas" });
            comboBox1.Location = new Point(373, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.Controls.Add(txtminimost);
            panel6.Location = new Point(416, 312);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 55);
            panel6.TabIndex = 1;
            // 
            // txtminimost
            // 
            txtminimost.Location = new Point(13, 3);
            txtminimost.Multiline = true;
            txtminimost.Name = "txtminimost";
            txtminimost.Size = new Size(234, 49);
            txtminimost.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(txtstock);
            panel5.Location = new Point(24, 312);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 55);
            panel5.TabIndex = 2;
            // 
            // txtstock
            // 
            txtstock.Location = new Point(12, 6);
            txtstock.Multiline = true;
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(234, 49);
            txtstock.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(txtdescrip);
            panel4.Location = new Point(23, 207);
            panel4.Name = "panel4";
            panel4.Size = new Size(642, 55);
            panel4.TabIndex = 1;
            // 
            // txtdescrip
            // 
            txtdescrip.Location = new Point(16, 3);
            txtdescrip.Multiline = true;
            txtdescrip.Name = "txtdescrip";
            txtdescrip.Size = new Size(607, 49);
            txtdescrip.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(txtmaterial);
            panel3.Location = new Point(23, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 55);
            panel3.TabIndex = 0;
            // 
            // txtmaterial
            // 
            txtmaterial.Location = new Point(13, 3);
            txtmaterial.Multiline = true;
            txtmaterial.Name = "txtmaterial";
            txtmaterial.Size = new Size(234, 49);
            txtmaterial.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 18);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 0;
            label1.Text = "Gestion Material";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.Controls.Add(comboBox2);
            panel8.Location = new Point(416, 404);
            panel8.Name = "panel8";
            panel8.Size = new Size(217, 36);
            panel8.TabIndex = 20;
            // 
            // FrmMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 591);
            Controls.Add(panel1);
            Name = "FrmMaterial";
            Text = "FrmMaterial";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvmaterial).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inpixmas).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ComboBox comboBox1;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private Label label8;
        private FontAwesome.Sharp.IconPictureBox inpixmas;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconcancelma;
        private FontAwesome.Sharp.IconButton IconGuardarm;
        private Label label10;
        private Panel panel7;
        private Label label9;
        private ComboBox comboBox2;
        private TextBox txtmaterial;
        private TextBox txtxprecio;
        private TextBox txtminimost;
        private TextBox txtstock;
        private TextBox txtdescrip;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private DataGridView dgvmaterial;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel8;
    }
}