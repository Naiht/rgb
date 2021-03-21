namespace rgb
{
    partial class vVentas
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
            this.gb_Ventas = new System.Windows.Forms.GroupBox();
            this.txt_Venc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Vender = new FontAwesome.Sharp.IconButton();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Venta = new System.Windows.Forms.DataGridView();
            this.dg_bProd = new System.Windows.Forms.GroupBox();
            this.btn_bProd = new FontAwesome.Sharp.IconButton();
            this.txt_bProdn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bProdc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_bProd = new System.Windows.Forms.DataGridView();
            this.tp_multi = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_ptotal = new System.Windows.Forms.Label();
            this.lbl_Ncliente = new System.Windows.Forms.Label();
            this.dgv_Ventab = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_vEliminar = new FontAwesome.Sharp.IconButton();
            this.btn_Buscar = new FontAwesome.Sharp.IconButton();
            this.txt_bNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_bCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_Busqueda = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tp_Agregar.SuspendLayout();
            this.gb_Ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Venta)).BeginInit();
            this.dg_bProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bProd)).BeginInit();
            this.tp_multi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ventab)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.tabControl1.TabIndex = 2;
            // 
            // tp_Agregar
            // 
            this.tp_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tp_Agregar.Controls.Add(this.gb_Ventas);
            this.tp_Agregar.Controls.Add(this.dg_bProd);
            this.tp_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tp_Agregar.ForeColor = System.Drawing.Color.White;
            this.tp_Agregar.Location = new System.Drawing.Point(4, 25);
            this.tp_Agregar.Name = "tp_Agregar";
            this.tp_Agregar.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Agregar.Size = new System.Drawing.Size(1006, 553);
            this.tp_Agregar.TabIndex = 0;
            this.tp_Agregar.Text = "Agregar";
            // 
            // gb_Ventas
            // 
            this.gb_Ventas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_Ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.gb_Ventas.Controls.Add(this.txt_Venc);
            this.gb_Ventas.Controls.Add(this.label3);
            this.gb_Ventas.Controls.Add(this.btn_Vender);
            this.gb_Ventas.Controls.Add(this.txt_Total);
            this.gb_Ventas.Controls.Add(this.label4);
            this.gb_Ventas.Controls.Add(this.dgv_Venta);
            this.gb_Ventas.ForeColor = System.Drawing.Color.White;
            this.gb_Ventas.Location = new System.Drawing.Point(8, 274);
            this.gb_Ventas.Name = "gb_Ventas";
            this.gb_Ventas.Size = new System.Drawing.Size(990, 271);
            this.gb_Ventas.TabIndex = 30;
            this.gb_Ventas.TabStop = false;
            this.gb_Ventas.Text = "Venta";
            // 
            // txt_Venc
            // 
            this.txt_Venc.Location = new System.Drawing.Point(707, 48);
            this.txt_Venc.Name = "txt_Venc";
            this.txt_Venc.Size = new System.Drawing.Size(273, 26);
            this.txt_Venc.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(626, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cliente:";
            // 
            // btn_Vender
            // 
            this.btn_Vender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_Vender.FlatAppearance.BorderSize = 2;
            this.btn_Vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Vender.ForeColor = System.Drawing.Color.White;
            this.btn_Vender.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btn_Vender.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Vender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Vender.IconSize = 40;
            this.btn_Vender.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Vender.Location = new System.Drawing.Point(736, 178);
            this.btn_Vender.Name = "btn_Vender";
            this.btn_Vender.Size = new System.Drawing.Size(148, 44);
            this.btn_Vender.TabIndex = 15;
            this.btn_Vender.Text = "Vender";
            this.btn_Vender.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Vender.UseVisualStyleBackColor = false;
            this.btn_Vender.Click += new System.EventHandler(this.btn_Vender_Click);
            // 
            // txt_Total
            // 
            this.txt_Total.Enabled = false;
            this.txt_Total.Location = new System.Drawing.Point(782, 112);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(152, 26);
            this.txt_Total.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(662, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio total:";
            // 
            // dgv_Venta
            // 
            this.dgv_Venta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Venta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.dgv_Venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Venta.Location = new System.Drawing.Point(8, 25);
            this.dgv_Venta.Name = "dgv_Venta";
            this.dgv_Venta.RowHeadersWidth = 51;
            this.dgv_Venta.RowTemplate.Height = 24;
            this.dgv_Venta.Size = new System.Drawing.Size(614, 240);
            this.dgv_Venta.TabIndex = 0;
            this.dgv_Venta.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Venta_CellMouseDoubleClick);
            // 
            // dg_bProd
            // 
            this.dg_bProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_bProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.dg_bProd.Controls.Add(this.btn_bProd);
            this.dg_bProd.Controls.Add(this.txt_bProdn);
            this.dg_bProd.Controls.Add(this.label1);
            this.dg_bProd.Controls.Add(this.txt_bProdc);
            this.dg_bProd.Controls.Add(this.label2);
            this.dg_bProd.Controls.Add(this.dgv_bProd);
            this.dg_bProd.ForeColor = System.Drawing.Color.White;
            this.dg_bProd.Location = new System.Drawing.Point(8, 6);
            this.dg_bProd.Name = "dg_bProd";
            this.dg_bProd.Size = new System.Drawing.Size(990, 262);
            this.dg_bProd.TabIndex = 29;
            this.dg_bProd.TabStop = false;
            this.dg_bProd.Text = "Busqueda";
            // 
            // btn_bProd
            // 
            this.btn_bProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_bProd.FlatAppearance.BorderSize = 2;
            this.btn_bProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bProd.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_bProd.ForeColor = System.Drawing.Color.White;
            this.btn_bProd.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_bProd.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_bProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_bProd.IconSize = 40;
            this.btn_bProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_bProd.Location = new System.Drawing.Point(757, 39);
            this.btn_bProd.Name = "btn_bProd";
            this.btn_bProd.Size = new System.Drawing.Size(148, 44);
            this.btn_bProd.TabIndex = 15;
            this.btn_bProd.Text = "Buscar";
            this.btn_bProd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_bProd.UseVisualStyleBackColor = false;
            this.btn_bProd.Click += new System.EventHandler(this.btn_bProd_Click);
            // 
            // txt_bProdn
            // 
            this.txt_bProdn.Location = new System.Drawing.Point(119, 72);
            this.txt_bProdn.Name = "txt_bProdn";
            this.txt_bProdn.Size = new System.Drawing.Size(541, 26);
            this.txt_bProdn.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // txt_bProdc
            // 
            this.txt_bProdc.Location = new System.Drawing.Point(119, 25);
            this.txt_bProdc.Name = "txt_bProdc";
            this.txt_bProdc.Size = new System.Drawing.Size(541, 26);
            this.txt_bProdc.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Codigo";
            // 
            // dgv_bProd
            // 
            this.dgv_bProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.dgv_bProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bProd.Location = new System.Drawing.Point(6, 118);
            this.dgv_bProd.Name = "dgv_bProd";
            this.dgv_bProd.RowHeadersWidth = 51;
            this.dgv_bProd.RowTemplate.Height = 24;
            this.dgv_bProd.Size = new System.Drawing.Size(978, 138);
            this.dgv_bProd.TabIndex = 0;
            this.dgv_bProd.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_bProd_CellMouseDoubleClick);
            // 
            // tp_multi
            // 
            this.tp_multi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tp_multi.Controls.Add(this.groupBox1);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.groupBox1.Controls.Add(this.lbl_ptotal);
            this.groupBox1.Controls.Add(this.lbl_Ncliente);
            this.groupBox1.Controls.Add(this.dgv_Ventab);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(990, 271);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta realizada";
            // 
            // lbl_ptotal
            // 
            this.lbl_ptotal.AutoSize = true;
            this.lbl_ptotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ptotal.ForeColor = System.Drawing.Color.White;
            this.lbl_ptotal.Location = new System.Drawing.Point(685, 25);
            this.lbl_ptotal.Name = "lbl_ptotal";
            this.lbl_ptotal.Size = new System.Drawing.Size(62, 25);
            this.lbl_ptotal.TabIndex = 9;
            this.lbl_ptotal.Text = "Total:";
            // 
            // lbl_Ncliente
            // 
            this.lbl_Ncliente.AutoSize = true;
            this.lbl_Ncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Ncliente.ForeColor = System.Drawing.Color.White;
            this.lbl_Ncliente.Location = new System.Drawing.Point(7, 25);
            this.lbl_Ncliente.Name = "lbl_Ncliente";
            this.lbl_Ncliente.Size = new System.Drawing.Size(79, 25);
            this.lbl_Ncliente.TabIndex = 8;
            this.lbl_Ncliente.Text = "Cliente:";
            // 
            // dgv_Ventab
            // 
            this.dgv_Ventab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Ventab.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.dgv_Ventab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ventab.Location = new System.Drawing.Point(8, 57);
            this.dgv_Ventab.Name = "dgv_Ventab";
            this.dgv_Ventab.RowHeadersWidth = 51;
            this.dgv_Ventab.RowTemplate.Height = 24;
            this.dgv_Ventab.Size = new System.Drawing.Size(976, 208);
            this.dgv_Ventab.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
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
            this.groupBox2.Size = new System.Drawing.Size(990, 262);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda";
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
            this.btn_vEliminar.Location = new System.Drawing.Point(775, 68);
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
            this.btn_Buscar.Location = new System.Drawing.Point(775, 16);
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
            this.txt_bNombre.Location = new System.Drawing.Point(119, 72);
            this.txt_bNombre.Name = "txt_bNombre";
            this.txt_bNombre.Size = new System.Drawing.Size(541, 26);
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
            this.txt_bCodigo.Location = new System.Drawing.Point(119, 25);
            this.txt_bCodigo.Name = "txt_bCodigo";
            this.txt_bCodigo.Size = new System.Drawing.Size(541, 26);
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
            this.dgv_Busqueda.Location = new System.Drawing.Point(6, 118);
            this.dgv_Busqueda.Name = "dgv_Busqueda";
            this.dgv_Busqueda.RowHeadersWidth = 51;
            this.dgv_Busqueda.RowTemplate.Height = 24;
            this.dgv_Busqueda.Size = new System.Drawing.Size(978, 138);
            this.dgv_Busqueda.TabIndex = 0;
            this.dgv_Busqueda.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Busqueda_CellMouseDoubleClick);
            // 
            // vVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1014, 582);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vVentas";
            this.Text = "vVentas";
            this.tabControl1.ResumeLayout(false);
            this.tp_Agregar.ResumeLayout(false);
            this.gb_Ventas.ResumeLayout(false);
            this.gb_Ventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Venta)).EndInit();
            this.dg_bProd.ResumeLayout(false);
            this.dg_bProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bProd)).EndInit();
            this.tp_multi.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ventab)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Busqueda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Agregar;
        private System.Windows.Forms.GroupBox gb_Ventas;
        private FontAwesome.Sharp.IconButton btn_Vender;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Venta;
        private System.Windows.Forms.GroupBox dg_bProd;
        private FontAwesome.Sharp.IconButton btn_bProd;
        private System.Windows.Forms.TextBox txt_bProdn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bProdc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_bProd;
        private System.Windows.Forms.TabPage tp_multi;
        private System.Windows.Forms.TextBox txt_Venc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btn_vEliminar;
        private System.Windows.Forms.DataGridView dgv_Ventab;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btn_Buscar;
        private System.Windows.Forms.TextBox txt_bNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_bCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_Busqueda;
        private System.Windows.Forms.Label lbl_ptotal;
        private System.Windows.Forms.Label lbl_Ncliente;
    }
}