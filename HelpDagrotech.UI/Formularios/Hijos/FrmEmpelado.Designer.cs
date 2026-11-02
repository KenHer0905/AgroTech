
using Microsoft.VisualBasic.ApplicationServices;

namespace HelpDagrotech.UI.Formularios
{
    partial class FrmEmpelado
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
            dgvlistadoEmpleado = new DataGridView();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel7 = new Panel();
            txtbuscaremplea = new TextBox();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            paneEmpleado = new Panel();
            panel1 = new Panel();
            BtnGuardarEmpleado = new FontAwesome.Sharp.IconButton();
            bttnborraremple = new FontAwesome.Sharp.IconButton();
            panel9 = new Panel();
            label2 = new Label();
            groupoempeladoi = new GroupBox();
            conEstado = new ComboBox();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            iconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            panel6 = new Panel();
            txtcontrasena = new TextBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            panel8 = new Panel();
            conRol = new ComboBox();
            ICONROL = new FontAwesome.Sharp.IconPictureBox();
            groupEmpleado = new GroupBox();
            panel2 = new Panel();
            txtNombreEmple = new TextBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            panel4 = new Panel();
            txttelefono = new TextBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            label4 = new Label();
            panel5 = new Panel();
            txtcedula = new TextBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            label6 = new Label();
            panel3 = new Panel();
            txtFechanacimiento = new DateTimePicker();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            label7 = new Label();
            btnEditarEmpleado = new FontAwesome.Sharp.IconButton();
            IconError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvlistadoEmpleado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            paneEmpleado.SuspendLayout();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            groupoempeladoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ICONROL).BeginInit();
            groupEmpleado.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconError).BeginInit();
            SuspendLayout();
            // 
            // dgvlistadoEmpleado
            // 
            dgvlistadoEmpleado.AllowUserToAddRows = false;
            dgvlistadoEmpleado.AllowUserToDeleteRows = false;
            dgvlistadoEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvlistadoEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlistadoEmpleado.Location = new Point(665, 71);
            dgvlistadoEmpleado.Margin = new Padding(3, 2, 3, 2);
            dgvlistadoEmpleado.Name = "dgvlistadoEmpleado";
            dgvlistadoEmpleado.ReadOnly = true;
            dgvlistadoEmpleado.RowHeadersWidth = 51;
            dgvlistadoEmpleado.Size = new Size(678, 904);
            dgvlistadoEmpleado.TabIndex = 1;
            dgvlistadoEmpleado.CellContentClick += dgvlistadoEmpleado_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(61, 36);
            label1.Name = "label1";
            label1.Size = new Size(276, 25);
            label1.TabIndex = 2;
            label1.Text = "Registro de Empleado";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(0, 64, 0);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(20, 26);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(192, 255, 192);
            panel7.Controls.Add(txtbuscaremplea);
            panel7.Controls.Add(iconPictureBox7);
            panel7.Location = new Point(708, 26);
            panel7.Name = "panel7";
            panel7.Size = new Size(435, 40);
            panel7.TabIndex = 8;
            // 
            // txtbuscaremplea
            // 
            txtbuscaremplea.BackColor = Color.FromArgb(192, 255, 192);
            txtbuscaremplea.Location = new Point(49, 8);
            txtbuscaremplea.Name = "txtbuscaremplea";
            txtbuscaremplea.PlaceholderText = "Buscar empleado";
            txtbuscaremplea.Size = new Size(369, 27);
            txtbuscaremplea.TabIndex = 1;
            txtbuscaremplea.TextChanged += txtbuscaremplea_TextChanged;
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
            // paneEmpleado
            // 
            paneEmpleado.BackColor = Color.FromArgb(0, 64, 0);
            paneEmpleado.Controls.Add(panel7);
            paneEmpleado.Controls.Add(iconPictureBox1);
            paneEmpleado.Controls.Add(label1);
            paneEmpleado.Controls.Add(dgvlistadoEmpleado);
            paneEmpleado.Controls.Add(panel1);
            paneEmpleado.Dock = DockStyle.Fill;
            paneEmpleado.Location = new Point(0, 0);
            paneEmpleado.Name = "paneEmpleado";
            paneEmpleado.Size = new Size(1343, 979);
            paneEmpleado.TabIndex = 0;
            paneEmpleado.Paint += paneEmpleado_Paint;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Honeydew;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BtnGuardarEmpleado);
            panel1.Controls.Add(bttnborraremple);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(groupoempeladoi);
            panel1.Controls.Add(groupEmpleado);
            panel1.Controls.Add(btnEditarEmpleado);
            panel1.Location = new Point(12, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(667, 904);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // BtnGuardarEmpleado
            // 
            BtnGuardarEmpleado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnGuardarEmpleado.BackColor = Color.FromArgb(0, 64, 0);
            BtnGuardarEmpleado.FlatAppearance.BorderSize = 0;
            BtnGuardarEmpleado.FlatStyle = FlatStyle.Flat;
            BtnGuardarEmpleado.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardarEmpleado.ForeColor = Color.White;
            BtnGuardarEmpleado.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardarEmpleado.IconColor = Color.White;
            BtnGuardarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardarEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardarEmpleado.Location = new Point(26, 733);
            BtnGuardarEmpleado.Margin = new Padding(3, 4, 3, 4);
            BtnGuardarEmpleado.Name = "BtnGuardarEmpleado";
            BtnGuardarEmpleado.Size = new Size(198, 81);
            BtnGuardarEmpleado.TabIndex = 13;
            BtnGuardarEmpleado.Text = "Guardar \r\ninformación";
            BtnGuardarEmpleado.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardarEmpleado.UseVisualStyleBackColor = false;
            BtnGuardarEmpleado.Click += BtnGuardarEmpleado_Click;
            BtnGuardarEmpleado.Paint += bttnborraremple_Paint;
            // 
            // bttnborraremple
            // 
            bttnborraremple.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bttnborraremple.BackColor = Color.FromArgb(0, 64, 0);
            bttnborraremple.FlatAppearance.BorderSize = 0;
            bttnborraremple.FlatStyle = FlatStyle.Flat;
            bttnborraremple.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnborraremple.ForeColor = Color.White;
            bttnborraremple.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            bttnborraremple.IconColor = Color.White;
            bttnborraremple.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bttnborraremple.ImageAlign = ContentAlignment.MiddleLeft;
            bttnborraremple.Location = new Point(424, 733);
            bttnborraremple.Margin = new Padding(3, 4, 3, 4);
            bttnborraremple.Name = "bttnborraremple";
            bttnborraremple.Size = new Size(184, 81);
            bttnborraremple.TabIndex = 17;
            bttnborraremple.Text = "Borrar \r\nInformación";
            bttnborraremple.TextAlign = ContentAlignment.MiddleRight;
            bttnborraremple.UseVisualStyleBackColor = false;
            bttnborraremple.Paint += bttnborraremple_Paint;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel9.BackColor = Color.Green;
            panel9.Controls.Add(label2);
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(665, 58);
            panel9.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 64, 0);
            label2.Location = new Point(239, 12);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 0;
            label2.Text = "DATOS DEL EMPLEADO";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupoempeladoi
            // 
            groupoempeladoi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupoempeladoi.BackColor = Color.Honeydew;
            groupoempeladoi.Controls.Add(conEstado);
            groupoempeladoi.Controls.Add(label5);
            groupoempeladoi.Controls.Add(label8);
            groupoempeladoi.Controls.Add(label9);
            groupoempeladoi.Controls.Add(iconPictureBox8);
            groupoempeladoi.Controls.Add(panel6);
            groupoempeladoi.Controls.Add(panel8);
            groupoempeladoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupoempeladoi.ForeColor = Color.Green;
            groupoempeladoi.Location = new Point(16, 371);
            groupoempeladoi.Name = "groupoempeladoi";
            groupoempeladoi.Size = new Size(562, 302);
            groupoempeladoi.TabIndex = 15;
            groupoempeladoi.TabStop = false;
            groupoempeladoi.Text = "INFORMACION DE TRABAJADOR ";
            // 
            // conEstado
            // 
            conEstado.FormattingEnabled = true;
            conEstado.Location = new Point(186, 40);
            conEstado.Margin = new Padding(3, 4, 3, 4);
            conEstado.Name = "conEstado";
            conEstado.Size = new Size(271, 31);
            conEstado.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(62, 39);
            label5.Name = "label5";
            label5.Size = new Size(65, 23);
            label5.TabIndex = 3;
            label5.Text = "Estado:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.Location = new Point(33, 92);
            label8.Name = "label8";
            label8.Size = new Size(101, 23);
            label8.TabIndex = 6;
            label8.Text = "Contraseña:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.Location = new Point(6, 157);
            label9.Name = "label9";
            label9.Size = new Size(130, 23);
            label9.TabIndex = 12;
            label9.Text = "Rol del Usuario:";
            // 
            // iconPictureBox8
            // 
            iconPictureBox8.BackColor = Color.Honeydew;
            iconPictureBox8.ForeColor = Color.Green;
            iconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            iconPictureBox8.IconColor = Color.Green;
            iconPictureBox8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox8.IconSize = 44;
            iconPictureBox8.Location = new Point(138, 28);
            iconPictureBox8.Name = "iconPictureBox8";
            iconPictureBox8.Size = new Size(358, 44);
            iconPictureBox8.TabIndex = 3;
            iconPictureBox8.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtcontrasena);
            panel6.Controls.Add(iconPictureBox5);
            panel6.Location = new Point(138, 82);
            panel6.Name = "panel6";
            panel6.Size = new Size(358, 42);
            panel6.TabIndex = 8;
            // 
            // txtcontrasena
            // 
            txtcontrasena.Location = new Point(46, 3);
            txtcontrasena.Name = "txtcontrasena";
            txtcontrasena.Size = new Size(273, 30);
            txtcontrasena.TabIndex = 12;
            txtcontrasena.TextChanged += txtcontrasena_TextChanged;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.Honeydew;
            iconPictureBox5.ForeColor = Color.Green;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            iconPictureBox5.IconColor = Color.Green;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 40;
            iconPictureBox5.Location = new Point(0, 0);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(40, 43);
            iconPictureBox5.TabIndex = 11;
            iconPictureBox5.TabStop = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(conRol);
            panel8.Controls.Add(ICONROL);
            panel8.Location = new Point(138, 145);
            panel8.Name = "panel8";
            panel8.Size = new Size(358, 44);
            panel8.TabIndex = 11;
            panel8.Paint += panel8_Paint;
            // 
            // conRol
            // 
            conRol.AutoCompleteCustomSource.AddRange(new string[] { "Admin" });
            conRol.FormattingEnabled = true;
            conRol.Location = new Point(46, 4);
            conRol.Margin = new Padding(3, 4, 3, 4);
            conRol.Name = "conRol";
            conRol.Size = new Size(273, 31);
            conRol.TabIndex = 14;
            conRol.SelectedIndexChanged += conRol_SelectedIndexChanged;
            // 
            // ICONROL
            // 
            ICONROL.BackColor = Color.Honeydew;
            ICONROL.ForeColor = Color.Green;
            ICONROL.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            ICONROL.IconColor = Color.Green;
            ICONROL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ICONROL.IconSize = 40;
            ICONROL.Location = new Point(0, 0);
            ICONROL.Name = "ICONROL";
            ICONROL.Size = new Size(40, 43);
            ICONROL.TabIndex = 12;
            ICONROL.TabStop = false;
            // 
            // groupEmpleado
            // 
            groupEmpleado.BackColor = Color.Honeydew;
            groupEmpleado.Controls.Add(panel2);
            groupEmpleado.Controls.Add(label3);
            groupEmpleado.Controls.Add(panel4);
            groupEmpleado.Controls.Add(label4);
            groupEmpleado.Controls.Add(panel5);
            groupEmpleado.Controls.Add(label6);
            groupEmpleado.Controls.Add(panel3);
            groupEmpleado.Controls.Add(label7);
            groupEmpleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupEmpleado.ForeColor = Color.Green;
            groupEmpleado.Location = new Point(16, 81);
            groupEmpleado.Name = "groupEmpleado";
            groupEmpleado.Size = new Size(562, 280);
            groupEmpleado.TabIndex = 2;
            groupEmpleado.TabStop = false;
            groupEmpleado.Text = "INFORMACION PERSONAL";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtNombreEmple);
            panel2.Controls.Add(iconPictureBox2);
            panel2.Location = new Point(114, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(382, 37);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // txtNombreEmple
            // 
            txtNombreEmple.Location = new Point(49, 8);
            txtNombreEmple.Name = "txtNombreEmple";
            txtNombreEmple.Size = new Size(294, 30);
            txtNombreEmple.TabIndex = 1;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Honeydew;
            iconPictureBox2.ForeColor = Color.Green;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox2.IconColor = Color.Green;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 40;
            iconPictureBox2.Location = new Point(0, 0);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(43, 40);
            iconPictureBox2.TabIndex = 0;
            iconPictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(4, 26);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 1;
            label3.Text = "Nombre:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txttelefono);
            panel4.Controls.Add(iconPictureBox3);
            panel4.Location = new Point(114, 82);
            panel4.Name = "panel4";
            panel4.Size = new Size(382, 37);
            panel4.TabIndex = 8;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(46, 8);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(297, 30);
            txttelefono.TabIndex = 2;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.Honeydew;
            iconPictureBox3.ForeColor = Color.Green;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.PhoneVolume;
            iconPictureBox3.IconColor = Color.Green;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 40;
            iconPictureBox3.Location = new Point(0, 0);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(40, 40);
            iconPictureBox3.TabIndex = 1;
            iconPictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(10, 82);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 2;
            label4.Text = "Telefóno:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtcedula);
            panel5.Controls.Add(iconPictureBox4);
            panel5.Location = new Point(114, 143);
            panel5.Name = "panel5";
            panel5.Size = new Size(382, 37);
            panel5.TabIndex = 9;
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(46, 8);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(297, 30);
            txtcedula.TabIndex = 11;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.Honeydew;
            iconPictureBox4.ForeColor = Color.Green;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            iconPictureBox4.IconColor = Color.Green;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 40;
            iconPictureBox4.Location = new Point(0, -3);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(40, 40);
            iconPictureBox4.TabIndex = 10;
            iconPictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(16, 154);
            label6.Name = "label6";
            label6.Size = new Size(63, 23);
            label6.TabIndex = 4;
            label6.Text = "Cédula";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtFechanacimiento);
            panel3.Controls.Add(iconPictureBox6);
            panel3.Location = new Point(114, 205);
            panel3.Name = "panel3";
            panel3.Size = new Size(382, 37);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
            // 
            // txtFechanacimiento
            // 
            txtFechanacimiento.Location = new Point(49, 6);
            txtFechanacimiento.Margin = new Padding(3, 4, 3, 4);
            txtFechanacimiento.Name = "txtFechanacimiento";
            txtFechanacimiento.Size = new Size(294, 30);
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
            label7.Location = new Point(16, 202);
            label7.Name = "label7";
            label7.Size = new Size(102, 46);
            label7.TabIndex = 5;
            label7.Text = "Fecha \r\nNacimiento:";
            // 
            // btnEditarEmpleado
            // 
            btnEditarEmpleado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditarEmpleado.BackColor = Color.OliveDrab;
            btnEditarEmpleado.FlatAppearance.BorderSize = 0;
            btnEditarEmpleado.FlatStyle = FlatStyle.Flat;
            btnEditarEmpleado.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarEmpleado.ForeColor = Color.White;
            btnEditarEmpleado.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            btnEditarEmpleado.IconColor = Color.White;
            btnEditarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarEmpleado.Location = new Point(230, 733);
            btnEditarEmpleado.Margin = new Padding(3, 4, 3, 4);
            btnEditarEmpleado.Name = "btnEditarEmpleado";
            btnEditarEmpleado.Size = new Size(177, 81);
            btnEditarEmpleado.TabIndex = 14;
            btnEditarEmpleado.Text = "Editar \r\nInformación";
            btnEditarEmpleado.TextAlign = ContentAlignment.MiddleRight;
            btnEditarEmpleado.UseVisualStyleBackColor = false;
            btnEditarEmpleado.Click += btnEditarEmpleado_Click;
            btnEditarEmpleado.Paint += bttnborraremple_Paint;
            // 
            // IconError
            // 
            IconError.ContainerControl = this;
            // 
            // FrmEmpelado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 979);
            Controls.Add(paneEmpleado);
            Name = "FrmEmpelado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empleado";
            WindowState = FormWindowState.Maximized;
            Load += FrmEmpelado_Load;
            Shown += FrmEmpelado_Shown;
            Paint += FrmEmpelado_Paint;
            ((System.ComponentModel.ISupportInitialize)dgvlistadoEmpleado).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            paneEmpleado.ResumeLayout(false);
            paneEmpleado.PerformLayout();
            panel1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            groupoempeladoi.ResumeLayout(false);
            groupoempeladoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ICONROL).EndInit();
            groupEmpleado.ResumeLayout(false);
            groupEmpleado.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconError).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvlistadoEmpleado;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel7;
        private TextBox txtbuscaremplea;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private Panel paneEmpleado;
        private Panel panel1;
        private ComboBox conEstado;
        private Panel panel6;
        private TextBox txtcontrasena;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Panel panel5;
        private TextBox txtcedula;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Panel panel4;
        private TextBox txttelefono;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private Panel panel2;
        private TextBox txtNombreEmple;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel8;
        private FontAwesome.Sharp.IconPictureBox ICONROL;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox8;
        private Label label9;
        private FontAwesome.Sharp.IconButton BtnGuardarEmpleado;
        private FontAwesome.Sharp.IconButton btnEditarEmpleado;
        private ErrorProvider IconError;
        private ComboBox conRol;
        private DateTimePicker txtFechanacimiento;
        private GroupBox groupEmpleado;
        private GroupBox groupoempeladoi;
        private Panel panel9;
        private FontAwesome.Sharp.IconButton bttnborraremple;
    }
}