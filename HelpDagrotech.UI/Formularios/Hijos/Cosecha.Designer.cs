namespace HelpDagrotech.UI.Formularios.Hijos
{
    partial class Cosecha
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
            dvgCosecha = new DataGridView();
            panel5 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            txtfechainicio = new DateTimePicker();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            label7 = new Label();
            panel4 = new Panel();
            txtfechafinal = new DateTimePicker();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            panelbuscador = new Panel();
            txtCosecha = new TextBox();
            txtxbuscar = new TextBox();
            txtbuscador = new TextBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgCosecha).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panelbuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(dvgCosecha);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(5, 261);
            panel1.Name = "panel1";
            panel1.Size = new Size(1337, 726);
            panel1.TabIndex = 0;
            // 
            // dvgCosecha
            // 
            dvgCosecha.AllowUserToAddRows = false;
            dvgCosecha.AllowUserToDeleteRows = false;
            dvgCosecha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCosecha.Dock = DockStyle.Fill;
            dvgCosecha.Location = new Point(0, 95);
            dvgCosecha.Name = "dvgCosecha";
            dvgCosecha.ReadOnly = true;
            dvgCosecha.RowHeadersWidth = 51;
            dvgCosecha.Size = new Size(1337, 631);
            dvgCosecha.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 64, 0);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1337, 95);
            panel5.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(547, 31);
            label3.Name = "label3";
            label3.Size = new Size(212, 27);
            label3.TabIndex = 13;
            label3.Text = "COSECHA LISTAS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 0);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Algerian", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1343, 86);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 35);
            label1.Name = "label1";
            label1.Size = new Size(249, 25);
            label1.TabIndex = 0;
            label1.Text = "REPORTE DE COSECHA";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Green;
            panel3.Controls.Add(txtfechainicio);
            panel3.Controls.Add(iconPictureBox6);
            panel3.Location = new Point(129, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(382, 37);
            panel3.TabIndex = 10;
            // 
            // txtfechainicio
            // 
            txtfechainicio.Location = new Point(49, 6);
            txtfechainicio.Margin = new Padding(3, 4, 3, 4);
            txtfechainicio.Name = "txtfechainicio";
            txtfechainicio.Size = new Size(294, 27);
            txtfechainicio.TabIndex = 15;
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.Honeydew;
            iconPictureBox6.ForeColor = Color.Green;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            iconPictureBox6.IconColor = Color.Green;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 40;
            iconPictureBox6.Location = new Point(0, 0);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(40, 43);
            iconPictureBox6.TabIndex = 12;
            iconPictureBox6.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.Location = new Point(22, 112);
            label7.Name = "label7";
            label7.Size = new Size(101, 23);
            label7.TabIndex = 9;
            label7.Text = "Fecha Inicio";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Green;
            panel4.Controls.Add(txtfechafinal);
            panel4.Controls.Add(iconPictureBox1);
            panel4.Location = new Point(708, 106);
            panel4.Name = "panel4";
            panel4.Size = new Size(382, 37);
            panel4.TabIndex = 12;
            // 
            // txtfechafinal
            // 
            txtfechafinal.CalendarMonthBackground = Color.Green;
            txtfechafinal.Location = new Point(49, 6);
            txtfechafinal.Margin = new Padding(3, 4, 3, 4);
            txtfechafinal.Name = "txtfechafinal";
            txtfechafinal.Size = new Size(294, 27);
            txtfechafinal.TabIndex = 15;
            txtfechafinal.ValueChanged += txtfechafinal_ValueChanged;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Honeydew;
            iconPictureBox1.ForeColor = Color.Green;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            iconPictureBox1.IconColor = Color.Green;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(0, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 43);
            iconPictureBox1.TabIndex = 12;
            iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(606, 116);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 11;
            label2.Text = "Fecha Final";
            // 
            // panelbuscador
            // 
            panelbuscador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelbuscador.BackColor = Color.White;
            panelbuscador.BorderStyle = BorderStyle.FixedSingle;
            panelbuscador.Controls.Add(txtCosecha);
            panelbuscador.Controls.Add(txtxbuscar);
            panelbuscador.Controls.Add(txtbuscador);
            panelbuscador.Controls.Add(iconPictureBox2);
            panelbuscador.Location = new Point(43, 200);
            panelbuscador.Name = "panelbuscador";
            panelbuscador.Size = new Size(559, 40);
            panelbuscador.TabIndex = 6;
            // 
            // txtCosecha
            // 
            txtCosecha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCosecha.ForeColor = Color.Gray;
            txtCosecha.Location = new Point(49, 3);
            txtCosecha.Name = "txtCosecha";
            txtCosecha.PlaceholderText = "Busca Registro";
            txtCosecha.Size = new Size(489, 27);
            txtCosecha.TabIndex = 3;
            txtCosecha.TextAlign = HorizontalAlignment.Right;
            txtCosecha.TextChanged += txtCosecha_TextChanged;
            // 
            // txtxbuscar
            // 
            txtxbuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtxbuscar.ForeColor = Color.Gray;
            txtxbuscar.Location = new Point(49, -28);
            txtxbuscar.Name = "txtxbuscar";
            txtxbuscar.PlaceholderText = "Busca Registro";
            txtxbuscar.Size = new Size(846, 27);
            txtxbuscar.TabIndex = 2;
            txtxbuscar.TextAlign = HorizontalAlignment.Right;
            // 
            // txtbuscador
            // 
            txtbuscador.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbuscador.ForeColor = Color.Gray;
            txtbuscador.Location = new Point(46, -60);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.PlaceholderText = "Busca Registro";
            txtbuscador.Size = new Size(605, 27);
            txtbuscador.TabIndex = 1;
            txtbuscador.TextAlign = HorizontalAlignment.Right;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 36;
            iconPictureBox2.Location = new Point(3, 0);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(40, 36);
            iconPictureBox2.TabIndex = 0;
            iconPictureBox2.TabStop = false;
            // 
            // Cosecha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1343, 979);
            Controls.Add(panelbuscador);
            Controls.Add(panel4);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Cosecha";
            Text = "Cosecha";
            Load += Cosecha_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgCosecha).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panelbuscador.ResumeLayout(false);
            panelbuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private DateTimePicker txtfechainicio;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private Label label7;
        private Panel panel4;
        private DateTimePicker txtfechafinal;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
        private DataGridView dvgCosecha;
        private Panel panel5;
        private Label label3;
        private Panel panelbuscador;
        public TextBox txtxbuscar;
        public TextBox txtbuscador;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        public TextBox txtCosecha;
    }
}