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
            panel3 = new Panel();
            textBox1 = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            BtnGuardarTerreno = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            panel2 = new Panel();
            label1 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1042, 496);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(BtnGuardarTerreno);
            panel3.Location = new Point(446, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(584, 235);
            panel3.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(16, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 25);
            textBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 42);
            label3.Name = "label3";
            label3.Size = new Size(130, 17);
            label3.TabIndex = 6;
            label3.Text = "Nombre del terreno";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(0, 64, 0);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(584, 39);
            panel4.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 64, 0);
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(278, 9);
            label2.Name = "label2";
            label2.Size = new Size(168, 21);
            label2.TabIndex = 2;
            label2.Text = "Detalles del Terreno";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // BtnGuardarTerreno
            // 
            BtnGuardarTerreno.BackColor = Color.FromArgb(128, 255, 128);
            BtnGuardarTerreno.Dock = DockStyle.Bottom;
            BtnGuardarTerreno.FlatStyle = FlatStyle.Flat;
            BtnGuardarTerreno.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardarTerreno.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnGuardarTerreno.IconColor = Color.Black;
            BtnGuardarTerreno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardarTerreno.Location = new Point(0, 206);
            BtnGuardarTerreno.Name = "BtnGuardarTerreno";
            BtnGuardarTerreno.Size = new Size(584, 29);
            BtnGuardarTerreno.TabIndex = 4;
            BtnGuardarTerreno.Text = "Guardar terreno";
            BtnGuardarTerreno.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gMapControl1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 261);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mapa del terreno";
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
            gMapControl1.Location = new Point(3, 23);
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
            gMapControl1.Size = new Size(391, 235);
            gMapControl1.TabIndex = 0;
            gMapControl1.Zoom = 0D;
            gMapControl1.Load += gMapControl1_Load;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1042, 46);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(198, 21);
            label1.TabIndex = 1;
            label1.Text = "GESTION DE TERRENOS ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(204, 42);
            label4.Name = "label4";
            label4.Size = new Size(108, 17);
            label4.TabIndex = 8;
            label4.Text = "Area del terreno";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(204, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 25);
            textBox2.TabIndex = 9;
            // 
            // FrmTerreno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 496);
            Controls.Add(panel1);
            Name = "FrmTerreno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTerreno";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
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
    }
}