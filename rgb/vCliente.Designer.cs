namespace rgb
{
    partial class vCliente
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
            this.gb_datosCliente = new System.Windows.Forms.GroupBox();
            this.btn_Agregar = new FontAwesome.Sharp.IconButton();
            this.txt_aCedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_aNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_aDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_aNombre = new System.Windows.Forms.TextBox();
            this.lbl_Datos = new System.Windows.Forms.Label();
            this.pb_Icon = new FontAwesome.Sharp.IconPictureBox();
            this.tp_multi = new System.Windows.Forms.TabPage();
            this.gb_Datos = new System.Windows.Forms.GroupBox();
            this.btn_Validar = new FontAwesome.Sharp.IconButton();
            this.btn_Actualizar = new FontAwesome.Sharp.IconButton();
            this.btn_Borrar = new FontAwesome.Sharp.IconButton();
            this.txt_dDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_dNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_dNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txt_dCedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_Busqueda = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new FontAwesome.Sharp.IconButton();
            this.txt_bNumero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_bCedula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_Busqueda = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tp_Agregar.SuspendLayout();
            this.gb_datosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).BeginInit();
            this.tp_multi.SuspendLayout();
            this.gb_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.gb_Busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Busqueda)).BeginInit();
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
            this.tabControl1.TabIndex = 0;
            // 
            // tp_Agregar
            // 
            this.tp_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tp_Agregar.Controls.Add(this.gb_datosCliente);
            this.tp_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tp_Agregar.ForeColor = System.Drawing.Color.White;
            this.tp_Agregar.Location = new System.Drawing.Point(4, 25);
            this.tp_Agregar.Name = "tp_Agregar";
            this.tp_Agregar.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Agregar.Size = new System.Drawing.Size(1006, 553);
            this.tp_Agregar.TabIndex = 0;
            this.tp_Agregar.Text = "Agregar";
            // 
            // gb_datosCliente
            // 
            this.gb_datosCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_datosCliente.Controls.Add(this.btn_Agregar);
            this.gb_datosCliente.Controls.Add(this.txt_aCedula);
            this.gb_datosCliente.Controls.Add(this.label4);
            this.gb_datosCliente.Controls.Add(this.txt_aNumero);
            this.gb_datosCliente.Controls.Add(this.label3);
            this.gb_datosCliente.Controls.Add(this.txt_aDir);
            this.gb_datosCliente.Controls.Add(this.label2);
            this.gb_datosCliente.Controls.Add(this.label1);
            this.gb_datosCliente.Controls.Add(this.txt_aNombre);
            this.gb_datosCliente.Controls.Add(this.lbl_Datos);
            this.gb_datosCliente.Controls.Add(this.pb_Icon);
            this.gb_datosCliente.Location = new System.Drawing.Point(31, 32);
            this.gb_datosCliente.Name = "gb_datosCliente";
            this.gb_datosCliente.Size = new System.Drawing.Size(942, 493);
            this.gb_datosCliente.TabIndex = 0;
            this.gb_datosCliente.TabStop = false;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_Agregar.FlatAppearance.BorderSize = 2;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_Agregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btn_Agregar.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Agregar.IconSize = 40;
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agregar.Location = new System.Drawing.Point(384, 424);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(148, 44);
            this.btn_Agregar.TabIndex = 24;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_aCedula
            // 
            this.txt_aCedula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_aCedula.Location = new System.Drawing.Point(653, 252);
            this.txt_aCedula.Name = "txt_aCedula";
            this.txt_aCedula.Size = new System.Drawing.Size(267, 26);
            this.txt_aCedula.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(648, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cedula";
            // 
            // txt_aNumero
            // 
            this.txt_aNumero.Location = new System.Drawing.Point(26, 252);
            this.txt_aNumero.Name = "txt_aNumero";
            this.txt_aNumero.Size = new System.Drawing.Size(267, 26);
            this.txt_aNumero.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(21, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Numero";
            // 
            // txt_aDir
            // 
            this.txt_aDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_aDir.Location = new System.Drawing.Point(26, 351);
            this.txt_aDir.Name = "txt_aDir";
            this.txt_aDir.Size = new System.Drawing.Size(894, 26);
            this.txt_aDir.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(21, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(211, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre del cliente";
            // 
            // txt_aNombre
            // 
            this.txt_aNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_aNombre.Location = new System.Drawing.Point(216, 124);
            this.txt_aNombre.Name = "txt_aNombre";
            this.txt_aNombre.Size = new System.Drawing.Size(704, 26);
            this.txt_aNombre.TabIndex = 14;
            // 
            // lbl_Datos
            // 
            this.lbl_Datos.AutoSize = true;
            this.lbl_Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Datos.Location = new System.Drawing.Point(211, 25);
            this.lbl_Datos.Name = "lbl_Datos";
            this.lbl_Datos.Size = new System.Drawing.Size(201, 29);
            this.lbl_Datos.TabIndex = 13;
            this.lbl_Datos.Text = "Datos del cliente";
            // 
            // pb_Icon
            // 
            this.pb_Icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pb_Icon.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.pb_Icon.IconColor = System.Drawing.Color.White;
            this.pb_Icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pb_Icon.IconSize = 162;
            this.pb_Icon.Location = new System.Drawing.Point(26, 25);
            this.pb_Icon.Name = "pb_Icon";
            this.pb_Icon.Size = new System.Drawing.Size(162, 164);
            this.pb_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Icon.TabIndex = 12;
            this.pb_Icon.TabStop = false;
            // 
            // tp_multi
            // 
            this.tp_multi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tp_multi.Controls.Add(this.gb_Datos);
            this.tp_multi.Controls.Add(this.gb_Busqueda);
            this.tp_multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tp_multi.ForeColor = System.Drawing.Color.White;
            this.tp_multi.Location = new System.Drawing.Point(4, 25);
            this.tp_multi.Name = "tp_multi";
            this.tp_multi.Padding = new System.Windows.Forms.Padding(3);
            this.tp_multi.Size = new System.Drawing.Size(1006, 553);
            this.tp_multi.TabIndex = 1;
            this.tp_multi.Text = "Buscar/Modificar/Eliminar";
            // 
            // gb_Datos
            // 
            this.gb_Datos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.gb_Datos.Controls.Add(this.btn_Validar);
            this.gb_Datos.Controls.Add(this.btn_Actualizar);
            this.gb_Datos.Controls.Add(this.btn_Borrar);
            this.gb_Datos.Controls.Add(this.txt_dDireccion);
            this.gb_Datos.Controls.Add(this.label8);
            this.gb_Datos.Controls.Add(this.txt_dNumero);
            this.gb_Datos.Controls.Add(this.label7);
            this.gb_Datos.Controls.Add(this.txt_dNombre);
            this.gb_Datos.Controls.Add(this.label6);
            this.gb_Datos.Controls.Add(this.iconPictureBox1);
            this.gb_Datos.Controls.Add(this.txt_dCedula);
            this.gb_Datos.Controls.Add(this.label5);
            this.gb_Datos.ForeColor = System.Drawing.Color.White;
            this.gb_Datos.Location = new System.Drawing.Point(597, 6);
            this.gb_Datos.Name = "gb_Datos";
            this.gb_Datos.Size = new System.Drawing.Size(401, 539);
            this.gb_Datos.TabIndex = 1;
            this.gb_Datos.TabStop = false;
            this.gb_Datos.Text = "Datos";
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
            this.btn_Validar.Location = new System.Drawing.Point(123, 30);
            this.btn_Validar.Name = "btn_Validar";
            this.btn_Validar.Size = new System.Drawing.Size(104, 36);
            this.btn_Validar.TabIndex = 18;
            this.btn_Validar.Text = "Validar";
            this.btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Validar.UseVisualStyleBackColor = false;
            this.btn_Validar.Click += new System.EventHandler(this.btn_Validar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_Actualizar.FlatAppearance.BorderSize = 2;
            this.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualizar.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_Actualizar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btn_Actualizar.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Actualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Actualizar.IconSize = 40;
            this.btn_Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Actualizar.Location = new System.Drawing.Point(31, 475);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(148, 44);
            this.btn_Actualizar.TabIndex = 17;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_Borrar.FlatAppearance.BorderSize = 2;
            this.btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Borrar.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_Borrar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_Borrar.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Borrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Borrar.IconSize = 40;
            this.btn_Borrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Borrar.Location = new System.Drawing.Point(205, 475);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(148, 44);
            this.btn_Borrar.TabIndex = 16;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Borrar.UseVisualStyleBackColor = false;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // txt_dDireccion
            // 
            this.txt_dDireccion.Location = new System.Drawing.Point(6, 352);
            this.txt_dDireccion.Multiline = true;
            this.txt_dDireccion.Name = "txt_dDireccion";
            this.txt_dDireccion.Size = new System.Drawing.Size(389, 70);
            this.txt_dDireccion.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(6, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Direccion";
            // 
            // txt_dNumero
            // 
            this.txt_dNumero.Location = new System.Drawing.Point(6, 261);
            this.txt_dNumero.Name = "txt_dNumero";
            this.txt_dNumero.Size = new System.Drawing.Size(389, 26);
            this.txt_dNumero.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(6, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Numero";
            // 
            // txt_dNombre
            // 
            this.txt_dNombre.Location = new System.Drawing.Point(6, 174);
            this.txt_dNombre.Name = "txt_dNombre";
            this.txt_dNombre.Size = new System.Drawing.Size(389, 26);
            this.txt_dNombre.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(6, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nombre del cliente";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 105;
            this.iconPictureBox1.Location = new System.Drawing.Point(257, 25);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(127, 105);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // txt_dCedula
            // 
            this.txt_dCedula.Location = new System.Drawing.Point(6, 74);
            this.txt_dCedula.Name = "txt_dCedula";
            this.txt_dCedula.Size = new System.Drawing.Size(221, 26);
            this.txt_dCedula.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cedula";
            // 
            // gb_Busqueda
            // 
            this.gb_Busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Busqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.gb_Busqueda.Controls.Add(this.btn_Buscar);
            this.gb_Busqueda.Controls.Add(this.txt_bNumero);
            this.gb_Busqueda.Controls.Add(this.label10);
            this.gb_Busqueda.Controls.Add(this.txt_bCedula);
            this.gb_Busqueda.Controls.Add(this.label9);
            this.gb_Busqueda.Controls.Add(this.dgv_Busqueda);
            this.gb_Busqueda.ForeColor = System.Drawing.Color.White;
            this.gb_Busqueda.Location = new System.Drawing.Point(8, 6);
            this.gb_Busqueda.Name = "gb_Busqueda";
            this.gb_Busqueda.Size = new System.Drawing.Size(573, 539);
            this.gb_Busqueda.TabIndex = 0;
            this.gb_Busqueda.TabStop = false;
            this.gb_Busqueda.Text = "Busqueda";
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
            this.btn_Buscar.Location = new System.Drawing.Point(194, 174);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(148, 44);
            this.btn_Buscar.TabIndex = 15;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_bNumero
            // 
            this.txt_bNumero.Location = new System.Drawing.Point(119, 93);
            this.txt_bNumero.Name = "txt_bNumero";
            this.txt_bNumero.Size = new System.Drawing.Size(378, 26);
            this.txt_bNumero.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(18, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Numero";
            // 
            // txt_bCedula
            // 
            this.txt_bCedula.Location = new System.Drawing.Point(119, 35);
            this.txt_bCedula.Name = "txt_bCedula";
            this.txt_bCedula.Size = new System.Drawing.Size(378, 26);
            this.txt_bCedula.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(18, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Cedula";
            // 
            // dgv_Busqueda
            // 
            this.dgv_Busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Busqueda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.dgv_Busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Busqueda.Location = new System.Drawing.Point(6, 261);
            this.dgv_Busqueda.Name = "dgv_Busqueda";
            this.dgv_Busqueda.RowHeadersWidth = 51;
            this.dgv_Busqueda.RowTemplate.Height = 24;
            this.dgv_Busqueda.Size = new System.Drawing.Size(561, 272);
            this.dgv_Busqueda.TabIndex = 0;
            this.dgv_Busqueda.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Busqueda_CellMouseClick);
            // 
            // vCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1014, 582);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vCliente";
            this.Text = "vCliente";
            this.tabControl1.ResumeLayout(false);
            this.tp_Agregar.ResumeLayout(false);
            this.gb_datosCliente.ResumeLayout(false);
            this.gb_datosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).EndInit();
            this.tp_multi.ResumeLayout(false);
            this.gb_Datos.ResumeLayout(false);
            this.gb_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.gb_Busqueda.ResumeLayout(false);
            this.gb_Busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Busqueda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Agregar;
        private System.Windows.Forms.TabPage tp_multi;
        private System.Windows.Forms.GroupBox gb_Datos;
        private System.Windows.Forms.TextBox txt_dDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_dNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_dNombre;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox txt_dCedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_Busqueda;
        private System.Windows.Forms.DataGridView dgv_Busqueda;
        private System.Windows.Forms.GroupBox gb_datosCliente;
        private System.Windows.Forms.TextBox txt_aCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_aNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_aDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_aNombre;
        private System.Windows.Forms.Label lbl_Datos;
        private FontAwesome.Sharp.IconPictureBox pb_Icon;
        private System.Windows.Forms.TextBox txt_bNumero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_bCedula;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btn_Agregar;
        private FontAwesome.Sharp.IconButton btn_Actualizar;
        private FontAwesome.Sharp.IconButton btn_Borrar;
        private FontAwesome.Sharp.IconButton btn_Buscar;
        private FontAwesome.Sharp.IconButton btn_Validar;
    }
}