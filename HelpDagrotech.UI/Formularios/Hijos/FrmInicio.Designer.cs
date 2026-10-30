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
            groupBox2 = new GroupBox();
            gMapAgroT = new GMap.NET.WindowsForms.GMapControl();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            txtSimebra = new DateTimePicker();
            CboxSemilla = new ComboBox();
            Cboxterreno = new ComboBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            buttregistrarcosecha = new FontAwesome.Sharp.IconButton();
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
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // paneldeCultivo
            // 
            paneldeCultivo.BackColor = Color.FromArgb(0, 64, 0);
            paneldeCultivo.Controls.Add(groupBox2);
            paneldeCultivo.Controls.Add(label3);
            paneldeCultivo.Controls.Add(dataGridView1);
            paneldeCultivo.Controls.Add(panel1);
            paneldeCultivo.Dock = DockStyle.Fill;
            paneldeCultivo.Location = new Point(0, 0);
            paneldeCultivo.Name = "paneldeCultivo";
            paneldeCultivo.Size = new Size(1402, 662);
            paneldeCultivo.TabIndex = 0;
            paneldeCultivo.Paint += paneldeCultivo_Paint;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Honeydew;
            groupBox2.Controls.Add(gMapAgroT);
            groupBox2.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(0, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(841, 461);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "CONTROL DE CULTIVO";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // gMapAgroT
            // 
            gMapAgroT.Bearing = 0F;
            gMapAgroT.CanDragMap = true;
            gMapAgroT.EmptyTileColor = Color.Navy;
            gMapAgroT.GrayScaleMode = false;
            gMapAgroT.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapAgroT.LevelsKeepInMemory = 5;
            gMapAgroT.Location = new Point(386, 211);
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
            gMapAgroT.Size = new Size(34, 23);
            gMapAgroT.TabIndex = 0;
            gMapAgroT.Zoom = 0D;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(49, 29);
            label3.Name = "label3";
            label3.Size = new Size(197, 25);
            label3.TabIndex = 12;
            label3.Text = "GESTION CULTIVO";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 541);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1399, 659);
            dataGridView1.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Honeydew;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(835, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 461);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtSimebra);
            groupBox1.Controls.Add(CboxSemilla);
            groupBox1.Controls.Add(Cboxterreno);
            groupBox1.Controls.Add(iconButton2);
            groupBox1.Controls.Add(iconButton3);
            groupBox1.Controls.Add(buttregistrarcosecha);
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
            groupBox1.Size = new Size(547, 384);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "REGISTRAR NUEVA SIEMBRA";
            // 
            // txtSimebra
            // 
            txtSimebra.Location = new Point(64, 308);
            txtSimebra.Margin = new Padding(3, 4, 3, 4);
            txtSimebra.Name = "txtSimebra";
            txtSimebra.Size = new Size(286, 34);
            txtSimebra.TabIndex = 18;
            // 
            // CboxSemilla
            // 
            CboxSemilla.FormattingEnabled = true;
            CboxSemilla.Location = new Point(64, 154);
            CboxSemilla.Name = "CboxSemilla";
            CboxSemilla.Size = new Size(251, 30);
            CboxSemilla.TabIndex = 17;
            // 
            // Cboxterreno
            // 
            Cboxterreno.FormattingEnabled = true;
            Cboxterreno.Location = new Point(64, 79);
            Cboxterreno.Name = "Cboxterreno";
            Cboxterreno.Size = new Size(251, 30);
            Cboxterreno.TabIndex = 16;
            Cboxterreno.SelectedIndexChanged += Cboxterreno_SelectedIndexChanged;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(0, 64, 0);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(388, 281);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(187, 58);
            iconButton2.TabIndex = 14;
            iconButton2.Text = "Reportar Cosecha";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iconButton3.BackColor = Color.Green;
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(401, 69);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(154, 58);
            iconButton3.TabIndex = 15;
            iconButton3.Text = "EDITAR";
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // buttregistrarcosecha
            // 
            buttregistrarcosecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttregistrarcosecha.BackColor = Color.FromArgb(255, 192, 128);
            buttregistrarcosecha.ForeColor = Color.FromArgb(255, 192, 192);
            buttregistrarcosecha.IconChar = FontAwesome.Sharp.IconChar.Add;
            buttregistrarcosecha.IconColor = Color.Black;
            buttregistrarcosecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttregistrarcosecha.IconSize = 20;
            buttregistrarcosecha.ImageAlign = ContentAlignment.MiddleLeft;
            buttregistrarcosecha.Location = new Point(351, 145);
            buttregistrarcosecha.Name = "buttregistrarcosecha";
            buttregistrarcosecha.Size = new Size(46, 34);
            buttregistrarcosecha.TabIndex = 14;
            buttregistrarcosecha.UseVisualStyleBackColor = false;
            buttregistrarcosecha.Click += buttregistrarcosecha_Click;
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.Honeydew;
            iconPictureBox6.ForeColor = Color.FromArgb(0, 192, 0);
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            iconPictureBox6.IconColor = Color.FromArgb(0, 192, 0);
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 34;
            iconPictureBox6.Location = new Point(18, 308);
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
            textBox1.Location = new Point(58, 302);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 53);
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
            iconPictureBox5.Location = new Point(18, 233);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(40, 34);
            iconPictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox5.TabIndex = 9;
            iconPictureBox5.TabStop = false;
            // 
            // bttGuardar
            // 
            bttGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bttGuardar.BackColor = Color.Green;
            bttGuardar.ForeColor = Color.White;
            bttGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            bttGuardar.IconColor = Color.White;
            bttGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bttGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            bttGuardar.Location = new Point(403, 172);
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
            txtcosechaestim.Location = new Point(58, 233);
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
            label2.Location = new Point(27, 281);
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
            iconPictureBox4.Location = new Point(18, 153);
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
            iconPictureBox3.Location = new Point(18, 79);
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
            lblterreno.Location = new Point(18, 53);
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
            lblSemillav.Location = new Point(18, 128);
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
            lblcose.Location = new Point(27, 207);
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
            ClientSize = new Size(1402, 662);
            Controls.Add(paneldeCultivo);
            Name = "FrmCultivo";
            Text = "SIEMBRA Y COSECHA";
            Load += FrmCultivo_Load;
            paneldeCultivo.ResumeLayout(false);
            paneldeCultivo.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton bttGuardar;
        private Label label3;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconButton buttregistrarcosecha;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private GroupBox groupBox2;
        private GMap.NET.WindowsForms.GMapControl gMapAgroT;
        private ComboBox CboxSemilla;
        private ComboBox Cboxterreno;
        private DateTimePicker txtSimebra;
        private ErrorProvider errorProvider1;
    }
}