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
            panel3 = new Panel();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            BtnGuardarTerreno = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            panel2 = new Panel();
            label1 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
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
            panel1.Size = new Size(1191, 661);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(12, 470);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1167, 188);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(BtnGuardarTerreno);
            panel3.Location = new Point(510, 116);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(669, 313);
            panel3.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Cursor = Cursors.IBeam;
            textBox5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(603, 169);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(148, 29);
            textBox5.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.Hand;
            textBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(360, 169);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(148, 29);
            textBox3.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(360, 142);
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
            label7.Location = new Point(603, 142);
            label7.Name = "label7";
            label7.Size = new Size(83, 23);
            label7.TabIndex = 16;
            label7.Text = "Longitud";
            // 
            // textBox4
            // 
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(18, 169);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(148, 29);
            textBox4.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 142);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 10;
            label6.Text = "Ubicación";
            // 
            // textBox6
            // 
            textBox6.Cursor = Cursors.IBeam;
            textBox6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(603, 83);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(148, 29);
            textBox6.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.Hand;
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(360, 83);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(148, 29);
            textBox2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(360, 56);
            label4.Name = "label4";
            label4.Size = new Size(141, 23);
            label4.TabIndex = 8;
            label4.Text = "Area del terreno";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.IBeam;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(603, 56);
            label8.Name = "label8";
            label8.Size = new Size(63, 23);
            label8.TabIndex = 14;
            label8.Text = "Estado";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(18, 83);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 29);
            textBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 56);
            label3.Name = "label3";
            label3.Size = new Size(170, 23);
            label3.TabIndex = 6;
            label3.Text = "Nombre del terreno";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(0, 64, 0);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(669, 52);
            panel4.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 64, 0);
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(318, 12);
            label2.Name = "label2";
            label2.Size = new Size(211, 28);
            label2.TabIndex = 2;
            label2.Text = "Detalles del Terreno";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // BtnGuardarTerreno
            // 
            BtnGuardarTerreno.BackColor = Color.FromArgb(128, 255, 128);
            BtnGuardarTerreno.Cursor = Cursors.Hand;
            BtnGuardarTerreno.Dock = DockStyle.Bottom;
            BtnGuardarTerreno.FlatStyle = FlatStyle.Flat;
            BtnGuardarTerreno.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardarTerreno.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnGuardarTerreno.IconColor = Color.Black;
            BtnGuardarTerreno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardarTerreno.Location = new Point(0, 274);
            BtnGuardarTerreno.Margin = new Padding(3, 4, 3, 4);
            BtnGuardarTerreno.Name = "BtnGuardarTerreno";
            BtnGuardarTerreno.Size = new Size(669, 39);
            BtnGuardarTerreno.TabIndex = 4;
            BtnGuardarTerreno.Text = "Guardar terreno";
            BtnGuardarTerreno.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gMapControl1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(14, 85);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(454, 348);
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
            gMapControl1.Location = new Point(3, 29);
            gMapControl1.Margin = new Padding(3, 4, 3, 4);
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
            gMapControl1.Size = new Size(448, 315);
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
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1191, 61);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(249, 28);
            label1.TabIndex = 1;
            label1.Text = "GESTION DE TERRENOS ";
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre Terreno";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 130;
            // 
            // Column2
            // 
            Column2.HeaderText = "Area";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 130;
            // 
            // Column3
            // 
            Column3.HeaderText = "Estado";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 130;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ubicación ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 130;
            // 
            // Column5
            // 
            Column5.HeaderText = "Latitud";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 130;
            // 
            // Column6
            // 
            Column6.HeaderText = "Longitud";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 130;
            // 
            // FrmTerreno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 661);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmTerreno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTerreno";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}