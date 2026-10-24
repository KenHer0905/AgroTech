
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
            btnEditarEmpleado = new FontAwesome.Sharp.IconButton();
            BtnGuardarEmpleado = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            panel8 = new Panel();
            conRol = new ComboBox();
            iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            conEstado = new ComboBox();
            panel6 = new Panel();
            txtcontrasena = new TextBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            panel5 = new Panel();
            txtcedula = new TextBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            panel4 = new Panel();
            txttelefono = new TextBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            txtFechanacimiento = new DateTimePicker();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            txtNombreEmple = new TextBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            iconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            IconError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvlistadoEmpleado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            paneEmpleado.SuspendLayout();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconError).BeginInit();
            SuspendLayout();
            // 
            // dgvlistadoEmpleado
            // 
            dgvlistadoEmpleado.AllowUserToAddRows = false;
            dgvlistadoEmpleado.AllowUserToDeleteRows = false;
            dgvlistadoEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvlistadoEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlistadoEmpleado.Location = new Point(438, 75);
            dgvlistadoEmpleado.Margin = new Padding(3, 2, 3, 2);
            dgvlistadoEmpleado.Name = "dgvlistadoEmpleado";
            dgvlistadoEmpleado.ReadOnly = true;
            dgvlistadoEmpleado.RowHeadersWidth = 51;
            dgvlistadoEmpleado.Size = new Size(470, 452);
            dgvlistadoEmpleado.TabIndex = 1;
            dgvlistadoEmpleado.CellContentClick += dgvlistadoEmpleado_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(53, 27);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 2;
            label1.Text = "Registro De Empelado";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(0, 64, 0);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 30;
            iconPictureBox1.Location = new Point(18, 20);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(35, 30);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtbuscaremplea);
            panel7.Controls.Add(iconPictureBox7);
            panel7.Location = new Point(581, 20);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(284, 36);
            panel7.TabIndex = 8;
            // 
            // txtbuscaremplea
            // 
            txtbuscaremplea.BackColor = Color.FromArgb(0, 64, 0);
            txtbuscaremplea.Location = new Point(43, 6);
            txtbuscaremplea.Margin = new Padding(3, 2, 3, 2);
            txtbuscaremplea.Name = "txtbuscaremplea";
            txtbuscaremplea.PlaceholderText = "Buscar empleado";
            txtbuscaremplea.Size = new Size(227, 23);
            txtbuscaremplea.TabIndex = 1;
            txtbuscaremplea.TextChanged += txtbuscaremplea_TextChanged;
            // 
            // iconPictureBox7
            // 
            iconPictureBox7.BackColor = Color.FromArgb(0, 64, 0);
            iconPictureBox7.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox7.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox7.IconSize = 36;
            iconPictureBox7.Location = new Point(0, 0);
            iconPictureBox7.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(38, 36);
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
            paneEmpleado.Margin = new Padding(3, 2, 3, 2);
            paneEmpleado.Name = "paneEmpleado";
            paneEmpleado.Size = new Size(907, 527);
            paneEmpleado.TabIndex = 0;
            paneEmpleado.Paint += paneEmpleado_Paint;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.AutoSize = true;

            iconPictureBox1.BackColor = Color.FromArgb(0, 64, 0);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(20, 26);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(61, 36);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 2;
            label1.Text = "Registro De Empelado";
            // 
            // dataGridView1
            // 
            dgvlistadoEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvlistadoEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          
            dgvlistadoEmpleado.Location = new Point(500, 100);
            dgvlistadoEmpleado.Name = "dataGridView1";
            dgvlistadoEmpleado.RowHeadersWidth = 51;
            dgvlistadoEmpleado.Size = new Size(537, 491);
            dgvlistadoEmpleado.TabIndex = 1;
            // 
            //
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(btnEditarEmpleado);
            panel1.Controls.Add(BtnGuardarEmpleado);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(conEstado);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(iconPictureBox8);
            panel1.Location = new Point(0, 75);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 452);
            panel1.TabIndex = 0;
            // 
            // btnEditarEmpleado
            // 
            btnEditarEmpleado.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditarEmpleado.FlatStyle = FlatStyle.Popup;
            btnEditarEmpleado.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarEmpleado.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEditarEmpleado.IconColor = Color.Black;
            btnEditarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarEmpleado.Location = new Point(234, 379);
            btnEditarEmpleado.Name = "btnEditarEmpleado";
            btnEditarEmpleado.Size = new Size(148, 61);
            btnEditarEmpleado.TabIndex = 14;
            btnEditarEmpleado.Text = "Editar Información";
            btnEditarEmpleado.UseVisualStyleBackColor = true;
            btnEditarEmpleado.Click += btnEditarEmpleado_Click;
            // 
            // BtnGuardarEmpleado
            // 
            BtnGuardarEmpleado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnGuardarEmpleado.FlatStyle = FlatStyle.Popup;
            BtnGuardarEmpleado.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardarEmpleado.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnGuardarEmpleado.IconColor = Color.Black;
            BtnGuardarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardarEmpleado.Location = new Point(42, 379);
            BtnGuardarEmpleado.Name = "BtnGuardarEmpleado";
            BtnGuardarEmpleado.Size = new Size(148, 61);
            BtnGuardarEmpleado.TabIndex = 13;
            BtnGuardarEmpleado.Text = "Guardar información";
            BtnGuardarEmpleado.UseVisualStyleBackColor = true;
            BtnGuardarEmpleado.Click += BtnGuardarEmpleado_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 332);
            label9.Name = "label9";
            label9.Size = new Size(89, 15);
            label9.TabIndex = 12;
            label9.Text = "Rol del Usuario:";
            // 
            // panel8
            // 
            panel8.Controls.Add(conRol);
            panel8.Controls.Add(iconPictureBox9);
            panel8.Location = new Point(138, 325);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(262, 28);
            panel8.TabIndex = 11;
            // 
            // conRol
            // 
            conRol.AutoCompleteCustomSource.AddRange(new string[] { "Admin" });
            conRol.FormattingEnabled = true;
            conRol.Location = new Point(40, 3);
            conRol.Name = "conRol";
            conRol.Size = new Size(189, 23);
            conRol.TabIndex = 14;
            // 
            // iconPictureBox9
            // 
            iconPictureBox9.BackColor = Color.Honeydew;
            iconPictureBox9.ForeColor = SystemColors.ControlText;
            iconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            iconPictureBox9.IconColor = SystemColors.ControlText;
            iconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox9.Location = new Point(0, 0);
            iconPictureBox9.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox9.Name = "iconPictureBox9";
            iconPictureBox9.Size = new Size(35, 32);
            iconPictureBox9.TabIndex = 12;
            iconPictureBox9.TabStop = false;
            // 
            // conEstado
            // 
            conEstado.FormattingEnabled = true;
            conEstado.Location = new Point(178, 149);
            conEstado.Name = "conEstado";
            conEstado.Size = new Size(184, 23);
            conEstado.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtcontrasena);
            panel6.Controls.Add(iconPictureBox5);
            panel6.Location = new Point(138, 232);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(262, 28);
            panel6.TabIndex = 8;
            // 
            // txtcontrasena
            // 
            txtcontrasena.Location = new Point(43, 6);
            txtcontrasena.Margin = new Padding(3, 2, 3, 2);
            txtcontrasena.Name = "txtcontrasena";
            txtcontrasena.Size = new Size(184, 23);
            txtcontrasena.TabIndex = 12;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.Honeydew;
            iconPictureBox5.ForeColor = SystemColors.ControlText;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            iconPictureBox5.IconColor = SystemColors.ControlText;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.Location = new Point(0, 0);
            iconPictureBox5.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(35, 32);
            iconPictureBox5.TabIndex = 11;
            iconPictureBox5.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtcedula);
            panel5.Controls.Add(iconPictureBox4);
            panel5.Location = new Point(138, 185);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(262, 28);
            panel5.TabIndex = 9;
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(40, 6);
            txtcedula.Margin = new Padding(3, 2, 3, 2);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(184, 23);
            txtcedula.TabIndex = 11;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.Honeydew;
            iconPictureBox4.ForeColor = SystemColors.ControlText;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            iconPictureBox4.IconColor = SystemColors.ControlText;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 30;
            iconPictureBox4.Location = new Point(0, -2);
            iconPictureBox4.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(35, 30);
            iconPictureBox4.TabIndex = 10;
            iconPictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(txttelefono);
            panel4.Controls.Add(iconPictureBox3);
            panel4.Location = new Point(138, 102);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(262, 28);
            panel4.TabIndex = 8;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(40, 6);
            txttelefono.Margin = new Padding(3, 2, 3, 2);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(184, 23);
            txttelefono.TabIndex = 2;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.Honeydew;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.PhoneVolume;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 30;
            iconPictureBox3.Location = new Point(0, 0);
            iconPictureBox3.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(35, 30);
            iconPictureBox3.TabIndex = 1;
            iconPictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtFechanacimiento);
            panel3.Controls.Add(iconPictureBox6);
            panel3.Location = new Point(138, 274);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(262, 28);
            panel3.TabIndex = 8;
            // 
            // txtFechanacimiento
            // 
            txtFechanacimiento.Location = new Point(29, 3);
            txtFechanacimiento.Name = "txtFechanacimiento";
            txtFechanacimiento.Size = new Size(200, 23);
            txtFechanacimiento.TabIndex = 15;
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.Honeydew;
            iconPictureBox6.ForeColor = SystemColors.ControlText;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            iconPictureBox6.IconColor = SystemColors.ControlText;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.Location = new Point(0, 0);
            iconPictureBox6.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(35, 32);
            iconPictureBox6.TabIndex = 12;
            iconPictureBox6.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtNombreEmple);
            panel2.Controls.Add(iconPictureBox2);
            panel2.Location = new Point(138, 56);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 28);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // txtNombreEmple
            // 
            txtNombreEmple.Location = new Point(43, 6);
            txtNombreEmple.Margin = new Padding(3, 2, 3, 2);
            txtNombreEmple.Name = "txtNombreEmple";
            txtNombreEmple.Size = new Size(184, 23);
            txtNombreEmple.TabIndex = 1;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Honeydew;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 30;
            iconPictureBox2.Location = new Point(0, 0);
            iconPictureBox2.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(38, 30);
            iconPictureBox2.TabIndex = 0;
            iconPictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 245);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 6;
            label8.Text = "Contraseña:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 281);
            label7.Name = "label7";
            label7.Size = new Size(106, 15);
            label7.TabIndex = 5;
            label7.Text = "Fecha Nacimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 199);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 4;
            label6.Text = "Cédula";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 151);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 3;
            label5.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 102);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 2;
            label4.Text = "Telefóno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 56);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 1;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 64, 0);
            label2.Location = new Point(91, 7);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 0;
            label2.Text = "DATOS DEL EMPLEADO";
            // 
            // iconPictureBox8
            // 
            iconPictureBox8.BackColor = Color.Honeydew;
            iconPictureBox8.ForeColor = SystemColors.ControlText;
            iconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.PhoneVolume;
            iconPictureBox8.IconColor = SystemColors.ControlText;
            iconPictureBox8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox8.IconSize = 30;
            iconPictureBox8.Location = new Point(138, 142);
            iconPictureBox8.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox8.Name = "iconPictureBox8";
            iconPictureBox8.Size = new Size(262, 30);
            iconPictureBox8.TabIndex = 3;
            iconPictureBox8.TabStop = false;
            // 
            // IconError
            // 
            IconError.ContainerControl = this;
            // 
            // FrmEmpelado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 527);
            Controls.Add(paneEmpleado);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmEmpelado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empleado";
            WindowState = FormWindowState.Maximized;
            Load += FrmEmpelado_Load;

            ((System.ComponentModel.ISupportInitialize)dgvlistadoEmpleado).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();

            paneEmpleado.ResumeLayout(false);
            paneEmpleado.PerformLayout();

            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            paneEmpleado.ResumeLayout(false);
            paneEmpleado.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).EndInit();
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
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox8;
        private Label label9;
        private FontAwesome.Sharp.IconButton BtnGuardarEmpleado;
        private FontAwesome.Sharp.IconButton btnEditarEmpleado;
        private ErrorProvider IconError;
        private ComboBox conRol;
        private DateTimePicker txtFechanacimiento;
    }
}