namespace HelpDagrotech.UI.Formularios.BaseDatos
{
    partial class FrmBaseListado
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
            panelContenido = new Panel();
            Panelpaginas = new TableLayoutPanel();
            buttondespues = new FontAwesome.Sharp.IconButton();
            buttosiguiente = new FontAwesome.Sharp.IconButton();
            buttosegundo = new FontAwesome.Sharp.IconButton();
            lblpaginas = new Label();
            buttonprimero = new FontAwesome.Sharp.IconButton();
            lbltotalpaginas = new Label();
            icnpinbuscarregistro = new FontAwesome.Sharp.IconPictureBox();
            dgvListado = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttoneditar = new FontAwesome.Sharp.IconButton();
            buttonestados = new FontAwesome.Sharp.IconButton();
            buttonNuevo = new FontAwesome.Sharp.IconButton();
            panelbuscador = new Panel();
            txtbuscador = new TextBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label4 = new Label();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            panelContenido.SuspendLayout();
            Panelpaginas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icnpinbuscarregistro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panelbuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenido.BackColor = Color.White;
            panelContenido.Controls.Add(Panelpaginas);
            panelContenido.Controls.Add(icnpinbuscarregistro);
            panelContenido.Controls.Add(dgvListado);
            panelContenido.Controls.Add(iconPictureBox7);
            panelContenido.Controls.Add(label4);
            panelContenido.Controls.Add(tableLayoutPanel1);
            panelContenido.Controls.Add(panelbuscador);
            panelContenido.Controls.Add(pictureBox1);
            panelContenido.Controls.Add(label2);
            panelContenido.Controls.Add(label1);
            panelContenido.Controls.Add(iconPictureBox1);
            panelContenido.Location = new Point(12, 49);
            panelContenido.Name = "panelContenido";
            panelContenido.RightToLeft = RightToLeft.Yes;
            panelContenido.Size = new Size(1161, 671);
            panelContenido.TabIndex = 0;
            panelContenido.Paint += panelContenido_Paint;
            // 
            // Panelpaginas
            // 
            Panelpaginas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panelpaginas.BackColor = Color.Honeydew;
            Panelpaginas.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            Panelpaginas.ColumnCount = 6;
            Panelpaginas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 67F));
            Panelpaginas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            Panelpaginas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 166F));
            Panelpaginas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 164F));
            Panelpaginas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 82F));
            Panelpaginas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            Panelpaginas.Controls.Add(buttondespues, 3, 0);
            Panelpaginas.Controls.Add(buttosiguiente, 1, 0);
            Panelpaginas.Controls.Add(buttosegundo, 0, 0);
            Panelpaginas.Controls.Add(lblpaginas, 2, 0);
            Panelpaginas.Controls.Add(buttonprimero, 4, 0);
            Panelpaginas.Controls.Add(lbltotalpaginas, 5, 0);
            Panelpaginas.Location = new Point(29, 607);
            Panelpaginas.Name = "Panelpaginas";
            Panelpaginas.RowCount = 1;
            Panelpaginas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Panelpaginas.Size = new Size(1065, 47);
            Panelpaginas.TabIndex = 9;
            // 
            // buttondespues
            // 
            buttondespues.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttondespues.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            buttondespues.IconColor = Color.Black;
            buttondespues.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttondespues.Location = new Point(547, 4);
            buttondespues.Name = "buttondespues";
            buttondespues.Size = new Size(158, 39);
            buttondespues.TabIndex = 12;
            buttondespues.UseVisualStyleBackColor = true;
            buttondespues.Click += buttondespues_Click;
            // 
            // buttosiguiente
            // 
            buttosiguiente.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttosiguiente.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            buttosiguiente.IconColor = Color.Black;
            buttosiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttosiguiente.Location = new Point(879, 4);
            buttosiguiente.Name = "buttosiguiente";
            buttosiguiente.Size = new Size(114, 39);
            buttosiguiente.TabIndex = 11;
            buttosiguiente.UseVisualStyleBackColor = true;
            buttosiguiente.Click += buttosiguiente_Click;
            // 
            // buttosegundo
            // 
            buttosegundo.IconChar = FontAwesome.Sharp.IconChar.FastForward;
            buttosegundo.IconColor = Color.Black;
            buttosegundo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttosegundo.Location = new Point(1000, 4);
            buttosegundo.Name = "buttosegundo";
            buttosegundo.Size = new Size(61, 39);
            buttosegundo.TabIndex = 10;
            buttosegundo.UseVisualStyleBackColor = true;
            buttosegundo.Click += buttosegundo_Click;
            // 
            // lblpaginas
            // 
            lblpaginas.AutoSize = true;
            lblpaginas.ForeColor = Color.FromArgb(0, 64, 0);
            lblpaginas.Location = new Point(768, 1);
            lblpaginas.Name = "lblpaginas";
            lblpaginas.Size = new Size(104, 20);
            lblpaginas.TabIndex = 7;
            lblpaginas.Text = "Paginas 0 de 0";
            lblpaginas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonprimero
            // 
            buttonprimero.IconChar = FontAwesome.Sharp.IconChar.FastBackward;
            buttonprimero.IconColor = Color.Black;
            buttonprimero.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonprimero.Location = new Point(464, 4);
            buttonprimero.Name = "buttonprimero";
            buttonprimero.Size = new Size(76, 39);
            buttonprimero.TabIndex = 9;
            buttonprimero.UseVisualStyleBackColor = true;
            buttonprimero.Click += buttonprimero_Click;
            // 
            // lbltotalpaginas
            // 
            lbltotalpaginas.AutoSize = true;
            lbltotalpaginas.ForeColor = Color.FromArgb(0, 64, 0);
            lbltotalpaginas.Location = new Point(323, 1);
            lbltotalpaginas.Name = "lbltotalpaginas";
            lbltotalpaginas.Size = new Size(134, 20);
            lbltotalpaginas.TabIndex = 8;
            lbltotalpaginas.Text = "Total de paginas: 0";
            lbltotalpaginas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // icnpinbuscarregistro
            // 
            icnpinbuscarregistro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            icnpinbuscarregistro.BackColor = Color.White;
            icnpinbuscarregistro.BorderStyle = BorderStyle.FixedSingle;
            icnpinbuscarregistro.ForeColor = Color.FromArgb(0, 64, 0);
            icnpinbuscarregistro.IconChar = FontAwesome.Sharp.IconChar.Seedling;
            icnpinbuscarregistro.IconColor = Color.FromArgb(0, 64, 0);
            icnpinbuscarregistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icnpinbuscarregistro.IconSize = 430;
            icnpinbuscarregistro.Location = new Point(29, 151);
            icnpinbuscarregistro.Name = "icnpinbuscarregistro";
            icnpinbuscarregistro.Size = new Size(1116, 430);
            icnpinbuscarregistro.SizeMode = PictureBoxSizeMode.CenterImage;
            icnpinbuscarregistro.TabIndex = 8;
            icnpinbuscarregistro.TabStop = false;
            icnpinbuscarregistro.Click += icnpinbuscarregistro_Click;
            // 
            // dgvListado
            // 
            dgvListado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListado.BackgroundColor = Color.Honeydew;
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(29, 151);
            dgvListado.Name = "dgvListado";
            dgvListado.RowHeadersWidth = 51;
            dgvListado.Size = new Size(1065, 430);
            dgvListado.TabIndex = 7;
            dgvListado.CellFormatting += dgvListado_CellFormatting;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(buttoneditar, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonestados, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonNuevo, 2, 0);
            tableLayoutPanel1.Location = new Point(526, 85);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(619, 60);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // buttoneditar
            // 
            buttoneditar.ForeColor = Color.FromArgb(0, 64, 0);
            buttoneditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            buttoneditar.IconColor = Color.FromArgb(0, 64, 0);
            buttoneditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttoneditar.ImageAlign = ContentAlignment.MiddleRight;
            buttoneditar.Location = new Point(309, 3);
            buttoneditar.Name = "buttoneditar";
            buttoneditar.Size = new Size(101, 54);
            buttoneditar.TabIndex = 2;
            buttoneditar.Text = "Editar";
            buttoneditar.TextAlign = ContentAlignment.MiddleLeft;
            buttoneditar.UseVisualStyleBackColor = true;
            buttoneditar.Click += buttoneditar_Click;
            // 
            // buttonestados
            // 
            buttonestados.Anchor = AnchorStyles.Top;
            buttonestados.ForeColor = Color.FromArgb(0, 64, 0);
            buttonestados.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            buttonestados.IconColor = Color.FromArgb(0, 64, 0);
            buttonestados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonestados.ImageAlign = ContentAlignment.MiddleRight;
            buttonestados.Location = new Point(466, 3);
            buttonestados.Name = "buttonestados";
            buttonestados.Size = new Size(101, 54);
            buttonestados.TabIndex = 1;
            buttonestados.Text = "Estado";
            buttonestados.TextAlign = ContentAlignment.MiddleLeft;
            buttonestados.UseVisualStyleBackColor = true;
            buttonestados.Click += buttonestados_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.ForeColor = Color.FromArgb(0, 64, 0);
            buttonNuevo.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            buttonNuevo.IconColor = Color.FromArgb(0, 64, 0);
            buttonNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonNuevo.ImageAlign = ContentAlignment.MiddleRight;
            buttonNuevo.Location = new Point(101, 3);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(103, 54);
            buttonNuevo.TabIndex = 0;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.TextAlign = ContentAlignment.MiddleLeft;
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // panelbuscador
            // 
            panelbuscador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelbuscador.BorderStyle = BorderStyle.FixedSingle;
            panelbuscador.Controls.Add(txtbuscador);
            panelbuscador.Controls.Add(iconPictureBox2);
            panelbuscador.Location = new Point(42, 94);
            panelbuscador.Name = "panelbuscador";
            panelbuscador.Size = new Size(676, 40);
            panelbuscador.TabIndex = 5;
            // 
            // txtbuscador
            // 
            txtbuscador.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbuscador.ForeColor = Color.Gray;
            txtbuscador.Location = new Point(46, 2);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.PlaceholderText = "Busca Registro";
            txtbuscador.Size = new Size(625, 27);
            txtbuscador.TabIndex = 1;
            txtbuscador.TextAlign = HorizontalAlignment.Right;
            txtbuscador.TextChanged += txtbuscador_TextChanged;
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(29, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(820, 10);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(88, 49);
            label2.Name = "label2";
            label2.Size = new Size(265, 17);
            label2.TabIndex = 2;
            label2.Text = "Consulta, Admitracion y Gestione los regitro\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(88, 21);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 1;
            label1.Text = "Listado";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.FromArgb(0, 64, 0);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            iconPictureBox1.IconColor = Color.FromArgb(0, 64, 0);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 38;
            iconPictureBox1.Location = new Point(42, 28);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 38);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(0, 64, 0);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(156, 246);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 3;
            label4.Text = "Total Registro: 0";
            // 
            // iconPictureBox7
            // 
            iconPictureBox7.BackColor = Color.White;
            iconPictureBox7.ForeColor = SystemColors.ControlText;
            iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Notdef;
            iconPictureBox7.IconColor = SystemColors.ControlText;
            iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox7.IconSize = 40;
            iconPictureBox7.Location = new Point(696, 226);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(46, 40);
            iconPictureBox7.TabIndex = 5;
            iconPictureBox7.TabStop = false;
            // 
            // FrmBaseListado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(1185, 732);
            Controls.Add(panelContenido);
            Name = "FrmBaseListado";
            Text = "FrmBaseListado";
            Load += FrmBaseListado_Load;
            Shown += FrmBaseListado_Shown;
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            Panelpaginas.ResumeLayout(false);
            Panelpaginas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icnpinbuscarregistro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panelbuscador.ResumeLayout(false);
            panelbuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public Panel panelContenido;
        public Label label1;
        public Label label2;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panelbuscador;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        public TextBox txtbuscador;
        private TableLayoutPanel tableLayoutPanel1;
        public FontAwesome.Sharp.IconButton buttoneditar;
        public FontAwesome.Sharp.IconButton buttonestados;
        public FontAwesome.Sharp.IconButton buttonNuevo;
        private DataGridView dgvListado;
        private FontAwesome.Sharp.IconPictureBox icnpinbuscarregistro;
        private TableLayoutPanel Panelpaginas;
        public Label lbltotalpaginas;
        public Label lblpaginas;
        private FontAwesome.Sharp.IconButton buttondespues;
        private FontAwesome.Sharp.IconButton buttosiguiente;
        private FontAwesome.Sharp.IconButton buttosegundo;
        private FontAwesome.Sharp.IconButton buttonprimero;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private Label label4;
    }
}