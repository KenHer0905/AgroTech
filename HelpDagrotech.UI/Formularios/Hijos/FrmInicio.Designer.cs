namespace HelpDagrotech.UI.Formularios
{
    partial class FrmCultivo
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
            paneldeCultivo = new Panel();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            lblmapaop = new Label();
            gMapAgroT = new GMap.NET.WindowsForms.GMapControl();
            panel1 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            lbltitulo = new Label();
            lblsemillas = new Label();
            lblCal = new Label();
            label2 = new Label();
            panel3 = new Panel();
            textBox1 = new TextBox();
            panelcosechaes = new Panel();
            txtcosechaestim = new TextBox();
            lblcose = new Label();
            lblSemillav = new Label();
            panelvaridadse = new Panel();
            txtsemilava = new TextBox();
            panelterreno1 = new Panel();
            txtterreno = new TextBox();
            lblterreno = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblRegistroSbra = new Label();
            label1 = new Label();
            paneldeCultivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panelcosechaes.SuspendLayout();
            panelvaridadse.SuspendLayout();
            panelterreno1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // paneldeCultivo
            // 
            paneldeCultivo.BackColor = Color.FromArgb(0, 64, 0);
            paneldeCultivo.Controls.Add(label3);
            paneldeCultivo.Controls.Add(dataGridView1);
            paneldeCultivo.Controls.Add(panel4);
            paneldeCultivo.Controls.Add(panel1);
            paneldeCultivo.Dock = DockStyle.Fill;
            paneldeCultivo.Location = new Point(0, 0);
            paneldeCultivo.Name = "paneldeCultivo";
            paneldeCultivo.Size = new Size(1037, 662);
            paneldeCultivo.TabIndex = 0;
            paneldeCultivo.Paint += paneldeCultivo_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 27);
            label3.Name = "label3";
            label3.Size = new Size(153, 23);
            label3.TabIndex = 12;
            label3.Text = "GESTION CULTIVO";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(670, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(367, 582);
            dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.HeaderText = "Finca";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Variedad";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Semilla";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Cosecha";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Fecha siembra";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel4.BackColor = Color.Honeydew;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblmapaop);
            panel4.Controls.Add(gMapAgroT);
            panel4.Location = new Point(339, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(334, 582);
            panel4.TabIndex = 11;
            panel4.Paint += panel4_Paint;
            // 
            // lblmapaop
            // 
            lblmapaop.AutoSize = true;
            lblmapaop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmapaop.ForeColor = Color.FromArgb(0, 64, 0);
            lblmapaop.Location = new Point(84, 19);
            lblmapaop.Name = "lblmapaop";
            lblmapaop.Size = new Size(157, 28);
            lblmapaop.TabIndex = 11;
            lblmapaop.Text = "Mapa Operativo";
            // 
            // gMapAgroT
            // 
            gMapAgroT.Bearing = 0F;
            gMapAgroT.CanDragMap = true;
            gMapAgroT.EmptyTileColor = Color.Navy;
            gMapAgroT.GrayScaleMode = false;
            gMapAgroT.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapAgroT.LevelsKeepInMemory = 5;
            gMapAgroT.Location = new Point(156, 277);
            gMapAgroT.MarkersEnabled = true;
            gMapAgroT.MaxZoom = 2;
            gMapAgroT.MinZoom = 2;
            gMapAgroT.MouseWheelZoomEnabled = true;
            gMapAgroT.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapAgroT.Name = "gMapAgroT";
            gMapAgroT.NegativeMode = false;
            gMapAgroT.PolygonsEnabled = true;
            gMapAgroT.RetryLoadTile = 0;
            gMapAgroT.RoutesEnabled = true;
            gMapAgroT.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapAgroT.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapAgroT.ShowTileGridLines = false;
            gMapAgroT.Size = new Size(10, 10);
            gMapAgroT.TabIndex = 11;
            gMapAgroT.Zoom = 0D;
            gMapAgroT.Load += gMapAgroT_Load;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.Honeydew;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panelcosechaes);
            panel1.Controls.Add(lblcose);
            panel1.Controls.Add(lblSemillav);
            panel1.Controls.Add(panelvaridadse);
            panel1.Controls.Add(panelterreno1);
            panel1.Controls.Add(lblterreno);
            panel1.Controls.Add(iconPictureBox2);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(lblRegistroSbra);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 582);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iconButton2.BackColor = Color.SpringGreen;
            iconButton2.ForeColor = Color.FromArgb(0, 64, 0);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(227, 443);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(109, 61);
            iconButton2.TabIndex = 12;
            iconButton2.Text = "Añadir Cultivo";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iconButton1.BackColor = Color.SpringGreen;
            iconButton1.ForeColor = Color.FromArgb(0, 64, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(227, 510);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(109, 61);
            iconButton1.TabIndex = 11;
            iconButton1.Text = "Guardar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.Wheat;
            panel2.Controls.Add(lbltitulo);
            panel2.Controls.Add(lblsemillas);
            panel2.Controls.Add(lblCal);
            panel2.Location = new Point(11, 467);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 111);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbltitulo.ForeColor = Color.FromArgb(0, 64, 0);
            lbltitulo.Location = new Point(11, 74);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(169, 20);
            lbltitulo.TabIndex = 12;
            lbltitulo.Text = "Stock de bodega: 460lb";
            // 
            // lblsemillas
            // 
            lblsemillas.AutoSize = true;
            lblsemillas.Enabled = false;
            lblsemillas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblsemillas.ForeColor = Color.FromArgb(0, 64, 0);
            lblsemillas.Location = new Point(11, 42);
            lblsemillas.Name = "lblsemillas";
            lblsemillas.Size = new Size(192, 20);
            lblsemillas.TabIndex = 11;
            lblsemillas.Text = "Semilla a Descontar: 202Lb";
            // 
            // lblCal
            // 
            lblCal.AutoSize = true;
            lblCal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCal.ForeColor = Color.FromArgb(0, 64, 0);
            lblCal.Location = new Point(3, 0);
            lblCal.Name = "lblCal";
            lblCal.Size = new Size(196, 23);
            lblCal.TabIndex = 10;
            lblCal.Text = "CALCULO AUTOMATICO";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 64, 0);
            label2.Location = new Point(34, 341);
            label2.Name = "label2";
            label2.Size = new Size(146, 23);
            label2.TabIndex = 10;
            label2.Text = "Fecha de Siembra";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(34, 367);
            panel3.Name = "panel3";
            panel3.Size = new Size(114, 0);
            panel3.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 255, 192);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(13, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 27);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panelcosechaes
            // 
            panelcosechaes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelcosechaes.Controls.Add(txtcosechaestim);
            panelcosechaes.Location = new Point(32, 277);
            panelcosechaes.Name = "panelcosechaes";
            panelcosechaes.Size = new Size(250, 0);
            panelcosechaes.TabIndex = 7;
            // 
            // txtcosechaestim
            // 
            txtcosechaestim.BackColor = Color.FromArgb(192, 255, 192);
            txtcosechaestim.BorderStyle = BorderStyle.FixedSingle;
            txtcosechaestim.Location = new Point(13, 3);
            txtcosechaestim.Name = "txtcosechaestim";
            txtcosechaestim.Size = new Size(222, 27);
            txtcosechaestim.TabIndex = 0;
            txtcosechaestim.TextAlign = HorizontalAlignment.Center;
            // 
            // lblcose
            // 
            lblcose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblcose.AutoSize = true;
            lblcose.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcose.ForeColor = Color.FromArgb(0, 64, 0);
            lblcose.Location = new Point(32, 251);
            lblcose.Name = "lblcose";
            lblcose.Size = new Size(148, 23);
            lblcose.TabIndex = 8;
            lblcose.Text = "Cosecha Estimada";
            // 
            // lblSemillav
            // 
            lblSemillav.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblSemillav.AutoSize = true;
            lblSemillav.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSemillav.ForeColor = Color.FromArgb(0, 64, 0);
            lblSemillav.Location = new Point(33, 170);
            lblSemillav.Name = "lblSemillav";
            lblSemillav.Size = new Size(158, 23);
            lblSemillav.TabIndex = 7;
            lblSemillav.Text = "Variedad de semilla";
            // 
            // panelvaridadse
            // 
            panelvaridadse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelvaridadse.Controls.Add(txtsemilava);
            panelvaridadse.Location = new Point(32, 193);
            panelvaridadse.Name = "panelvaridadse";
            panelvaridadse.Size = new Size(250, 0);
            panelvaridadse.TabIndex = 6;
            // 
            // txtsemilava
            // 
            txtsemilava.BackColor = Color.FromArgb(192, 255, 192);
            txtsemilava.BorderStyle = BorderStyle.FixedSingle;
            txtsemilava.Location = new Point(13, 3);
            txtsemilava.Name = "txtsemilava";
            txtsemilava.Size = new Size(222, 27);
            txtsemilava.TabIndex = 0;
            txtsemilava.TextAlign = HorizontalAlignment.Center;
            // 
            // panelterreno1
            // 
            panelterreno1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelterreno1.Controls.Add(txtterreno);
            panelterreno1.Location = new Point(32, 94);
            panelterreno1.Name = "panelterreno1";
            panelterreno1.Size = new Size(250, 0);
            panelterreno1.TabIndex = 5;
            // 
            // txtterreno
            // 
            txtterreno.BackColor = Color.FromArgb(192, 255, 192);
            txtterreno.BorderStyle = BorderStyle.FixedSingle;
            txtterreno.Location = new Point(13, 3);
            txtterreno.Name = "txtterreno";
            txtterreno.Size = new Size(222, 27);
            txtterreno.TabIndex = 0;
            txtterreno.TextAlign = HorizontalAlignment.Center;
            // 
            // lblterreno
            // 
            lblterreno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblterreno.AutoSize = true;
            lblterreno.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblterreno.ForeColor = Color.FromArgb(0, 64, 0);
            lblterreno.Location = new Point(32, 68);
            lblterreno.Name = "lblterreno";
            lblterreno.Size = new Size(67, 23);
            lblterreno.TabIndex = 4;
            lblterreno.Text = "Terreno";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Honeydew;
            iconPictureBox2.ForeColor = Color.FromArgb(0, 64, 0);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            iconPictureBox2.IconColor = Color.FromArgb(0, 64, 0);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 36;
            iconPictureBox2.Location = new Point(51, 11);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(36, 36);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            iconPictureBox2.TabIndex = 3;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Honeydew;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 12;
            iconPictureBox1.Location = new Point(32, 53);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(289, 12);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // lblRegistroSbra
            // 
            lblRegistroSbra.AutoSize = true;
            lblRegistroSbra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistroSbra.ForeColor = Color.FromArgb(0, 64, 0);
            lblRegistroSbra.Location = new Point(93, 11);
            lblRegistroSbra.Name = "lblRegistroSbra";
            lblRegistroSbra.Size = new Size(228, 28);
            lblRegistroSbra.TabIndex = 1;
            lblRegistroSbra.Text = "Registar Nueva Siembra";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 11);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // FrmCultivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 662);
            Controls.Add(paneldeCultivo);
            Name = "FrmCultivo";
            Text = "CULTIVO Y SIEMBRA";
            paneldeCultivo.ResumeLayout(false);
            paneldeCultivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelcosechaes.ResumeLayout(false);
            panelcosechaes.PerformLayout();
            panelvaridadse.ResumeLayout(false);
            panelvaridadse.PerformLayout();
            panelterreno1.ResumeLayout(false);
            panelterreno1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel paneldeCultivo;
        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lblRegistroSbra;
        private Panel panelterreno1;
        private TextBox txtterreno;
        private Label lblterreno;
        private Panel panelvaridadse;
        private TextBox txtsemilava;
        private Label lblSemillav;
        private Panel panel2;
        private Panel panelcosechaes;
        private TextBox txtcosechaestim;
        private Label lblcose;
        private Label lbltitulo;
        private Label lblsemillas;
        private Label lblCal;
        private Label label2;
        private Panel panel3;
        private TextBox textBox1;
        private Panel panel4;
        private GMap.NET.WindowsForms.GMapControl gMapAgroT;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label lblmapaop;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}