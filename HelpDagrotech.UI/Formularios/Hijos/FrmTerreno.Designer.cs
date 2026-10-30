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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label7 = new Label();
            txtlongi = new TextBox();
            txtlatitu = new TextBox();
            label6 = new Label();
            txtubica = new TextBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            txtterrenp = new TextBox();
            label4 = new Label();
            txtareat = new TextBox();
            label8 = new Label();
            txtxet = new TextBox();
            panel4 = new Panel();
            label2 = new Label();
            BtnGuardarTerreno = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1426, 931);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Honeydew;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(16, 706);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1382, 101);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre Terreno";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Area";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Estado";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ubicación ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Latitud";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Longitud";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 130;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Honeydew;
            panel3.Controls.Add(iconButton2);
            panel3.Controls.Add(iconButton1);
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
            iconButton2.BackColor = Color.Green;
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
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(0, 64, 0);
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(264, 485);
            iconButton1.Margin = new Padding(3, 5, 3, 5);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(219, 52);
            iconButton1.TabIndex = 20;
            iconButton1.Text = "Editar terreno";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = false;
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
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtterrenp);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtareat);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtxet);
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
            // txtxet
            // 
            txtxet.Cursor = Cursors.IBeam;
            txtxet.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtxet.Location = new Point(608, 76);
            txtxet.Margin = new Padding(3, 5, 3, 5);
            txtxet.Name = "txtxet";
            txtxet.Size = new Size(169, 29);
            txtxet.TabIndex = 15;
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
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(313, 16);
            label2.Name = "label2";
            label2.Size = new Size(211, 28);
            label2.TabIndex = 2;
            label2.Text = "Detalles del Terreno";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // BtnGuardarTerreno
            // 
            BtnGuardarTerreno.BackColor = Color.Green;
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
            panel2.Size = new Size(1426, 81);
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
            // FrmTerreno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 931);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmTerreno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTerreno";
            WindowState = FormWindowState.Maximized;
            Paint += FrmTerreno_Paint;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private TextBox txtlatitu;
        private Label label5;
        private TextBox txtubica;
        private Label label6;
        private TextBox txtlongi;
        private Label label7;
        private TextBox txtxet;
        private Label label8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}