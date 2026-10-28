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
            panel2 = new Panel();
            dgvmateril = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            IconGuardarm = new FontAwesome.Sharp.IconButton();
            iconeditar = new FontAwesome.Sharp.IconButton();
            iconcancelma = new FontAwesome.Sharp.IconButton();
            groupBox3 = new GroupBox();
            inpixmas = new FontAwesome.Sharp.IconPictureBox();
            groupBox2 = new GroupBox();
            label10 = new Label();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            label4 = new Label();
            label6 = new Label();
            txtunidadmedida = new TextBox();
            label11 = new Label();
            iconPictureBox10 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            txtxprecio = new TextBox();
            txtminimost = new TextBox();
            groupBox1 = new GroupBox();
            label12 = new Label();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            txtstock = new TextBox();
            txtmaterial = new TextBox();
            txtCategoriamate = new ComboBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtdescrip = new TextBox();
            label2 = new Label();
            panel9 = new Panel();
            txtbuscarMaterial = new TextBox();
            label7 = new Label();
            label5 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvmateril).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inpixmas).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(iconPictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1549, 720);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Honeydew;
            panel2.Controls.Add(dgvmateril);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(-6, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(1555, 662);
            panel2.TabIndex = 20;
            // 
            // dgvmateril
            // 
            dgvmateril.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmateril.Location = new Point(18, 597);
            dgvmateril.Name = "dgvmateril";
            dgvmateril.RowHeadersWidth = 51;
            dgvmateril.Size = new Size(1537, 188);
            dgvmateril.TabIndex = 29;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(IconGuardarm);
            flowLayoutPanel1.Controls.Add(iconeditar);
            flowLayoutPanel1.Controls.Add(iconcancelma);
            flowLayoutPanel1.Location = new Point(1085, 326);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(363, 101);
            flowLayoutPanel1.TabIndex = 28;
            // 
            // IconGuardarm
            // 
            IconGuardarm.BackColor = Color.FromArgb(0, 64, 0);
            IconGuardarm.Cursor = Cursors.Hand;
            IconGuardarm.ForeColor = Color.White;
            IconGuardarm.IconChar = FontAwesome.Sharp.IconChar.Save;
            IconGuardarm.IconColor = Color.White;
            IconGuardarm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconGuardarm.ImageAlign = ContentAlignment.MiddleLeft;
            IconGuardarm.Location = new Point(3, 3);
            IconGuardarm.Name = "IconGuardarm";
            IconGuardarm.Size = new Size(118, 88);
            IconGuardarm.TabIndex = 15;
            IconGuardarm.Text = "Guardar";
            IconGuardarm.TextAlign = ContentAlignment.MiddleRight;
            IconGuardarm.UseVisualStyleBackColor = false;
            IconGuardarm.Click += IconGuardarm_Click_1;
            // 
            // iconeditar
            // 
            iconeditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconeditar.BackColor = Color.Olive;
            iconeditar.ForeColor = Color.White;
            iconeditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconeditar.IconColor = Color.White;
            iconeditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconeditar.ImageAlign = ContentAlignment.MiddleLeft;
            iconeditar.Location = new Point(127, 4);
            iconeditar.Margin = new Padding(3, 4, 3, 4);
            iconeditar.Name = "iconeditar";
            iconeditar.Size = new Size(104, 87);
            iconeditar.TabIndex = 26;
            iconeditar.Text = "Editar";
            iconeditar.TextAlign = ContentAlignment.MiddleRight;
            iconeditar.UseVisualStyleBackColor = false;
            // 
            // iconcancelma
            // 
            iconcancelma.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconcancelma.BackColor = Color.Silver;
            iconcancelma.IconChar = FontAwesome.Sharp.IconChar.None;
            iconcancelma.IconColor = Color.Black;
            iconcancelma.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconcancelma.Location = new Point(237, 3);
            iconcancelma.Name = "iconcancelma";
            iconcancelma.Size = new Size(118, 88);
            iconcancelma.TabIndex = 17;
            iconcancelma.Text = "Cancelar";
            iconcancelma.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(inpixmas);
            groupBox3.Location = new Point(1134, 52);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(257, 223);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
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
            inpixmas.Location = new Point(42, 27);
            inpixmas.Name = "inpixmas";
            inpixmas.Size = new Size(187, 172);
            inpixmas.SizeMode = PictureBoxSizeMode.CenterImage;
            inpixmas.TabIndex = 9;
            inpixmas.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(iconPictureBox7);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtunidadmedida);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(iconPictureBox10);
            groupBox2.Controls.Add(iconPictureBox9);
            groupBox2.Controls.Add(iconPictureBox8);
            groupBox2.Controls.Add(txtxprecio);
            groupBox2.Controls.Add(txtminimost);
            groupBox2.Cursor = Cursors.Hand;
            groupBox2.Location = new Point(512, 4);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(491, 485);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(0, 64, 0);
            label10.Location = new Point(97, 58);
            label10.Name = "label10";
            label10.Size = new Size(116, 23);
            label10.TabIndex = 28;
            label10.Text = "Stock Minimo";
            // 
            // iconPictureBox7
            // 
            iconPictureBox7.BackColor = Color.Honeydew;
            iconPictureBox7.ForeColor = Color.Green;
            iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.ArrowTrendUp;
            iconPictureBox7.IconColor = Color.Green;
            iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox7.IconSize = 46;
            iconPictureBox7.Location = new Point(45, 84);
            iconPictureBox7.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(46, 53);
            iconPictureBox7.TabIndex = 27;
            iconPictureBox7.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 64, 0);
            label4.Location = new Point(97, 159);
            label4.Name = "label4";
            label4.Size = new Size(57, 23);
            label4.TabIndex = 24;
            label4.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 64, 0);
            label6.Location = new Point(97, 286);
            label6.Name = "label6";
            label6.Size = new Size(152, 23);
            label6.TabIndex = 25;
            label6.Text = "Unidad de Medida";
            // 
            // txtunidadmedida
            // 
            txtunidadmedida.Cursor = Cursors.IBeam;
            txtunidadmedida.Location = new Point(97, 312);
            txtunidadmedida.Multiline = true;
            txtunidadmedida.Name = "txtunidadmedida";
            txtunidadmedida.Size = new Size(234, 49);
            txtunidadmedida.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Olive;
            label11.Location = new Point(74, 10);
            label11.Name = "label11";
            label11.Size = new Size(163, 23);
            label11.TabIndex = 23;
            label11.Text = "Alarmas de Material";
            // 
            // iconPictureBox10
            // 
            iconPictureBox10.BackColor = Color.Honeydew;
            iconPictureBox10.ForeColor = Color.Olive;
            iconPictureBox10.IconChar = FontAwesome.Sharp.IconChar.Cog;
            iconPictureBox10.IconColor = Color.Olive;
            iconPictureBox10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox10.IconSize = 46;
            iconPictureBox10.Location = new Point(22, 0);
            iconPictureBox10.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox10.Name = "iconPictureBox10";
            iconPictureBox10.Size = new Size(46, 53);
            iconPictureBox10.TabIndex = 24;
            iconPictureBox10.TabStop = false;
            // 
            // iconPictureBox9
            // 
            iconPictureBox9.BackColor = Color.Honeydew;
            iconPictureBox9.ForeColor = Color.Green;
            iconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.BalanceScaleRight;
            iconPictureBox9.IconColor = Color.Green;
            iconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox9.IconSize = 46;
            iconPictureBox9.Location = new Point(45, 312);
            iconPictureBox9.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox9.Name = "iconPictureBox9";
            iconPictureBox9.Size = new Size(46, 53);
            iconPictureBox9.TabIndex = 25;
            iconPictureBox9.TabStop = false;
            // 
            // iconPictureBox8
            // 
            iconPictureBox8.BackColor = Color.Honeydew;
            iconPictureBox8.ForeColor = Color.Green;
            iconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            iconPictureBox8.IconColor = Color.Green;
            iconPictureBox8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox8.IconSize = 46;
            iconPictureBox8.Location = new Point(45, 185);
            iconPictureBox8.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox8.Name = "iconPictureBox8";
            iconPictureBox8.Size = new Size(46, 53);
            iconPictureBox8.TabIndex = 24;
            iconPictureBox8.TabStop = false;
            // 
            // txtxprecio
            // 
            txtxprecio.Cursor = Cursors.IBeam;
            txtxprecio.Location = new Point(97, 185);
            txtxprecio.Multiline = true;
            txtxprecio.Name = "txtxprecio";
            txtxprecio.Size = new Size(357, 52);
            txtxprecio.TabIndex = 2;
            // 
            // txtminimost
            // 
            txtminimost.Cursor = Cursors.IBeam;
            txtminimost.Location = new Point(97, 84);
            txtminimost.Multiline = true;
            txtminimost.Name = "txtminimost";
            txtminimost.Size = new Size(234, 49);
            txtminimost.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(iconPictureBox6);
            groupBox1.Controls.Add(iconPictureBox5);
            groupBox1.Controls.Add(iconPictureBox4);
            groupBox1.Controls.Add(iconPictureBox3);
            groupBox1.Controls.Add(txtstock);
            groupBox1.Controls.Add(txtmaterial);
            groupBox1.Controls.Add(txtCategoriamate);
            groupBox1.Controls.Add(iconPictureBox1);
            groupBox1.Controls.Add(txtdescrip);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(11, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(495, 485);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(0, 64, 0);
            label12.Location = new Point(95, 88);
            label12.Name = "label12";
            label12.Size = new Size(141, 23);
            label12.TabIndex = 29;
            label12.Text = "Nombre Material";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(0, 64, 0);
            label9.Location = new Point(96, 193);
            label9.Name = "label9";
            label9.Size = new Size(98, 23);
            label9.TabIndex = 27;
            label9.Text = "Descripción";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 64, 0);
            label8.Location = new Point(95, 389);
            label8.Name = "label8";
            label8.Size = new Size(52, 23);
            label8.TabIndex = 26;
            label8.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 64, 0);
            label3.Location = new Point(98, 292);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 23;
            label3.Text = "Categoria";
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.Honeydew;
            iconPictureBox6.ForeColor = Color.Green;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Database;
            iconPictureBox6.IconColor = Color.Green;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 46;
            iconPictureBox6.Location = new Point(28, 415);
            iconPictureBox6.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(46, 49);
            iconPictureBox6.TabIndex = 22;
            iconPictureBox6.TabStop = false;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.Honeydew;
            iconPictureBox5.ForeColor = Color.Green;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Tags;
            iconPictureBox5.IconColor = Color.Green;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 48;
            iconPictureBox5.Location = new Point(29, 308);
            iconPictureBox5.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(48, 60);
            iconPictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox5.TabIndex = 21;
            iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.Honeydew;
            iconPictureBox4.ForeColor = Color.Green;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            iconPictureBox4.IconColor = Color.Green;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 46;
            iconPictureBox4.Location = new Point(31, 218);
            iconPictureBox4.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(46, 53);
            iconPictureBox4.TabIndex = 20;
            iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.Honeydew;
            iconPictureBox3.ForeColor = Color.Green;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Tag;
            iconPictureBox3.IconColor = Color.Green;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 46;
            iconPictureBox3.Location = new Point(31, 110);
            iconPictureBox3.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(46, 53);
            iconPictureBox3.TabIndex = 19;
            iconPictureBox3.TabStop = false;
            // 
            // txtstock
            // 
            txtstock.Cursor = Cursors.IBeam;
            txtstock.Location = new Point(84, 415);
            txtstock.Multiline = true;
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(290, 49);
            txtstock.TabIndex = 1;
            // 
            // txtmaterial
            // 
            txtmaterial.Cursor = Cursors.IBeam;
            txtmaterial.Location = new Point(84, 114);
            txtmaterial.Multiline = true;
            txtmaterial.Name = "txtmaterial";
            txtmaterial.Size = new Size(302, 49);
            txtmaterial.TabIndex = 0;
            // 
            // txtCategoriamate
            // 
            txtCategoriamate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCategoriamate.Cursor = Cursors.Hand;
            txtCategoriamate.FormattingEnabled = true;
            txtCategoriamate.Items.AddRange(new object[] { "Fertilizante", "Urea", "Pesticidas", "Fertilizante", "Urea", "Pesticidas" });
            txtCategoriamate.Location = new Point(83, 333);
            txtCategoriamate.Name = "txtCategoriamate";
            txtCategoriamate.Size = new Size(291, 28);
            txtCategoriamate.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Honeydew;
            iconPictureBox1.ForeColor = Color.FromArgb(0, 64, 0);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            iconPictureBox1.IconColor = Color.FromArgb(0, 64, 0);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 46;
            iconPictureBox1.Location = new Point(17, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(46, 53);
            iconPictureBox1.TabIndex = 18;
            iconPictureBox1.TabStop = false;
            // 
            // txtdescrip
            // 
            txtdescrip.Cursor = Cursors.IBeam;
            txtdescrip.Location = new Point(83, 222);
            txtdescrip.Multiline = true;
            txtdescrip.Name = "txtdescrip";
            txtdescrip.Size = new Size(303, 49);
            txtdescrip.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 64, 0);
            label2.Location = new Point(83, 19);
            label2.Name = "label2";
            label2.Size = new Size(146, 23);
            label2.TabIndex = 4;
            label2.Text = "Registrar Material";
            // 
            // panel9
            // 
            panel9.Controls.Add(txtbuscarMaterial);
            panel9.Location = new Point(21, 515);
            panel9.Name = "panel9";
            panel9.Size = new Size(325, 48);
            panel9.TabIndex = 21;
            // 
            // txtbuscarMaterial
            // 
            txtbuscarMaterial.BackColor = Color.FromArgb(0, 64, 0);
            txtbuscarMaterial.ForeColor = Color.White;
            txtbuscarMaterial.Location = new Point(49, 8);
            txtbuscarMaterial.Name = "txtbuscarMaterial";
            txtbuscarMaterial.PlaceholderText = "Buscar Material";
            txtbuscarMaterial.Size = new Size(259, 27);
            txtbuscarMaterial.TabIndex = 1;
            txtbuscarMaterial.TextChanged += txtbuscarMaterial_TextChanged_2;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 64, 0);
            label7.Location = new Point(326, 352);
            label7.Name = "label7";
            label7.Size = new Size(116, 23);
            label7.TabIndex = 5;
            label7.Text = "Stock Minimo";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 64, 0);
            label5.Location = new Point(886, 69);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 7;
            label5.Text = "Categoria";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(0, 64, 0);
            iconPictureBox2.Cursor = Cursors.Hand;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 40;
            iconPictureBox2.Location = new Point(11, 12);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(40, 40);
            iconPictureBox2.TabIndex = 19;
            iconPictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 19);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 0;
            label1.Text = "Gestion Material";
            // 
            // FrmMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1549, 720);
            Controls.Add(panel1);
            Name = "FrmMaterial";
            Text = "FrmMaterial";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvmateril).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)inpixmas).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ComboBox txtCategoriamate;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox inpixmas;
        private Label label7;
        private Label label5;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconcancelma;
        private FontAwesome.Sharp.IconButton IconGuardarm;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton iconeditar;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dgvmaterial;
        private Panel panel9;
        private TextBox txtbuscarMaterial;
        private GroupBox groupBox2;
        private Label label11;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox10;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox8;
        private TextBox txtxprecio;
        private TextBox txtminimost;
        private GroupBox groupBox1;

        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private TextBox txtstock;
        private TextBox txtmaterial;
        private TextBox txtdescrip;

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtunidadmedida;
        private Label label10;
        private Label label4;
        private Label label6;
        private Label label12;
        private Label label9;
        private Label label8;
        private Label label3;
        private DataGridView dgvmateril;


    }
}