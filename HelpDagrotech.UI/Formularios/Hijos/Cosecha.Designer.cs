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
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            txtFechanacimiento = new DateTimePicker();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            label7 = new Label();
            panel4 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Location = new Point(5, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(1337, 824);
            panel1.TabIndex = 0;
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
            panel3.Controls.Add(txtFechanacimiento);
            panel3.Controls.Add(iconPictureBox6);
            panel3.Location = new Point(129, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(382, 37);
            panel3.TabIndex = 10;
            // 
            // txtFechanacimiento
            // 
            txtFechanacimiento.Location = new Point(49, 6);
            txtFechanacimiento.Margin = new Padding(3, 4, 3, 4);
            txtFechanacimiento.Name = "txtFechanacimiento";
            txtFechanacimiento.Size = new Size(294, 27);
            txtFechanacimiento.TabIndex = 15;
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
            label7.Location = new Point(31, 103);
            label7.Name = "label7";
            label7.Size = new Size(102, 46);
            label7.TabIndex = 9;
            label7.Text = "Fecha \r\nNacimiento:";
            // 
            // panel4
            // 
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(iconPictureBox1);
            panel4.Location = new Point(708, 106);
            panel4.Name = "panel4";
            panel4.Size = new Size(382, 37);
            panel4.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(49, 6);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(294, 27);
            dateTimePicker1.TabIndex = 15;
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
            label2.Location = new Point(610, 103);
            label2.Name = "label2";
            label2.Size = new Size(102, 46);
            label2.TabIndex = 11;
            label2.Text = "Fecha \r\nNacimiento:";
            // 
            // Cosecha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 979);
            Controls.Add(panel4);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Cosecha";
            Text = "Cosecha";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private DateTimePicker txtFechanacimiento;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private Label label7;
        private Panel panel4;
        private DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
    }
}