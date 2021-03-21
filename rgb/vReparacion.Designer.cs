namespace rgb
{
    partial class vReparacion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Agregar = new System.Windows.Forms.TabPage();
            this.gb_Reparacion = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_rFecha = new System.Windows.Forms.DateTimePicker();
            this.cb_rTipo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_rDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txt_rModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Agregar = new FontAwesome.Sharp.IconButton();
            this.txt_rDetalles = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dg_bCli = new System.Windows.Forms.GroupBox();
            this.txt_bClic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tp_multi = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chb_bfecha = new System.Windows.Forms.CheckBox();
            this.txt_bCedula = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.btn_vEliminar = new FontAwesome.Sharp.IconButton();
            this.btn_Buscar = new FontAwesome.Sharp.IconButton();
            this.txt_bNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_bCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_Busqueda = new System.Windows.Forms.DataGridView();
            this.btn_Validar = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.tabControl1.SuspendLayout();
            this.tp_Agregar.SuspendLayout();
            this.gb_Reparacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.dg_bCli.SuspendLayout();
            this.tp_multi.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Busqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_Agregar);
            this.tabControl1.Controls.Add(this.tp_multi);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1014, 582);
            this.tabControl1.TabIndex = 3;
            // 
            // tp_Agregar
            // 
            this.tp_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tp_Agregar.Controls.Add(this.gb_Reparacion);
            this.tp_Agregar.Controls.Add(this.dg_bCli);
            this.tp_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tp_Agregar.ForeColor = System.Drawing.Color.White;
            this.tp_Agregar.Location = new System.Drawing.Point(4, 25);
            this.tp_Agregar.Name = "tp_Agregar";
            this.tp_Agregar.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Agregar.Size = new System.Drawing.Size(1006, 553);
            this.tp_Agregar.TabIndex = 0;
            this.tp_Agregar.Text = "Agregar";
            // 
            // gb_Reparacion
            // 
            this.gb_Reparacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_Reparacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.gb_Reparacion.Controls.Add(this.label10);
            this.gb_Reparacion.Controls.Add(this.dtp_rFecha);
            this.gb_Reparacion.Controls.Add(this.cb_rTipo);
            this.gb_Reparacion.Controls.Add(this.label9);
            this.gb_Reparacion.Controls.Add(this.txt_rDesc);
            this.gb_Reparacion.Controls.Add(this.label6);
            this.gb_Reparacion.Controls.Add(this.iconPictureBox1);
            this.gb_Reparacion.Controls.Add(this.txt_rModelo);
            this.gb_Reparacion.Controls.Add(this.label3);
            this.gb_Reparacion.Controls.Add(this.btn_Agregar);
            this.gb_Reparacion.Controls.Add(this.txt_rDetalles);
            this.gb_Reparacion.Controls.Add(this.label4);
            this.gb_Reparacion.ForeColor = System.Drawing.Color.White;
            this.gb_Reparacion.Location = new System.Drawing.Point(8, 129);
            this.gb_Reparacion.Name = "gb_Reparacion";
            this.gb_Reparacion.Size = new System.Drawing.Size(990, 416);
            this.gb_Reparacion.TabIndex = 30;
            this.gb_Reparacion.TabStop = false;
            this.gb_Reparacion.Text = "Reparación";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(141, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Fecha";
            // 
            // dtp_rFecha
            // 
            this.dtp_rFecha.Location = new System.Drawing.Point(269, 347);
            this.dtp_rFecha.Name = "dtp_rFecha";
            this.dtp_rFecha.Size = new System.Drawing.Size(311, 26);
            this.dtp_rFecha.TabIndex = 22;
            // 
            // cb_rTipo
            // 
            this.cb_rTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rTipo.FormattingEnabled = true;
            this.cb_rTipo.Location = new System.Drawing.Point(633, 53);
            this.cb_rTipo.Name = "cb_rTipo";
            this.cb_rTipo.Size = new System.Drawing.Size(239, 28);
            this.cb_rTipo.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(576, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tipo";
            // 
            // txt_rDesc
            // 
            this.txt_rDesc.Location = new System.Drawing.Point(269, 208);
            this.txt_rDesc.Multiline = true;
            this.txt_rDesc.Name = "txt_rDesc";
            this.txt_rDesc.Size = new System.Drawing.Size(603, 95);
            this.txt_rDesc.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(141, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Descripción";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Screwdriver;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 103;
            this.iconPictureBox1.Location = new System.Drawing.Point(23, 37);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(103, 108);
            this.iconPictureBox1.TabIndex = 17;
            this.iconPictureBox1.TabStop = false;
            // 
            // txt_rModelo
            // 
            this.txt_rModelo.Location = new System.Drawing.Point(269, 52);
            this.txt_rModelo.Name = "txt_rModelo";
            this.txt_rModelo.Size = new System.Drawing.Size(273, 26);
            this.txt_rModelo.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(141, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Modelo";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_Agregar.FlatAppearance.BorderSize = 2;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.ForeColor = System.Drawing.Color.White;
            this.btn_Agregar.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.btn_Agregar.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Agregar.IconSize = 40;
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agregar.Location = new System.Drawing.Point(724, 338);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(148, 44);
            this.btn_Agregar.TabIndex = 15;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_rDetalles
            // 
            this.txt_rDetalles.Location = new System.Drawing.Point(269, 102);
            this.txt_rDetalles.Multiline = true;
            this.txt_rDetalles.Name = "txt_rDetalles";
            this.txt_rDetalles.Size = new System.Drawing.Size(603, 91);
            this.txt_rDetalles.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(141, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Detalles";
            // 
            // dg_bCli
            // 
            this.dg_bCli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_bCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.dg_bCli.Controls.Add(this.iconPictureBox2);
            this.dg_bCli.Controls.Add(this.btn_Validar);
            this.dg_bCli.Controls.Add(this.txt_bClic);
            this.dg_bCli.Controls.Add(this.label2);
            this.dg_bCli.ForeColor = System.Drawing.Color.White;
            this.dg_bCli.Location = new System.Drawing.Point(8, 6);
            this.dg_bCli.Name = "dg_bCli";
            this.dg_bCli.Size = new System.Drawing.Size(990, 100);
            this.dg_bCli.TabIndex = 29;
            this.dg_bCli.TabStop = false;
            this.dg_bCli.Text = "Cliente";
            // 
            // txt_bClic
            // 
            this.txt_bClic.Location = new System.Drawing.Point(314, 37);
            this.txt_bClic.Name = "txt_bClic";
            this.txt_bClic.Size = new System.Drawing.Size(288, 26);
            this.txt_bClic.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(203, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cedula";
            // 
            // tp_multi
            // 
            this.tp_multi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tp_multi.Controls.Add(this.groupBox2);
            this.tp_multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tp_multi.ForeColor = System.Drawing.Color.White;
            this.tp_multi.Location = new System.Drawing.Point(4, 25);
            this.tp_multi.Name = "tp_multi";
            this.tp_multi.Padding = new System.Windows.Forms.Padding(3);
            this.tp_multi.Size = new System.Drawing.Size(1006, 553);
            this.tp_multi.TabIndex = 1;
            this.tp_multi.Text = "Buscar/Eliminar";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.groupBox2.Controls.Add(this.chb_bfecha);
            this.groupBox2.Controls.Add(this.txt_bCedula);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dtp_fin);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtp_inicio);
            this.groupBox2.Controls.Add(this.btn_vEliminar);
            this.groupBox2.Controls.Add(this.btn_Buscar);
            this.groupBox2.Controls.Add(this.txt_bNombre);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_bCodigo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dgv_Busqueda);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(990, 504);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda";
            // 
            // chb_bfecha
            // 
            this.chb_bfecha.AutoSize = true;
            this.chb_bfecha.Location = new System.Drawing.Point(23, 146);
            this.chb_bfecha.Name = "chb_bfecha";
            this.chb_bfecha.Size = new System.Drawing.Size(160, 24);
            this.chb_bfecha.TabIndex = 30;
            this.chb_bfecha.Text = "Buscar por fecha";
            this.chb_bfecha.UseVisualStyleBackColor = true;
            // 
            // txt_bCedula
            // 
            this.txt_bCedula.Location = new System.Drawing.Point(575, 25);
            this.txt_bCedula.Name = "txt_bCedula";
            this.txt_bCedula.Size = new System.Drawing.Size(298, 26);
            this.txt_bCedula.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(477, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "Cedula";
            // 
            // dtp_fin
            // 
            this.dtp_fin.Location = new System.Drawing.Point(140, 240);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(311, 26);
            this.dtp_fin.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Fecha fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Fecha inicio";
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Location = new System.Drawing.Point(140, 194);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(311, 26);
            this.dtp_inicio.TabIndex = 24;
            // 
            // btn_vEliminar
            // 
            this.btn_vEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_vEliminar.Enabled = false;
            this.btn_vEliminar.FlatAppearance.BorderSize = 2;
            this.btn_vEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vEliminar.ForeColor = System.Drawing.Color.White;
            this.btn_vEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_vEliminar.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_vEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_vEliminar.IconSize = 40;
            this.btn_vEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_vEliminar.Location = new System.Drawing.Point(789, 167);
            this.btn_vEliminar.Name = "btn_vEliminar";
            this.btn_vEliminar.Size = new System.Drawing.Size(148, 44);
            this.btn_vEliminar.TabIndex = 15;
            this.btn_vEliminar.Text = "Eliminar";
            this.btn_vEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_vEliminar.UseVisualStyleBackColor = false;
            this.btn_vEliminar.Click += new System.EventHandler(this.btn_vEliminar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_Buscar.FlatAppearance.BorderSize = 2;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_Buscar.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Buscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Buscar.IconSize = 40;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Buscar.Location = new System.Drawing.Point(573, 167);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(148, 44);
            this.btn_Buscar.TabIndex = 15;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_bNombre
            // 
            this.txt_bNombre.Location = new System.Drawing.Point(140, 72);
            this.txt_bNombre.Name = "txt_bNombre";
            this.txt_bNombre.Size = new System.Drawing.Size(311, 26);
            this.txt_bNombre.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nombre";
            // 
            // txt_bCodigo
            // 
            this.txt_bCodigo.Location = new System.Drawing.Point(140, 25);
            this.txt_bCodigo.Name = "txt_bCodigo";
            this.txt_bCodigo.Size = new System.Drawing.Size(311, 26);
            this.txt_bCodigo.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(18, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Codigo";
            // 
            // dgv_Busqueda
            // 
            this.dgv_Busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Busqueda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.dgv_Busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Busqueda.Location = new System.Drawing.Point(6, 291);
            this.dgv_Busqueda.Name = "dgv_Busqueda";
            this.dgv_Busqueda.RowHeadersWidth = 51;
            this.dgv_Busqueda.RowTemplate.Height = 24;
            this.dgv_Busqueda.Size = new System.Drawing.Size(978, 207);
            this.dgv_Busqueda.TabIndex = 0;
            // 
            // btn_Validar
            // 
            this.btn_Validar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_Validar.FlatAppearance.BorderSize = 2;
            this.btn_Validar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Validar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btn_Validar.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Validar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Validar.IconSize = 30;
            this.btn_Validar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Validar.Location = new System.Drawing.Point(633, 27);
            this.btn_Validar.Name = "btn_Validar";
            this.btn_Validar.Size = new System.Drawing.Size(104, 36);
            this.btn_Validar.TabIndex = 19;
            this.btn_Validar.Text = "Validar";
            this.btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Validar.UseVisualStyleBackColor = false;
            this.btn_Validar.Click += new System.EventHandler(this.btn_Validar_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 70;
            this.iconPictureBox2.Location = new System.Drawing.Point(110, 20);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(87, 70);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox2.TabIndex = 20;
            this.iconPictureBox2.TabStop = false;
            // 
            // vReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1014, 582);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vReparacion";
            this.Text = "vReparacion";
            this.tabControl1.ResumeLayout(false);
            this.tp_Agregar.ResumeLayout(false);
            this.gb_Reparacion.ResumeLayout(false);
            this.gb_Reparacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.dg_bCli.ResumeLayout(false);
            this.dg_bCli.PerformLayout();
            this.tp_multi.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Busqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Agregar;
        private System.Windows.Forms.GroupBox gb_Reparacion;
        private System.Windows.Forms.TextBox txt_rModelo;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btn_Agregar;
        private System.Windows.Forms.TextBox txt_rDetalles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox dg_bCli;
        private System.Windows.Forms.TextBox txt_bClic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tp_multi;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btn_vEliminar;
        private FontAwesome.Sharp.IconButton btn_Buscar;
        private System.Windows.Forms.TextBox txt_bNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_bCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_Busqueda;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.ComboBox cb_rTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_rDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_rFecha;
        private System.Windows.Forms.TextBox txt_bCedula;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_fin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.CheckBox chb_bfecha;
        private FontAwesome.Sharp.IconButton btn_Validar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}