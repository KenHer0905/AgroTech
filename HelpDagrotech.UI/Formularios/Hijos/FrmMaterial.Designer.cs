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
            panel9 = new Panel();
            txtbuscarMaterial = new TextBox();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            panel8 = new Panel();
            txtunidadmedida = new ComboBox();
            dgvmaterial = new DataGridView();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconcancelma = new FontAwesome.Sharp.IconButton();
            IconGuardarm = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            panel7 = new Panel();
            txtxprecio = new TextBox();
            label9 = new Label();
            label8 = new Label();
            inpixmas = new FontAwesome.Sharp.IconPictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtCategoriamate = new ComboBox();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvmaterial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inpixmas).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 540);
            panel1.TabIndex = 0;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(0, 64, 0);
            iconPictureBox2.Cursor = Cursors.Hand;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 30;
            iconPictureBox2.Location = new Point(10, 9);
            iconPictureBox2.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(35, 30);
            iconPictureBox2.TabIndex = 19;
            iconPictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Honeydew;
            panel2.Controls.Add(panel9);
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
            panel2.Controls.Add(txtCategoriamate);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(10, 55);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(886, 483);
            panel2.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(txtbuscarMaterial);
            panel9.Controls.Add(iconPictureBox7);
            panel9.Location = new Point(18, 386);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(284, 36);
            panel9.TabIndex = 21;
            // 
            // txtbuscarMaterial
            // 
            txtbuscarMaterial.BackColor = Color.FromArgb(0, 64, 0);
            txtbuscarMaterial.ForeColor = Color.White;
            txtbuscarMaterial.Location = new Point(43, 6);
            txtbuscarMaterial.Margin = new Padding(3, 2, 3, 2);
            txtbuscarMaterial.Name = "txtbuscarMaterial";
            txtbuscarMaterial.PlaceholderText = "Buscar Material";
            txtbuscarMaterial.Size = new Size(227, 23);
            txtbuscarMaterial.TabIndex = 1;
            txtbuscarMaterial.TextChanged += txtbuscarMaterial_TextChanged_1;
            // 
            // iconPictureBox7
            // 
            iconPictureBox7.BackColor = Color.FromArgb(0, 64, 0);
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
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.Controls.Add(txtunidadmedida);
            panel8.Location = new Point(364, 303);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(190, 27);
            panel8.TabIndex = 20;
            // 
            // txtunidadmedida
            // 
            txtunidadmedida.FormattingEnabled = true;
            txtunidadmedida.Items.AddRange(new object[] { "Kg", "Lt" });
            txtunidadmedida.Location = new Point(3, 2);
            txtunidadmedida.Margin = new Padding(3, 2, 3, 2);
            txtunidadmedida.Name = "txtunidadmedida";
            txtunidadmedida.Size = new Size(186, 23);
            txtunidadmedida.TabIndex = 11;
            // 
            // dgvmaterial
            // 
            dgvmaterial.AllowUserToAddRows = false;
            dgvmaterial.AllowUserToDeleteRows = false;
            dgvmaterial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvmaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmaterial.Location = new Point(18, 426);
            dgvmaterial.Margin = new Padding(3, 2, 3, 2);
            dgvmaterial.Name = "dgvmaterial";
            dgvmaterial.ReadOnly = true;
            dgvmaterial.RowHeadersWidth = 51;
            dgvmaterial.Size = new Size(770, 175);
            dgvmaterial.TabIndex = 19;
            dgvmaterial.CellContentClick += dgvmaterial_CellContentClick;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Honeydew;
            iconPictureBox1.ForeColor = Color.FromArgb(0, 64, 0);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            iconPictureBox1.IconColor = Color.FromArgb(0, 64, 0);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 30;
            iconPictureBox1.Location = new Point(18, 6);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(35, 30);
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
            iconcancelma.Location = new Point(680, 296);
            iconcancelma.Margin = new Padding(3, 2, 3, 2);
            iconcancelma.Name = "iconcancelma";
            iconcancelma.Size = new Size(103, 41);
            iconcancelma.TabIndex = 17;
            iconcancelma.Text = "Cancelar";
            iconcancelma.UseVisualStyleBackColor = false;
            iconcancelma.Click += iconcancelma_Click;
            // 
            // IconGuardarm
            // 
            IconGuardarm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IconGuardarm.BackColor = Color.MistyRose;
            IconGuardarm.IconChar = FontAwesome.Sharp.IconChar.Save;
            IconGuardarm.IconColor = Color.Black;
            IconGuardarm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconGuardarm.ImageAlign = ContentAlignment.MiddleLeft;
            IconGuardarm.Location = new Point(680, 234);
            IconGuardarm.Margin = new Padding(3, 2, 3, 2);
            IconGuardarm.Name = "IconGuardarm";
            IconGuardarm.Size = new Size(103, 41);
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
            label10.Location = new Point(32, 284);
            label10.Name = "label10";
            label10.Size = new Size(48, 19);
            label10.TabIndex = 14;
            label10.Text = "Precio";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.Controls.Add(txtxprecio);
            panel7.Location = new Point(21, 303);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(219, 41);
            panel7.TabIndex = 13;
            // 
            // txtxprecio
            // 
            txtxprecio.Location = new Point(10, 4);
            txtxprecio.Margin = new Padding(3, 2, 3, 2);
            txtxprecio.Multiline = true;
            txtxprecio.Name = "txtxprecio";
            txtxprecio.Size = new Size(205, 38);
            txtxprecio.TabIndex = 2;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(0, 64, 0);
            label9.Location = new Point(364, 284);
            label9.Name = "label9";
            label9.Size = new Size(105, 19);
            label9.TabIndex = 12;
            label9.Text = "Unidad Medida";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.MistyRose;
            label8.ForeColor = Color.FromArgb(0, 64, 0);
            label8.Location = new Point(732, 164);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
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
            inpixmas.IconSize = 129;
            inpixmas.Location = new Point(680, 42);
            inpixmas.Margin = new Padding(3, 2, 3, 2);
            inpixmas.Name = "inpixmas";
            inpixmas.Size = new Size(164, 129);
            inpixmas.SizeMode = PictureBoxSizeMode.CenterImage;
            inpixmas.TabIndex = 9;
            inpixmas.TabStop = false;
            inpixmas.Click += inpixmas_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 64, 0);
            label7.Location = new Point(364, 214);
            label7.Name = "label7";
            label7.Size = new Size(97, 19);
            label7.TabIndex = 5;
            label7.Text = "Stock Minimo";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 64, 0);
            label6.Location = new Point(32, 61);
            label6.Name = "label6";
            label6.Size = new Size(116, 19);
            label6.TabIndex = 8;
            label6.Text = "Nombre Material";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 64, 0);
            label5.Location = new Point(326, 64);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 7;
            label5.Text = "Categoria";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 64, 0);
            label4.Location = new Point(32, 136);
            label4.Name = "label4";
            label4.Size = new Size(83, 19);
            label4.TabIndex = 6;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 64, 0);
            label3.Location = new Point(32, 214);
            label3.Name = "label3";
            label3.Size = new Size(44, 19);
            label3.TabIndex = 5;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 64, 0);
            label2.Location = new Point(59, 11);
            label2.Name = "label2";
            label2.Size = new Size(121, 19);
            label2.TabIndex = 4;
            label2.Text = "Registrar Material";
            // 
            // txtCategoriamate
            // 
            txtCategoriamate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCategoriamate.FormattingEnabled = true;
            txtCategoriamate.Items.AddRange(new object[] { "Fertilizante", "Urea", "Pesticidas" });
            txtCategoriamate.Location = new Point(326, 91);
            txtCategoriamate.Margin = new Padding(3, 2, 3, 2);
            txtCategoriamate.Name = "txtCategoriamate";
            txtCategoriamate.Size = new Size(186, 23);
            txtCategoriamate.TabIndex = 3;
            txtCategoriamate.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.Controls.Add(txtminimost);
            panel6.Location = new Point(364, 234);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(219, 41);
            panel6.TabIndex = 1;
            // 
            // txtminimost
            // 
            txtminimost.Location = new Point(11, 2);
            txtminimost.Margin = new Padding(3, 2, 3, 2);
            txtminimost.Multiline = true;
            txtminimost.Name = "txtminimost";
            txtminimost.Size = new Size(205, 38);
            txtminimost.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(txtstock);
            panel5.Location = new Point(21, 234);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(219, 41);
            panel5.TabIndex = 2;
            // 
            // txtstock
            // 
            txtstock.Location = new Point(10, 4);
            txtstock.Margin = new Padding(3, 2, 3, 2);
            txtstock.Multiline = true;
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(205, 38);
            txtstock.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(txtdescrip);
            panel4.Location = new Point(20, 155);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(562, 41);
            panel4.TabIndex = 1;
            // 
            // txtdescrip
            // 
            txtdescrip.Location = new Point(14, 2);
            txtdescrip.Margin = new Padding(3, 2, 3, 2);
            txtdescrip.Multiline = true;
            txtdescrip.Name = "txtdescrip";
            txtdescrip.Size = new Size(532, 38);
            txtdescrip.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(txtmaterial);
            panel3.Location = new Point(20, 80);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 41);
            panel3.TabIndex = 0;
            // 
            // txtmaterial
            // 
            txtmaterial.Location = new Point(11, 2);
            txtmaterial.Margin = new Padding(3, 2, 3, 2);
            txtmaterial.Multiline = true;
            txtmaterial.Name = "txtmaterial";
            txtmaterial.Size = new Size(205, 38);
            txtmaterial.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 14);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 0;
            label1.Text = "Gestion Material";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // FrmMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 540);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMaterial";
            Text = "FrmMaterial";
            Load += FrmMaterial_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            panel8.ResumeLayout(false);
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ComboBox txtCategoriamate;
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
        private ComboBox txtunidadmedida;
        private TextBox txtmaterial;
        private TextBox txtxprecio;
        private TextBox txtminimost;
        private TextBox txtstock;
        private TextBox txtdescrip;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private DataGridView dgvmaterial;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel8;
        private Panel panel9;
        private TextBox txtbuscarMaterial;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
    }
}