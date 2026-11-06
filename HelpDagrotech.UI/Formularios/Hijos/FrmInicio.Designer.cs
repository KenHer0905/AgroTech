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
            components = new System.ComponentModel.Container();
            paneldeCultivo = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            panel9 = new Panel();
            txtbuscarSiembra = new TextBox();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            gmaip = new GroupBox();
            gMapAgroT = new GMap.NET.WindowsForms.GMapControl();
            dvgSiembralis = new DataGridView();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            label1 = new Label();
            txtSimebra = new DateTimePicker();
            CboxSemilla = new ComboBox();
            Cboxterreno = new ComboBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            bttEditar = new FontAwesome.Sharp.IconButton();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            textBox1 = new TextBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            bttGuardar = new FontAwesome.Sharp.IconButton();
            txtcosechaestim = new TextBox();
            label2 = new Label();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            lblterreno = new Label();
            lblSemillav = new Label();
            lblcose = new Label();
            errorProvider1 = new ErrorProvider(components);
            paneldeCultivo.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            gmaip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgSiembralis).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // paneldeCultivo
            // 
            paneldeCultivo.BackColor = Color.Honeydew;
            paneldeCultivo.Controls.Add(panel2);
            paneldeCultivo.Controls.Add(panel9);
            paneldeCultivo.Controls.Add(gmaip);
            paneldeCultivo.Controls.Add(dvgSiembralis);
            paneldeCultivo.Controls.Add(panel1);
            paneldeCultivo.Dock = DockStyle.Fill;
            paneldeCultivo.Location = new Point(0, 0);
            paneldeCultivo.Name = "paneldeCultivo";
            paneldeCultivo.Size = new Size(1575, 833);
            paneldeCultivo.TabIndex = 0;
            paneldeCultivo.Paint += paneldeCultivo_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 0);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1575, 94);
            panel2.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(61, 27);
            label3.Name = "label3";
            label3.Size = new Size(257, 34);
            label3.TabIndex = 12;
            label3.Text = "GESTION CULTIVO";
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel9.BackColor = Color.FromArgb(192, 255, 192);
            panel9.Controls.Add(txtbuscarSiembra);
            panel9.Controls.Add(iconPictureBox7);
            panel9.Location = new Point(12, 552);
            panel9.Name = "panel9";
            panel9.Size = new Size(457, 41);
            panel9.TabIndex = 14;
            // 
            // txtbuscarSiembra
            // 
            txtbuscarSiembra.BackColor = Color.FromArgb(192, 255, 192);
            txtbuscarSiembra.Location = new Point(49, 8);
            txtbuscarSiembra.Name = "txtbuscarSiembra";
            txtbuscarSiembra.PlaceholderText = "Buscar Cultivo";
            txtbuscarSiembra.Size = new Size(369, 27);
            txtbuscarSiembra.TabIndex = 1;
            txtbuscarSiembra.TextChanged += txtbuscarSiembra_TextChanged;
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
            // gmaip
            // 
            gmaip.BackColor = Color.Honeydew;
            gmaip.Controls.Add(gMapAgroT);
            gmaip.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gmaip.ForeColor = Color.Black;
            gmaip.Location = new Point(0, 96);
            gmaip.Name = "gmaip";
            gmaip.Size = new Size(841, 445);
            gmaip.TabIndex = 13;
            gmaip.TabStop = false;
            gmaip.Text = "CONTROL DE CULTIVO";
            gmaip.Enter += groupBox2_Enter;
            // 
            // gMapAgroT
            // 
            gMapAgroT.Bearing = 0F;
            gMapAgroT.CanDragMap = true;
            gMapAgroT.EmptyTileColor = Color.Navy;
            gMapAgroT.GrayScaleMode = false;
            gMapAgroT.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapAgroT.LevelsKeepInMemory = 5;
            gMapAgroT.Location = new Point(33, 32);
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
            gMapAgroT.Size = new Size(737, 411);
            gMapAgroT.TabIndex = 0;
            gMapAgroT.Zoom = 0D;
            gMapAgroT.OnPolygonClick += gMapAgroT_OnPolygonClick;
            gMapAgroT.Load += gMapAgroT_Load_1;
            // 
            // dvgSiembralis
            // 
            dvgSiembralis.AllowUserToAddRows = false;
            dvgSiembralis.AllowUserToDeleteRows = false;
            dvgSiembralis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgSiembralis.BackgroundColor = Color.Gray;
            dvgSiembralis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgSiembralis.GridColor = Color.Olive;
            dvgSiembralis.Location = new Point(0, 623);
            dvgSiembralis.Name = "dvgSiembralis";
            dvgSiembralis.ReadOnly = true;
            dvgSiembralis.RowHeadersWidth = 51;
            dvgSiembralis.Size = new Size(1572, 720);
            dvgSiembralis.TabIndex = 12;
            dvgSiembralis.CellClick += dataGridView1_CellContentClick;
            dvgSiembralis.CellContentClick += dataGridView1_CellContentClick;
            dvgSiembralis.Paint += dvgSiembralis_Paint;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Honeydew;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(835, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 445);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(txtSimebra);
            groupBox1.Controls.Add(CboxSemilla);
            groupBox1.Controls.Add(Cboxterreno);
            groupBox1.Controls.Add(iconButton2);
            groupBox1.Controls.Add(bttEditar);
            groupBox1.Controls.Add(iconPictureBox6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(iconPictureBox5);
            groupBox1.Controls.Add(bttGuardar);
            groupBox1.Controls.Add(txtcosechaestim);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(iconPictureBox4);
            groupBox1.Controls.Add(iconPictureBox3);
            groupBox1.Controls.Add(lblterreno);
            groupBox1.Controls.Add(lblSemillav);
            groupBox1.Controls.Add(lblcose);
            groupBox1.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(11, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(720, 441);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 64, 0);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(714, 74);
            panel3.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(190, 24);
            label1.Name = "label1";
            label1.Size = new Size(276, 24);
            label1.TabIndex = 13;
            label1.Text = "REGISTRA NUEVA SIEMBRA";
            // 
            // txtSimebra
            // 
            txtSimebra.Location = new Point(106, 369);
            txtSimebra.Margin = new Padding(3, 4, 3, 4);
            txtSimebra.Name = "txtSimebra";
            txtSimebra.Size = new Size(286, 34);
            txtSimebra.TabIndex = 18;
            // 
            // CboxSemilla
            // 
            CboxSemilla.FormattingEnabled = true;
            CboxSemilla.Location = new Point(87, 232);
            CboxSemilla.Name = "CboxSemilla";
            CboxSemilla.Size = new Size(305, 30);
            CboxSemilla.TabIndex = 17;
            CboxSemilla.SelectedIndexChanged += CboxSemilla_SelectedIndexChanged;
            // 
            // Cboxterreno
            // 
            Cboxterreno.FormattingEnabled = true;
            Cboxterreno.Location = new Point(87, 157);
            Cboxterreno.Name = "Cboxterreno";
            Cboxterreno.Size = new Size(305, 30);
            Cboxterreno.TabIndex = 16;
            Cboxterreno.SelectedIndexChanged += Cboxterreno_SelectedIndexChanged;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(128, 64, 0);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(447, 348);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(174, 58);
            iconButton2.TabIndex = 14;
            iconButton2.Text = "Reportar Cosecha";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // bttEditar
            // 
            bttEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bttEditar.BackColor = Color.Green;
            bttEditar.ForeColor = Color.White;
            bttEditar.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            bttEditar.IconColor = Color.White;
            bttEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bttEditar.ImageAlign = ContentAlignment.MiddleLeft;
            bttEditar.Location = new Point(467, 250);
            bttEditar.Name = "bttEditar";
            bttEditar.Size = new Size(154, 58);
            bttEditar.TabIndex = 15;
            bttEditar.Text = "EDITAR";
            bttEditar.TextAlign = ContentAlignment.MiddleRight;
            bttEditar.UseVisualStyleBackColor = false;
            bttEditar.Click += iconButton3_Click;
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.Honeydew;
            iconPictureBox6.ForeColor = Color.FromArgb(0, 192, 0);
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            iconPictureBox6.IconColor = Color.FromArgb(0, 192, 0);
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 34;
            iconPictureBox6.Location = new Point(41, 369);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(40, 34);
            iconPictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox6.TabIndex = 12;
            iconPictureBox6.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 255, 192);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(87, 369);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 34);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.Honeydew;
            iconPictureBox5.ForeColor = Color.FromArgb(0, 192, 0);
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            iconPictureBox5.IconColor = Color.FromArgb(0, 192, 0);
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 34;
            iconPictureBox5.Location = new Point(41, 294);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(40, 34);
            iconPictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox5.TabIndex = 9;
            iconPictureBox5.TabStop = false;
            // 
            // bttGuardar
            // 
            bttGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bttGuardar.BackColor = Color.Olive;
            bttGuardar.ForeColor = Color.White;
            bttGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            bttGuardar.IconColor = Color.White;
            bttGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bttGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            bttGuardar.Location = new Point(467, 158);
            bttGuardar.Name = "bttGuardar";
            bttGuardar.Size = new Size(154, 58);
            bttGuardar.TabIndex = 11;
            bttGuardar.Text = "Guardar";
            bttGuardar.TextAlign = ContentAlignment.MiddleRight;
            bttGuardar.UseVisualStyleBackColor = false;
            bttGuardar.Click += bttGuardar_Click;
            // 
            // txtcosechaestim
            // 
            txtcosechaestim.BackColor = Color.FromArgb(192, 255, 192);
            txtcosechaestim.BorderStyle = BorderStyle.FixedSingle;
            txtcosechaestim.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcosechaestim.Location = new Point(87, 303);
            txtcosechaestim.Name = "txtcosechaestim";
            txtcosechaestim.PlaceholderText = "Escriba la duracion determinada";
            txtcosechaestim.Size = new Size(311, 25);
            txtcosechaestim.TabIndex = 0;
            txtcosechaestim.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 64, 0);
            label2.Location = new Point(50, 349);
            label2.Name = "label2";
            label2.Size = new Size(146, 23);
            label2.TabIndex = 10;
            label2.Text = "Fecha de Siembra";
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.Honeydew;
            iconPictureBox4.ForeColor = Color.FromArgb(0, 192, 0);
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Pagelines;
            iconPictureBox4.IconColor = Color.FromArgb(0, 192, 0);
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 34;
            iconPictureBox4.Location = new Point(41, 231);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(40, 34);
            iconPictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox4.TabIndex = 2;
            iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.Honeydew;
            iconPictureBox3.ForeColor = Color.FromArgb(0, 192, 0);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.MapLocationDot;
            iconPictureBox3.IconColor = Color.FromArgb(0, 192, 0);
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 34;
            iconPictureBox3.Location = new Point(41, 157);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(40, 34);
            iconPictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox3.TabIndex = 1;
            iconPictureBox3.TabStop = false;
            // 
            // lblterreno
            // 
            lblterreno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblterreno.AutoSize = true;
            lblterreno.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblterreno.ForeColor = Color.FromArgb(0, 64, 0);
            lblterreno.Location = new Point(50, 130);
            lblterreno.Name = "lblterreno";
            lblterreno.Size = new Size(67, 23);
            lblterreno.TabIndex = 4;
            lblterreno.Text = "Terreno";
            // 
            // lblSemillav
            // 
            lblSemillav.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblSemillav.AutoSize = true;
            lblSemillav.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSemillav.ForeColor = Color.FromArgb(0, 64, 0);
            lblSemillav.Location = new Point(50, 194);
            lblSemillav.Name = "lblSemillav";
            lblSemillav.Size = new Size(229, 23);
            lblSemillav.TabIndex = 7;
            lblSemillav.Text = "Variedad de semilla (Cultivo)";
            // 
            // lblcose
            // 
            lblcose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblcose.AutoSize = true;
            lblcose.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcose.ForeColor = Color.FromArgb(0, 64, 0);
            lblcose.Location = new Point(50, 268);
            lblcose.Name = "lblcose";
            lblcose.Size = new Size(79, 23);
            lblcose.TabIndex = 8;
            lblcose.Text = "Duración";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmCultivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1575, 833);
            Controls.Add(paneldeCultivo);
            Name = "FrmCultivo";
            Text = "SIEMBRA Y COSECHA";
            Load += FrmCultivo_Load;
            Click += FrmCultivo_Click;
            paneldeCultivo.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            gmaip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgSiembralis).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel paneldeCultivo;
        private Panel panel1;
        private Label lblterreno;
        private Label lblSemillav;
        private TextBox txtcosechaestim;
        private Label lblcose;
        private Label label2;
        private TextBox textBox1;
        private DataGridView dvgSiembralis;
        private FontAwesome.Sharp.IconButton bttGuardar;
        private Label label3;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton bttEditar;
        private GroupBox gmaip;
        private GMap.NET.WindowsForms.GMapControl gMapAgroT;
        private ComboBox CboxSemilla;
        private ComboBox Cboxterreno;
        private DateTimePicker txtSimebra;
        private ErrorProvider errorProvider1;
        private Panel panel9;
        private TextBox txtbuscarSiembra;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
    }
}