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
            txtunidadmedida = new ComboBox();
            label10 = new Label();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            label4 = new Label();
            label6 = new Label();
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 540);
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
            panel2.Location = new Point(-5, 44);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1205, 496);
            panel2.TabIndex = 20;
            // 
            // dgvmateril
            // 
            dgvmateril.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmateril.Location = new Point(16, 448);
            dgvmateril.Margin = new Padding(3, 2, 3, 2);
            dgvmateril.Name = "dgvmateril";
            dgvmateril.RowHeadersWidth = 51;
            dgvmateril.Size = new Size(1345, 141);
            dgvmateril.TabIndex = 29;
            dgvmateril.CellContentClick += dgvmateril_CellContentClick_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(IconGuardarm);
            flowLayoutPanel1.Controls.Add(iconeditar);
            flowLayoutPanel1.Controls.Add(iconcancelma);
            flowLayoutPanel1.Location = new Point(949, 244);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(318, 76);
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
            IconGuardarm.Location = new Point(3, 2);
            IconGuardarm.Margin = new Padding(3, 2, 3, 2);
            IconGuardarm.Name = "IconGuardarm";
            IconGuardarm.Size = new Size(103, 66);
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
            iconeditar.Location = new Point(112, 3);
            iconeditar.Name = "iconeditar";
            iconeditar.Size = new Size(91, 65);
            iconeditar.TabIndex = 26;
            iconeditar.Text = "Editar";
            iconeditar.TextAlign = ContentAlignment.MiddleRight;
            iconeditar.UseVisualStyleBackColor = false;
            iconeditar.Click += iconeditar_Click_1;
            // 
            // iconcancelma
            // 
            iconcancelma.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconcancelma.BackColor = Color.Silver;
            iconcancelma.IconChar = FontAwesome.Sharp.IconChar.None;
            iconcancelma.IconColor = Color.Black;
            iconcancelma.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconcancelma.Location = new Point(209, 2);
            iconcancelma.Margin = new Padding(3, 2, 3, 2);
            iconcancelma.Name = "iconcancelma";
            iconcancelma.Size = new Size(103, 66);
            iconcancelma.TabIndex = 17;
            iconcancelma.Text = "Cancelar";
            iconcancelma.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(inpixmas);
            groupBox3.Location = new Point(992, 39);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(225, 167);
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
            inpixmas.IconSize = 129;
            inpixmas.Location = new Point(37, 20);
            inpixmas.Margin = new Padding(3, 2, 3, 2);
            inpixmas.Name = "inpixmas";
            inpixmas.Size = new Size(164, 129);
            inpixmas.SizeMode = PictureBoxSizeMode.CenterImage;
            inpixmas.TabIndex = 9;
            inpixmas.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtunidadmedida);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(iconPictureBox7);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(iconPictureBox10);
            groupBox2.Controls.Add(iconPictureBox9);
            groupBox2.Controls.Add(iconPictureBox8);
            groupBox2.Controls.Add(txtxprecio);
            groupBox2.Controls.Add(txtminimost);
            groupBox2.Cursor = Cursors.Hand;
            groupBox2.Location = new Point(448, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(430, 364);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // txtunidadmedida
            // 
            txtunidadmedida.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtunidadmedida.Cursor = Cursors.Hand;
            txtunidadmedida.FormattingEnabled = true;
            txtunidadmedida.Items.AddRange(new object[] { "Fertilizante", "Urea", "Pesticidas", "Fertilizante", "Urea", "Pesticidas" });
            txtunidadmedida.Location = new Point(85, 250);
            txtunidadmedida.Margin = new Padding(3, 2, 3, 2);
            txtunidadmedida.Name = "txtunidadmedida";
            txtunidadmedida.Size = new Size(255, 23);
            txtunidadmedida.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(0, 64, 0);
            label10.Location = new Point(85, 44);
            label10.Name = "label10";
            label10.Size = new Size(97, 19);
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
            iconPictureBox7.IconSize = 40;
            iconPictureBox7.Location = new Point(39, 63);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(40, 40);
            iconPictureBox7.TabIndex = 27;
            iconPictureBox7.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 64, 0);
            label4.Location = new Point(85, 119);
            label4.Name = "label4";
            label4.Size = new Size(48, 19);
            label4.TabIndex = 24;
            label4.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 64, 0);
            label6.Location = new Point(85, 214);
            label6.Name = "label6";
            label6.Size = new Size(124, 19);
            label6.TabIndex = 25;
            label6.Text = "Unidad de Medida";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Olive;
            label11.Location = new Point(65, 8);
            label11.Name = "label11";
            label11.Size = new Size(134, 19);
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
            iconPictureBox10.IconSize = 40;
            iconPictureBox10.Location = new Point(19, 0);
            iconPictureBox10.Name = "iconPictureBox10";
            iconPictureBox10.Size = new Size(40, 40);
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
            iconPictureBox9.IconSize = 40;
            iconPictureBox9.Location = new Point(39, 234);
            iconPictureBox9.Name = "iconPictureBox9";
            iconPictureBox9.Size = new Size(40, 40);
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
            iconPictureBox8.IconSize = 40;
            iconPictureBox8.Location = new Point(39, 139);
            iconPictureBox8.Name = "iconPictureBox8";
            iconPictureBox8.Size = new Size(40, 40);
            iconPictureBox8.TabIndex = 24;
            iconPictureBox8.TabStop = false;
            // 
            // txtxprecio
            // 
            txtxprecio.Cursor = Cursors.IBeam;
            txtxprecio.Location = new Point(85, 139);
            txtxprecio.Margin = new Padding(3, 2, 3, 2);
            txtxprecio.Multiline = true;
            txtxprecio.Name = "txtxprecio";
            txtxprecio.Size = new Size(313, 40);
            txtxprecio.TabIndex = 2;
            // 
            // txtminimost
            // 
            txtminimost.Cursor = Cursors.IBeam;
            txtminimost.Location = new Point(85, 63);
            txtminimost.Margin = new Padding(3, 2, 3, 2);
            txtminimost.Multiline = true;
            txtminimost.Name = "txtminimost";
            txtminimost.Size = new Size(205, 38);
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
            groupBox1.Location = new Point(10, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 364);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(0, 64, 0);
            label12.Location = new Point(83, 66);
            label12.Name = "label12";
            label12.Size = new Size(116, 19);
            label12.TabIndex = 29;
            label12.Text = "Nombre Material";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(0, 64, 0);
            label9.Location = new Point(84, 145);
            label9.Name = "label9";
            label9.Size = new Size(83, 19);
            label9.TabIndex = 27;
            label9.Text = "Descripción";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 64, 0);
            label8.Location = new Point(83, 292);
            label8.Name = "label8";
            label8.Size = new Size(44, 19);
            label8.TabIndex = 26;
            label8.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 64, 0);
            label3.Location = new Point(86, 219);
            label3.Name = "label3";
            label3.Size = new Size(69, 19);
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
            iconPictureBox6.IconSize = 37;
            iconPictureBox6.Location = new Point(24, 311);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(40, 37);
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
            iconPictureBox5.IconSize = 42;
            iconPictureBox5.Location = new Point(25, 231);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(42, 45);
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
            iconPictureBox4.IconSize = 40;
            iconPictureBox4.Location = new Point(27, 164);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(40, 40);
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
            iconPictureBox3.IconSize = 40;
            iconPictureBox3.Location = new Point(27, 82);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(40, 40);
            iconPictureBox3.TabIndex = 19;
            iconPictureBox3.TabStop = false;
            // 
            // txtstock
            // 
            txtstock.Cursor = Cursors.IBeam;
            txtstock.Location = new Point(74, 311);
            txtstock.Margin = new Padding(3, 2, 3, 2);
            txtstock.Multiline = true;
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(254, 38);
            txtstock.TabIndex = 1;
            // 
            // txtmaterial
            // 
            txtmaterial.Cursor = Cursors.IBeam;
            txtmaterial.Location = new Point(74, 86);
            txtmaterial.Margin = new Padding(3, 2, 3, 2);
            txtmaterial.Multiline = true;
            txtmaterial.Name = "txtmaterial";
            txtmaterial.Size = new Size(265, 38);
            txtmaterial.TabIndex = 0;
            // 
            // txtCategoriamate
            // 
            txtCategoriamate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCategoriamate.Cursor = Cursors.Hand;
            txtCategoriamate.FormattingEnabled = true;
            txtCategoriamate.Items.AddRange(new object[] { "Fertilizante", "Urea", "Pesticidas", "Fertilizante", "Urea", "Pesticidas" });
            txtCategoriamate.Location = new Point(73, 250);
            txtCategoriamate.Margin = new Padding(3, 2, 3, 2);
            txtCategoriamate.Name = "txtCategoriamate";
            txtCategoriamate.Size = new Size(255, 23);
            txtCategoriamate.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Honeydew;
            iconPictureBox1.ForeColor = Color.FromArgb(0, 64, 0);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            iconPictureBox1.IconColor = Color.FromArgb(0, 64, 0);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(15, 0);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 18;
            iconPictureBox1.TabStop = false;
            // 
            // txtdescrip
            // 
            txtdescrip.Cursor = Cursors.IBeam;
            txtdescrip.Location = new Point(73, 166);
            txtdescrip.Margin = new Padding(3, 2, 3, 2);
            txtdescrip.Multiline = true;
            txtdescrip.Name = "txtdescrip";
            txtdescrip.Size = new Size(266, 38);
            txtdescrip.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 64, 0);
            label2.Location = new Point(73, 14);
            label2.Name = "label2";
            label2.Size = new Size(121, 19);
            label2.TabIndex = 4;
            label2.Text = "Registrar Material";
            // 
            // panel9
            // 
            panel9.Controls.Add(txtbuscarMaterial);
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
            txtbuscarMaterial.TextChanged += txtbuscarMaterial_TextChanged_2;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 64, 0);
            label7.Location = new Point(285, 264);
            label7.Name = "label7";
            label7.Size = new Size(97, 19);
            label7.TabIndex = 5;
            label7.Text = "Stock Minimo";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 64, 0);
            label5.Location = new Point(775, 52);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
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
            iconPictureBox2.IconSize = 30;
            iconPictureBox2.Location = new Point(10, 9);
            iconPictureBox2.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(35, 30);
            iconPictureBox2.TabIndex = 19;
            iconPictureBox2.TabStop = false;
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
            // FrmMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 540);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMaterial";
            Text = "FrmMaterial";
            Load += FrmMaterial_Load_2;
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
        private Label label10;
        private Label label4;
        private Label label6;
        private Label label12;
        private Label label9;
        private Label label8;
        private Label label3;
        private DataGridView dgvmateril;
        private ComboBox txtunidadmedida;
    }
}