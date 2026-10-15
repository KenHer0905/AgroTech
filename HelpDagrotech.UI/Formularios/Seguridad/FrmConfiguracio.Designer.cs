
namespace HelpDagrotech.UI.Formularios.Seguridad
{
    partial class FrmConfiguracio
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
            panelConfi = new Panel();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            Iccancelr = new FontAwesome.Sharp.IconButton();
            IcGuardar = new FontAwesome.Sharp.IconButton();
            icprobarcon = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            PinturexCerrar = new FontAwesome.Sharp.IconPictureBox();
            label6 = new Label();
            label5 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panelcontra = new Panel();
            txtContr = new TextBox();
            lblcont = new Label();
            panelUsuario = new Panel();
            txtUsuSQL = new TextBox();
            lblSqlUs = new Label();
            panelBDD = new Panel();
            txtBD = new TextBox();
            lblDB = new Label();
            panelServid = new Panel();
            txtSer = new TextBox();
            lblServidor = new Label();
            erroIcon = new ErrorProvider(components);
            panelConfi.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PinturexCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panelcontra.SuspendLayout();
            panelUsuario.SuspendLayout();
            panelBDD.SuspendLayout();
            panelServid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erroIcon).BeginInit();
            SuspendLayout();
            // 
            // panelConfi
            // 
            panelConfi.BackColor = Color.Honeydew;
            panelConfi.Controls.Add(panel2);
            panelConfi.Controls.Add(panel1);
            panelConfi.Controls.Add(panelcontra);
            panelConfi.Controls.Add(lblcont);
            panelConfi.Controls.Add(panelUsuario);
            panelConfi.Controls.Add(lblSqlUs);
            panelConfi.Controls.Add(panelBDD);
            panelConfi.Controls.Add(lblDB);
            panelConfi.Controls.Add(panelServid);
            panelConfi.Controls.Add(lblServidor);
            panelConfi.Dock = DockStyle.Fill;
            panelConfi.Location = new Point(0, 0);
            panelConfi.Name = "panelConfi";
            panelConfi.Size = new Size(482, 394);
            panelConfi.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 322);
            panel2.Name = "panel2";
            panel2.Size = new Size(482, 72);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.51634F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.48366F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
            tableLayoutPanel1.Controls.Add(Iccancelr, 2, 0);
            tableLayoutPanel1.Controls.Add(IcGuardar, 1, 0);
            tableLayoutPanel1.Controls.Add(icprobarcon, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(479, 69);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Iccancelr
            // 
            Iccancelr.ForeColor = Color.FromArgb(0, 64, 0);
            Iccancelr.IconChar = FontAwesome.Sharp.IconChar.Close;
            Iccancelr.IconColor = Color.Red;
            Iccancelr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Iccancelr.ImageAlign = ContentAlignment.MiddleLeft;
            Iccancelr.Location = new Point(357, 3);
            Iccancelr.Name = "Iccancelr";
            Iccancelr.Size = new Size(119, 54);
            Iccancelr.TabIndex = 2;
            Iccancelr.Text = "Cancelar";
            Iccancelr.TextAlign = ContentAlignment.MiddleRight;
            Iccancelr.UseVisualStyleBackColor = true;
            Iccancelr.Click += iccancelr_Click;
            // 
            // IcGuardar
            // 
            IcGuardar.Enabled = false;
            IcGuardar.ForeColor = Color.FromArgb(0, 64, 0);
            IcGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            IcGuardar.IconColor = Color.FromArgb(0, 64, 0);
            IcGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IcGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            IcGuardar.Location = new Point(207, 3);
            IcGuardar.Name = "IcGuardar";
            IcGuardar.Size = new Size(124, 54);
            IcGuardar.TabIndex = 1;
            IcGuardar.Text = "Guardar";
            IcGuardar.TextAlign = ContentAlignment.MiddleRight;
            IcGuardar.UseVisualStyleBackColor = true;
            IcGuardar.Click += IcGuardar_Click;
            // 
            // icprobarcon
            // 
            icprobarcon.BackColor = SystemColors.Window;
            icprobarcon.ForeColor = Color.FromArgb(0, 64, 0);
            icprobarcon.IconChar = FontAwesome.Sharp.IconChar.Server;
            icprobarcon.IconColor = Color.FromArgb(0, 64, 0);
            icprobarcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icprobarcon.IconSize = 40;
            icprobarcon.ImageAlign = ContentAlignment.MiddleLeft;
            icprobarcon.Location = new Point(3, 3);
            icprobarcon.Name = "icprobarcon";
            icprobarcon.Size = new Size(170, 54);
            icprobarcon.TabIndex = 0;
            icprobarcon.Text = "Probar Conexion";
            icprobarcon.TextAlign = ContentAlignment.MiddleRight;
            icprobarcon.UseVisualStyleBackColor = false;
            icprobarcon.Click += icprobarcon_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(PinturexCerrar);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 90);
            panel1.TabIndex = 4;
            // 
            // PinturexCerrar
            // 
            PinturexCerrar.BackColor = Color.Red;
            PinturexCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            PinturexCerrar.IconColor = Color.White;
            PinturexCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PinturexCerrar.IconSize = 28;
            PinturexCerrar.Location = new Point(438, 14);
            PinturexCerrar.Name = "PinturexCerrar";
            PinturexCerrar.Size = new Size(32, 28);
            PinturexCerrar.SizeMode = PictureBoxSizeMode.CenterImage;
            PinturexCerrar.TabIndex = 3;
            PinturexCerrar.TabStop = false;
            PinturexCerrar.Click += iconPictureBox2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(108, 37);
            label6.Name = "label6";
            label6.Size = new Size(174, 20);
            label6.TabIndex = 2;
            label6.Text = "Complete la información";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.FromArgb(0, 64, 0);
            label5.Location = new Point(89, 9);
            label5.Name = "label5";
            label5.Size = new Size(193, 28);
            label5.TabIndex = 1;
            label5.Text = "Conexion al Servidor";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.FromArgb(0, 64, 0);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Server;
            iconPictureBox1.IconColor = Color.FromArgb(0, 64, 0);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 55;
            iconPictureBox1.Location = new Point(19, 14);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(64, 55);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // panelcontra
            // 
            panelcontra.BackColor = Color.White;
            panelcontra.Controls.Add(txtContr);
            panelcontra.Location = new Point(134, 279);
            panelcontra.Name = "panelcontra";
            panelcontra.Size = new Size(285, 37);
            panelcontra.TabIndex = 3;
            // 
            // txtContr
            // 
            txtContr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContr.BorderStyle = BorderStyle.None;
            txtContr.Location = new Point(7, 10);
            txtContr.Multiline = true;
            txtContr.Name = "txtContr";
            txtContr.Size = new Size(275, 24);
            txtContr.TabIndex = 0;
            // 
            // lblcont
            // 
            lblcont.AutoSize = true;
            lblcont.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcont.ForeColor = Color.FromArgb(0, 64, 0);
            lblcont.Location = new Point(19, 287);
            lblcont.Name = "lblcont";
            lblcont.Size = new Size(99, 23);
            lblcont.TabIndex = 2;
            lblcont.Text = "Contraseña";
            // 
            // panelUsuario
            // 
            panelUsuario.BackColor = Color.White;
            panelUsuario.Controls.Add(txtUsuSQL);
            panelUsuario.Location = new Point(134, 226);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(285, 37);
            panelUsuario.TabIndex = 3;
            // 
            // txtUsuSQL
            // 
            txtUsuSQL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuSQL.BorderStyle = BorderStyle.None;
            txtUsuSQL.Location = new Point(7, 10);
            txtUsuSQL.Multiline = true;
            txtUsuSQL.Name = "txtUsuSQL";
            txtUsuSQL.Size = new Size(275, 24);
            txtUsuSQL.TabIndex = 0;
            // 
            // lblSqlUs
            // 
            lblSqlUs.AutoSize = true;
            lblSqlUs.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSqlUs.ForeColor = Color.FromArgb(0, 64, 0);
            lblSqlUs.Location = new Point(19, 234);
            lblSqlUs.Name = "lblSqlUs";
            lblSqlUs.Size = new Size(96, 23);
            lblSqlUs.TabIndex = 2;
            lblSqlUs.Text = "UsuarioSql";
            // 
            // panelBDD
            // 
            panelBDD.BackColor = Color.White;
            panelBDD.Controls.Add(txtBD);
            panelBDD.Location = new Point(134, 168);
            panelBDD.Name = "panelBDD";
            panelBDD.Size = new Size(285, 37);
            panelBDD.TabIndex = 3;
            // 
            // txtBD
            // 
            txtBD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBD.BorderStyle = BorderStyle.None;
            txtBD.Location = new Point(7, 10);
            txtBD.Multiline = true;
            txtBD.Name = "txtBD";
            txtBD.Size = new Size(275, 24);
            txtBD.TabIndex = 0;
            // 
            // lblDB
            // 
            lblDB.AutoSize = true;
            lblDB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDB.ForeColor = Color.FromArgb(0, 64, 0);
            lblDB.Location = new Point(6, 179);
            lblDB.Name = "lblDB";
            lblDB.Size = new Size(122, 23);
            lblDB.TabIndex = 2;
            lblDB.Text = "Base de Datos";
            // 
            // panelServid
            // 
            panelServid.BackColor = Color.White;
            panelServid.Controls.Add(txtSer);
            panelServid.Location = new Point(134, 121);
            panelServid.Name = "panelServid";
            panelServid.Size = new Size(285, 37);
            panelServid.TabIndex = 1;
            // 
            // txtSer
            // 
            txtSer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSer.BorderStyle = BorderStyle.None;
            txtSer.Location = new Point(7, 10);
            txtSer.Multiline = true;
            txtSer.Name = "txtSer";
            txtSer.Size = new Size(272, 24);
            txtSer.TabIndex = 0;
            txtSer.TextChanged += txtSer_TextChanged;
            // 
            // lblServidor
            // 
            lblServidor.AutoSize = true;
            lblServidor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblServidor.ForeColor = Color.FromArgb(0, 64, 0);
            lblServidor.Location = new Point(34, 121);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(84, 23);
            lblServidor.TabIndex = 0;
            lblServidor.Text = "Servidor ";
            // 
            // erroIcon
            // 
            erroIcon.ContainerControl = this;
            // 
            // FrmConfiguracio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 394);
            Controls.Add(panelConfi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConfiguracio";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmConfiguracio_Load;
            Shown += FrmConfiguracio_Shown;
            panelConfi.ResumeLayout(false);
            panelConfi.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PinturexCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panelcontra.ResumeLayout(false);
            panelcontra.PerformLayout();
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            panelBDD.ResumeLayout(false);
            panelBDD.PerformLayout();
            panelServid.ResumeLayout(false);
            panelServid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erroIcon).EndInit();
            ResumeLayout(false);
        }



        private void iccancelr_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        #endregion

        private Panel panelConfi;
        private Panel panelServid;
        private Label lblServidor;
        private Panel panelcontra;
        private TextBox txtContr;
        private Label lblcont;
        private Panel panelUsuario;
        private TextBox txtUsuSQL;
        private Label lblSqlUs;
        private Panel panelBDD;
        private TextBox txtBD;
        private Label lblDB;
        private TextBox txtSer;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label6;
        private Label label5;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox PinturexCerrar;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton Iccancelr;
        private FontAwesome.Sharp.IconButton IcGuardar;
        private FontAwesome.Sharp.IconButton icprobarcon;
        private ErrorProvider erroIcon;
    }
}