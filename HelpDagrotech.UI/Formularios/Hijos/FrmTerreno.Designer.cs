namespace HelpDagrotech.UI.Formularios
{
    partial class FrmTerreno
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
            panel1 = new Panel();
            panel5 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtbuscarTerreno = new TextBox();
            DatagridTerreno = new DataGridView();
            panel3 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnEditarterreno = new FontAwesome.Sharp.IconButton();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label7 = new Label();
            txtlongi = new TextBox();
            txtlatitu = new TextBox();
            label6 = new Label();
            txtubica = new TextBox();
            groupBox2 = new GroupBox();
            conEstado = new ComboBox();
            label3 = new Label();
            txtterrenp = new TextBox();
            label4 = new Label();
            txtareat = new TextBox();
            label8 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            BtnGuardarTerreno = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            panel2 = new Panel();
            label1 = new Label();
            Iconerror = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DatagridTerreno).BeginInit();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Iconerror).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(DatagridTerreno);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1598, 931);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 255, 192);
            panel5.Controls.Add(iconPictureBox1);
            panel5.Controls.Add(txtbuscarTerreno);
            panel5.Location = new Point(22, 713);
            panel5.Name = "panel5";
            panel5.Size = new Size(471, 45);
            panel5.TabIndex = 9;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(192, 255, 192);
            iconPictureBox1.ForeColor = Color.FromArgb(0, 64, 0);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox1.IconColor = Color.FromArgb(0, 64, 0);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(3, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 9;
            iconPictureBox1.TabStop = false;
            // 
            // txtbuscarTerreno
            // 
            txtbuscarTerreno.BackColor = Color.FromArgb(192, 255, 192);
            txtbuscarTerreno.Cursor = Cursors.IBeam;
            txtbuscarTerreno.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbuscarTerreno.Location = new Point(49, 11);
            txtbuscarTerreno.Margin = new Padding(3, 5, 3, 5);
            txtbuscarTerreno.Name = "txtbuscarTerreno";
            txtbuscarTerreno.PlaceholderText = "Buscar Terreno";
            txtbuscarTerreno.Size = new Size(419, 29);
            txtbuscarTerreno.TabIndex = 8;
            txtbuscarTerreno.TextChanged += txtbuscarTerreno_TextChanged;
            // 
            // DatagridTerreno
            // 
            DatagridTerreno.AllowUserToAddRows = false;
            DatagridTerreno.AllowUserToDeleteRows = false;
            DatagridTerreno.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DatagridTerreno.BackgroundColor = Color.Honeydew;
            DatagridTerreno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DatagridTerreno.Location = new Point(16, 780);
            DatagridTerreno.Name = "DatagridTerreno";
            DatagridTerreno.ReadOnly = true;
            DatagridTerreno.RowHeadersWidth = 51;
            DatagridTerreno.Size = new Size(1554, 281);
            DatagridTerreno.TabIndex = 3;
            DatagridTerreno.CellClick += dataGridView1_CellContentClick;
            DatagridTerreno.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Honeydew;
            panel3.Controls.Add(iconButton2);
            panel3.Controls.Add(btnEditarterreno);
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(BtnGuardarTerreno);
            panel3.Location = new Point(783, 155);
            panel3.Margin = new Padding(3, 5, 3, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(841, 537);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(128, 64, 0);
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(495, 485);
            iconButton2.Margin = new Padding(3, 5, 3, 5);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(256, 52);
            iconButton2.TabIndex = 21;
            iconButton2.Text = "Borrar terreno";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // btnEditarterreno
            // 
            btnEditarterreno.BackColor = Color.FromArgb(0, 64, 0);
            btnEditarterreno.Cursor = Cursors.Hand;
            btnEditarterreno.FlatStyle = FlatStyle.Flat;
            btnEditarterreno.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarterreno.ForeColor = Color.White;
            btnEditarterreno.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            btnEditarterreno.IconColor = Color.White;
            btnEditarterreno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarterreno.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarterreno.Location = new Point(264, 485);
            btnEditarterreno.Margin = new Padding(3, 5, 3, 5);
            btnEditarterreno.Name = "btnEditarterreno";
            btnEditarterreno.Size = new Size(219, 52);
            btnEditarterreno.TabIndex = 20;
            btnEditarterreno.Text = "Editar terreno";
            btnEditarterreno.TextAlign = ContentAlignment.MiddleRight;
            btnEditarterreno.UseVisualStyleBackColor = false;
            btnEditarterreno.Click += btnEditarterreno_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtlongi);
            groupBox3.Controls.Add(txtlatitu);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtubica);
            groupBox3.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(21, 276);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(807, 179);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "UBICACION";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(343, 31);
            label5.Name = "label5";
            label5.Size = new Size(68, 23);
            label5.TabIndex = 12;
            label5.Text = "Latitud";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.IBeam;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(608, 31);
            label7.Name = "label7";
            label7.Size = new Size(83, 23);
            label7.TabIndex = 16;
            label7.Text = "Longitud";
            // 
            // txtlongi
            // 
            txtlongi.Cursor = Cursors.IBeam;
            txtlongi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtlongi.Location = new Point(608, 67);
            txtlongi.Margin = new Padding(3, 5, 3, 5);
            txtlongi.Name = "txtlongi";
            txtlongi.Size = new Size(169, 29);
            txtlongi.TabIndex = 17;
            txtlongi.TextChanged += textBox5_TextChanged;
            // 
            // txtlatitu
            // 
            txtlatitu.Cursor = Cursors.Hand;
            txtlatitu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtlatitu.Location = new Point(335, 67);
            txtlatitu.Margin = new Padding(3, 5, 3, 5);
            txtlatitu.Name = "txtlatitu";
            txtlatitu.Size = new Size(169, 29);
            txtlatitu.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 31);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 10;
            label6.Text = "Ubicación";
            // 
            // txtubica
            // 
            txtubica.Cursor = Cursors.IBeam;
            txtubica.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtubica.Location = new Point(27, 67);
            txtubica.Margin = new Padding(3, 5, 3, 5);
            txtubica.Name = "txtubica";
            txtubica.Size = new Size(169, 29);
            txtubica.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(conEstado);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtterrenp);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtareat);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(21, 79);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(807, 172);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "INFORMACION DEL TERRENO";
            // 
            // conEstado
            // 
            conEstado.FormattingEnabled = true;
            conEstado.Location = new Point(608, 78);
            conEstado.Name = "conEstado";
            conEstado.Size = new Size(169, 27);
            conEstado.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 40);
            label3.Name = "label3";
            label3.Size = new Size(170, 23);
            label3.TabIndex = 6;
            label3.Text = "Nombre del terreno";
            // 
            // txtterrenp
            // 
            txtterrenp.Cursor = Cursors.IBeam;
            txtterrenp.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtterrenp.Location = new Point(27, 76);
            txtterrenp.Margin = new Padding(3, 5, 3, 5);
            txtterrenp.Name = "txtterrenp";
            txtterrenp.Size = new Size(169, 29);
            txtterrenp.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(343, 40);
            label4.Name = "label4";
            label4.Size = new Size(141, 23);
            label4.TabIndex = 8;
            label4.Text = "Area del terreno";
            // 
            // txtareat
            // 
            txtareat.Cursor = Cursors.Hand;
            txtareat.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtareat.Location = new Point(343, 76);
            txtareat.Margin = new Padding(3, 5, 3, 5);
            txtareat.Name = "txtareat";
            txtareat.Size = new Size(169, 29);
            txtareat.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.IBeam;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(608, 40);
            label8.Name = "label8";
            label8.Size = new Size(63, 23);
            label8.TabIndex = 14;
            label8.Text = "Estado";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(0, 64, 0);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 5, 3, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(841, 69);
            panel4.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 64, 0);
            label2.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(313, 16);
            label2.Name = "label2";
            label2.Size = new Size(257, 22);
            label2.TabIndex = 2;
            label2.Text = "Detalles del Terreno";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // BtnGuardarTerreno
            // 
            BtnGuardarTerreno.BackColor = Color.Olive;
            BtnGuardarTerreno.Cursor = Cursors.Hand;
            BtnGuardarTerreno.FlatStyle = FlatStyle.Flat;
            BtnGuardarTerreno.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardarTerreno.ForeColor = Color.White;
            BtnGuardarTerreno.IconChar = FontAwesome.Sharp.IconChar.MapLocationDot;
            BtnGuardarTerreno.IconColor = Color.White;
            BtnGuardarTerreno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardarTerreno.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardarTerreno.Location = new Point(0, 485);
            BtnGuardarTerreno.Margin = new Padding(3, 5, 3, 5);
            BtnGuardarTerreno.Name = "BtnGuardarTerreno";
            BtnGuardarTerreno.Size = new Size(258, 52);
            BtnGuardarTerreno.TabIndex = 4;
            BtnGuardarTerreno.Text = "Guardar terreno";
            BtnGuardarTerreno.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardarTerreno.UseVisualStyleBackColor = false;
            BtnGuardarTerreno.Click += BtnGuardarTerreno_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gMapControl1);
            groupBox1.Font = new Font("Algerian", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(16, 113);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 5, 3, 5);
            groupBox1.Size = new Size(743, 579);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mapa del terreno";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.Dock = DockStyle.Fill;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(3, 36);
            gMapControl1.Margin = new Padding(3, 16, 3, 16);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 2;
            gMapControl1.MinZoom = 2;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.Name = "gMapControl1";
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RetryLoadTile = 0;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Size = new Size(737, 538);
            gMapControl1.TabIndex = 0;
            gMapControl1.Zoom = 0D;
            gMapControl1.Load += gMapControl1_Load;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 0);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 5, 3, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1598, 81);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 12);
            label1.Name = "label1";
            label1.Size = new Size(261, 25);
            label1.TabIndex = 1;
            label1.Text = "GESTION DE TERRENOS ";
            // 
            // Iconerror
            // 
            Iconerror.ContainerControl = this;
            // 
            // FrmTerreno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1598, 931);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmTerreno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTerreno";
            WindowState = FormWindowState.Maximized;
            Load += FrmTerreno_Load;
            Paint += FrmTerreno_Paint;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DatagridTerreno).EndInit();
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Iconerror).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
        private Label label1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton BtnGuardarTerreno;
        private Label label2;
        private Panel panel4;
        private Label label3;
        private TextBox txtterrenp;
        private TextBox txtareat;
        private Label label4;
        private DataGridView DatagridTerreno;
        private TextBox txtlatitu;
        private Label label5;
        private TextBox txtubica;
        private Label label6;
        private TextBox txtlongi;
        private Label label7;
        private Label label8;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnEditarterreno;
        private TextBox txtbuscarTerreno;
        private ComboBox conEstado;
        private ErrorProvider Iconerror;
        private Panel panel5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}