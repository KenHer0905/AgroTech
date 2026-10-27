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
            flowLayoutPanel1 = new FlowLayoutPanel();
            IconGuardarm = new FontAwesome.Sharp.IconButton();
            iconeditar = new FontAwesome.Sharp.IconButton();
            iconcancelma = new FontAwesome.Sharp.IconButton();
            palbuscar = new Panel();
            txtbuscarmaterisl = new TextBox();
            iconPictureBox11 = new FontAwesome.Sharp.IconPictureBox();
            groupBox3 = new GroupBox();
            inpixmas = new FontAwesome.Sharp.IconPictureBox();
            label8 = new Label();
            groupBox2 = new GroupBox();
            label11 = new Label();
            iconPictureBox10 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            txtunidadmedida = new ComboBox();
            txtxprecio = new TextBox();
            txtminimost = new TextBox();
            label7 = new Label();
            label10 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            txtstock = new TextBox();
            txtmaterial = new TextBox();
            txtdescrip = new TextBox();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label5 = new Label();
            txtCategoriamate = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dgvmaterial = new DataGridView();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            palbuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox11).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inpixmas).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvmaterial).BeginInit();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1272, 752);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(palbuscar);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(0, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(1269, 676);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(IconGuardarm);
            flowLayoutPanel1.Controls.Add(iconeditar);
            flowLayoutPanel1.Controls.Add(iconcancelma);
            flowLayoutPanel1.Location = new Point(956, 291);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(340, 76);
            flowLayoutPanel1.TabIndex = 28;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
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
            IconGuardarm.Size = new Size(115, 63);
            IconGuardarm.TabIndex = 15;
            IconGuardarm.Text = "Guardar";
            IconGuardarm.TextAlign = ContentAlignment.MiddleRight;
            IconGuardarm.UseVisualStyleBackColor = false;
            IconGuardarm.Click += IconGuardarm_Click;
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
            iconeditar.Location = new Point(124, 3);
            iconeditar.Name = "iconeditar";
            iconeditar.Size = new Size(91, 65);
            iconeditar.TabIndex = 26;
            iconeditar.Text = "Editar";
            iconeditar.TextAlign = ContentAlignment.MiddleRight;
            iconeditar.UseVisualStyleBackColor = false;
            iconeditar.Click += iconeditar_Click;
            // 
            // iconcancelma
            // 
            iconcancelma.BackColor = Color.FromArgb(0, 64, 0);
            iconcancelma.Cursor = Cursors.Hand;
            iconcancelma.ForeColor = Color.White;
            iconcancelma.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            iconcancelma.IconColor = Color.White;
            iconcancelma.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconcancelma.IconSize = 40;
            iconcancelma.ImageAlign = ContentAlignment.MiddleLeft;
            iconcancelma.Location = new Point(221, 3);
            iconcancelma.Name = "iconcancelma";
            iconcancelma.Size = new Size(115, 65);
            iconcancelma.TabIndex = 17;
            iconcancelma.Text = "Cancelar";
            iconcancelma.TextAlign = ContentAlignment.MiddleRight;
            iconcancelma.UseVisualStyleBackColor = false;
            iconcancelma.Click += iconcancelma_Click;
            // 
            // palbuscar
            // 
            palbuscar.BackColor = Color.FromArgb(192, 255, 192);
            palbuscar.Controls.Add(txtbuscarmaterisl);
            palbuscar.Controls.Add(iconPictureBox11);
            palbuscar.Location = new Point(88, 393);
            palbuscar.Name = "palbuscar";
            palbuscar.Size = new Size(584, 40);
            palbuscar.TabIndex = 27;
            // 
            // txtbuscarmaterisl
            // 
            txtbuscarmaterisl.BackColor = Color.FromArgb(192, 255, 192);
            txtbuscarmaterisl.Location = new Point(49, 8);
            txtbuscarmaterisl.Name = "txtbuscarmaterisl";
            txtbuscarmaterisl.PlaceholderText = "Buscar Material por Categoria";
            txtbuscarmaterisl.Size = new Size(420, 27);
            txtbuscarmaterisl.TabIndex = 1;
            // 
            // iconPictureBox11
            // 
            iconPictureBox11.BackColor = Color.FromArgb(192, 255, 192);
            iconPictureBox11.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox11.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox11.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox11.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox11.IconSize = 43;
            iconPictureBox11.Location = new Point(0, 0);
            iconPictureBox11.Name = "iconPictureBox11";
            iconPictureBox11.Size = new Size(43, 48);
            iconPictureBox11.TabIndex = 0;
            iconPictureBox11.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(inpixmas);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(934, 8);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(310, 247);
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
            inpixmas.IconSize = 157;
            inpixmas.Location = new Point(53, 36);
            inpixmas.Name = "inpixmas";
            inpixmas.Size = new Size(188, 157);
            inpixmas.SizeMode = PictureBoxSizeMode.CenterImage;
            inpixmas.TabIndex = 9;
            inpixmas.TabStop = false;
            inpixmas.Click += inpixmas_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.MistyRose;
            label8.ForeColor = Color.FromArgb(0, 64, 0);
            label8.Location = new Point(112, 196);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 10;
            label8.Text = "Subir Foto";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(iconPictureBox10);
            groupBox2.Controls.Add(iconPictureBox9);
            groupBox2.Controls.Add(iconPictureBox8);
            groupBox2.Controls.Add(iconPictureBox7);
            groupBox2.Controls.Add(txtunidadmedida);
            groupBox2.Controls.Add(txtxprecio);
            groupBox2.Controls.Add(txtminimost);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Cursor = Cursors.Hand;
            groupBox2.Location = new Point(498, 8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(430, 359);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Olive;
            label11.Location = new Point(66, 0);
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
            iconPictureBox10.IconSize = 40;
            iconPictureBox10.Location = new Point(19, -7);
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
            iconPictureBox9.Location = new Point(12, 234);
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
            iconPictureBox8.Location = new Point(16, 133);
            iconPictureBox8.Name = "iconPictureBox8";
            iconPictureBox8.Size = new Size(40, 40);
            iconPictureBox8.TabIndex = 24;
            iconPictureBox8.TabStop = false;
            // 
            // iconPictureBox7
            // 
            iconPictureBox7.BackColor = Color.Honeydew;
            iconPictureBox7.ForeColor = Color.Green;
            iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.ArrowTrendUp;
            iconPictureBox7.IconColor = Color.Green;
            iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox7.IconSize = 40;
            iconPictureBox7.Location = new Point(12, 62);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(40, 40);
            iconPictureBox7.TabIndex = 23;
            iconPictureBox7.TabStop = false;
            // 
            // txtunidadmedida
            // 
            txtunidadmedida.FormattingEnabled = true;
            txtunidadmedida.Items.AddRange(new object[] { "Kg", "Lt" });
            txtunidadmedida.Location = new Point(58, 246);
            txtunidadmedida.Name = "txtunidadmedida";
            txtunidadmedida.Size = new Size(313, 28);
            txtunidadmedida.TabIndex = 11;
            // 
            // txtxprecio
            // 
            txtxprecio.Cursor = Cursors.IBeam;
            txtxprecio.Location = new Point(58, 136);
            txtxprecio.Multiline = true;
            txtxprecio.Name = "txtxprecio";
            txtxprecio.Size = new Size(313, 40);
            txtxprecio.TabIndex = 2;
            // 
            // txtminimost
            // 
            txtminimost.Cursor = Cursors.IBeam;
            txtminimost.Location = new Point(58, 62);
            txtminimost.Multiline = true;
            txtminimost.Name = "txtminimost";
            txtminimost.Size = new Size(313, 33);
            txtminimost.TabIndex = 3;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 64, 0);
            label7.Location = new Point(58, 36);
            label7.Name = "label7";
            label7.Size = new Size(116, 23);
            label7.TabIndex = 5;
            label7.Text = "Stock Minimo";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(0, 64, 0);
            label10.Location = new Point(58, 110);
            label10.Name = "label10";
            label10.Size = new Size(57, 23);
            label10.TabIndex = 14;
            label10.Text = "Precio";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(0, 64, 0);
            label9.Location = new Point(58, 219);
            label9.Name = "label9";
            label9.Size = new Size(128, 23);
            label9.TabIndex = 12;
            label9.Text = "Unidad Medida";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(iconPictureBox6);
            groupBox1.Controls.Add(iconPictureBox5);
            groupBox1.Controls.Add(iconPictureBox4);
            groupBox1.Controls.Add(iconPictureBox3);
            groupBox1.Controls.Add(txtstock);
            groupBox1.Controls.Add(txtmaterial);
            groupBox1.Controls.Add(txtdescrip);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(iconPictureBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCategoriamate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(36, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 364);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.Honeydew;
            iconPictureBox6.ForeColor = Color.Green;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Database;
            iconPictureBox6.IconColor = Color.Green;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 37;
            iconPictureBox6.Location = new Point(15, 298);
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
            iconPictureBox5.Location = new Point(13, 215);
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
            iconPictureBox4.Location = new Point(15, 141);
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
            iconPictureBox3.Location = new Point(16, 60);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(40, 40);
            iconPictureBox3.TabIndex = 19;
            iconPictureBox3.TabStop = false;
            // 
            // txtstock
            // 
            txtstock.Cursor = Cursors.IBeam;
            txtstock.Location = new Point(62, 298);
            txtstock.Multiline = true;
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(342, 37);
            txtstock.TabIndex = 1;
            // 
            // txtmaterial
            // 
            txtmaterial.Cursor = Cursors.IBeam;
            txtmaterial.Location = new Point(62, 67);
            txtmaterial.Multiline = true;
            txtmaterial.Name = "txtmaterial";
            txtmaterial.Size = new Size(342, 33);
            txtmaterial.TabIndex = 0;
            // 
            // txtdescrip
            // 
            txtdescrip.Cursor = Cursors.IBeam;
            txtdescrip.Location = new Point(62, 141);
            txtdescrip.Multiline = true;
            txtdescrip.Name = "txtdescrip";
            txtdescrip.Size = new Size(342, 37);
            txtdescrip.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 64, 0);
            label2.Location = new Point(62, 5);
            label2.Name = "label2";
            label2.Size = new Size(146, 23);
            label2.TabIndex = 4;
            label2.Text = "Registrar Material";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Honeydew;
            iconPictureBox1.ForeColor = Color.FromArgb(0, 64, 0);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            iconPictureBox1.IconColor = Color.FromArgb(0, 64, 0);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(15, -2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 18;
            iconPictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 64, 0);
            label5.Location = new Point(67, 198);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 7;
            label5.Text = "Categoria";
            // 
            // txtCategoriamate
            // 
            txtCategoriamate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCategoriamate.Cursor = Cursors.Hand;
            txtCategoriamate.FormattingEnabled = true;
            txtCategoriamate.Items.AddRange(new object[] { "Fertilizante", "Urea", "Pesticidas" });
            txtCategoriamate.Location = new Point(62, 224);
            txtCategoriamate.Name = "txtCategoriamate";
            txtCategoriamate.Size = new Size(342, 28);
            txtCategoriamate.TabIndex = 3;
            txtCategoriamate.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 64, 0);
            label6.Location = new Point(67, 41);
            label6.Name = "label6";
            label6.Size = new Size(141, 23);
            label6.TabIndex = 8;
            label6.Text = "Nombre Material";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 64, 0);
            label4.Location = new Point(67, 115);
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
            label3.Location = new Point(67, 272);
            label3.Name = "label3";
            label3.Size = new Size(52, 23);
            label3.TabIndex = 5;
            label3.Text = "Stock";
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
            // dgvmaterial
            // 
            dgvmaterial.AccessibleRole = AccessibleRole.Caret;
            dgvmaterial.AllowUserToDeleteRows = false;
            dgvmaterial.AllowUserToOrderColumns = true;
            dgvmaterial.BorderStyle = BorderStyle.None;
            dgvmaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmaterial.Location = new Point(3, 0);
            dgvmaterial.Name = "dgvmaterial";
            dgvmaterial.ReadOnly = true;
            dgvmaterial.RowHeadersWidth = 51;
            dgvmaterial.Size = new Size(1311, 187);
            dgvmaterial.TabIndex = 19;
            dgvmaterial.CellContentClick += dgvmaterial_CellContentClick;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(dgvmaterial);
            panel3.Location = new Point(36, 447);
            panel3.Name = "panel3";
            panel3.Size = new Size(1311, 187);
            panel3.TabIndex = 29;
            panel3.Paint += panel3_Paint;
            // 
            // FrmMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 752);
            Controls.Add(panel1);
            Name = "FrmMaterial";
            Text = "FrmMaterial";
            Load += FrmMaterial_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            palbuscar.ResumeLayout(false);
            palbuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox11).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inpixmas).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvmaterial).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ComboBox txtCategoriamate;
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
        private Label label9;
        private ComboBox txtunidadmedida;
        private TextBox txtmaterial;
        private TextBox txtxprecio;
        private TextBox txtstock;
        private TextBox txtdescrip;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private GroupBox groupBox1;
        private TextBox txtminimost;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton iconeditar;
        private Label label11;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox10;
        private Panel palbuscar;
        private TextBox txtbuscarmaterisl;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox11;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dgvmaterial;
        private Panel panel3;
    }
}