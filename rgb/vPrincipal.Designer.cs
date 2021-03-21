namespace rgb
{
    partial class vPrincipal
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_sep1 = new System.Windows.Forms.Label();
            this.fpan_lateral = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Cliente = new FontAwesome.Sharp.IconButton();
            this.btn_Reparaciones = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Producto = new FontAwesome.Sharp.IconButton();
            this.btn_Venta = new FontAwesome.Sharp.IconButton();
            this.pan_sup = new System.Windows.Forms.Panel();
            this.lbl_nameform = new System.Windows.Forms.Label();
            this.pb_iconform = new FontAwesome.Sharp.IconPictureBox();
            this.PanelCont = new System.Windows.Forms.Panel();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.fpan_lateral.SuspendLayout();
            this.pan_sup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_iconform)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pb_Logo);
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(237, 114);
            this.panelLogo.TabIndex = 0;
            // 
            // pb_Logo
            // 
            this.pb_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Logo.Image = global::rgb.Properties.Resources.logoblanco;
            this.pb_Logo.Location = new System.Drawing.Point(0, 0);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(237, 114);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            this.pb_Logo.Click += new System.EventHandler(this.pb_Logo_Click);
            // 
            // lbl_sep1
            // 
            this.lbl_sep1.AutoSize = true;
            this.lbl_sep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_sep1.ForeColor = System.Drawing.Color.White;
            this.lbl_sep1.Location = new System.Drawing.Point(3, 120);
            this.lbl_sep1.Name = "lbl_sep1";
            this.lbl_sep1.Size = new System.Drawing.Size(172, 20);
            this.lbl_sep1.TabIndex = 2;
            this.lbl_sep1.Text = "            Reparaciones";
            this.lbl_sep1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fpan_lateral
            // 
            this.fpan_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.fpan_lateral.Controls.Add(this.panelLogo);
            this.fpan_lateral.Controls.Add(this.lbl_sep1);
            this.fpan_lateral.Controls.Add(this.btn_Cliente);
            this.fpan_lateral.Controls.Add(this.btn_Reparaciones);
            this.fpan_lateral.Controls.Add(this.label1);
            this.fpan_lateral.Controls.Add(this.btn_Producto);
            this.fpan_lateral.Controls.Add(this.btn_Venta);
            this.fpan_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.fpan_lateral.Location = new System.Drawing.Point(0, 0);
            this.fpan_lateral.Name = "fpan_lateral";
            this.fpan_lateral.Size = new System.Drawing.Size(240, 657);
            this.fpan_lateral.TabIndex = 1;
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.FlatAppearance.BorderSize = 0;
            this.btn_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cliente.ForeColor = System.Drawing.Color.White;
            this.btn_Cliente.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btn_Cliente.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Cliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Cliente.IconSize = 38;
            this.btn_Cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cliente.Location = new System.Drawing.Point(3, 143);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(237, 72);
            this.btn_Cliente.TabIndex = 3;
            this.btn_Cliente.Text = "Clientes";
            this.btn_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cliente.UseVisualStyleBackColor = true;
            this.btn_Cliente.Click += new System.EventHandler(this.btn_Cliente_Click);
            // 
            // btn_Reparaciones
            // 
            this.btn_Reparaciones.FlatAppearance.BorderSize = 0;
            this.btn_Reparaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reparaciones.ForeColor = System.Drawing.Color.White;
            this.btn_Reparaciones.IconChar = FontAwesome.Sharp.IconChar.Screwdriver;
            this.btn_Reparaciones.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Reparaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Reparaciones.IconSize = 38;
            this.btn_Reparaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reparaciones.Location = new System.Drawing.Point(3, 221);
            this.btn_Reparaciones.Name = "btn_Reparaciones";
            this.btn_Reparaciones.Size = new System.Drawing.Size(237, 72);
            this.btn_Reparaciones.TabIndex = 4;
            this.btn_Reparaciones.Text = "Reparaciones";
            this.btn_Reparaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reparaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Reparaciones.UseVisualStyleBackColor = true;
            this.btn_Reparaciones.Click += new System.EventHandler(this.btn_Reparaciones_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "                  Ventas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Producto
            // 
            this.btn_Producto.FlatAppearance.BorderSize = 0;
            this.btn_Producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Producto.ForeColor = System.Drawing.Color.White;
            this.btn_Producto.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btn_Producto.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Producto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Producto.IconSize = 38;
            this.btn_Producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Producto.Location = new System.Drawing.Point(3, 319);
            this.btn_Producto.Name = "btn_Producto";
            this.btn_Producto.Size = new System.Drawing.Size(237, 72);
            this.btn_Producto.TabIndex = 6;
            this.btn_Producto.Text = "Productos";
            this.btn_Producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Producto.UseVisualStyleBackColor = true;
            this.btn_Producto.Click += new System.EventHandler(this.btn_Producto_Click);
            // 
            // btn_Venta
            // 
            this.btn_Venta.FlatAppearance.BorderSize = 0;
            this.btn_Venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Venta.ForeColor = System.Drawing.Color.White;
            this.btn_Venta.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btn_Venta.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Venta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Venta.IconSize = 38;
            this.btn_Venta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Venta.Location = new System.Drawing.Point(3, 397);
            this.btn_Venta.Name = "btn_Venta";
            this.btn_Venta.Size = new System.Drawing.Size(237, 72);
            this.btn_Venta.TabIndex = 7;
            this.btn_Venta.Text = "Ventas";
            this.btn_Venta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Venta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Venta.UseVisualStyleBackColor = true;
            this.btn_Venta.Click += new System.EventHandler(this.btn_Venta_Click);
            // 
            // pan_sup
            // 
            this.pan_sup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pan_sup.Controls.Add(this.lbl_nameform);
            this.pan_sup.Controls.Add(this.pb_iconform);
            this.pan_sup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_sup.Location = new System.Drawing.Point(240, 0);
            this.pan_sup.Name = "pan_sup";
            this.pan_sup.Size = new System.Drawing.Size(1014, 75);
            this.pan_sup.TabIndex = 2;
            this.pan_sup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pan_sup_MouseDown);
            // 
            // lbl_nameform
            // 
            this.lbl_nameform.AutoSize = true;
            this.lbl_nameform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_nameform.ForeColor = System.Drawing.Color.White;
            this.lbl_nameform.Location = new System.Drawing.Point(63, 28);
            this.lbl_nameform.Name = "lbl_nameform";
            this.lbl_nameform.Size = new System.Drawing.Size(86, 25);
            this.lbl_nameform.TabIndex = 1;
            this.lbl_nameform.Text = "Principal";
            // 
            // pb_iconform
            // 
            this.pb_iconform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pb_iconform.ForeColor = System.Drawing.Color.Gainsboro;
            this.pb_iconform.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.pb_iconform.IconColor = System.Drawing.Color.Gainsboro;
            this.pb_iconform.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pb_iconform.IconSize = 50;
            this.pb_iconform.Location = new System.Drawing.Point(6, 15);
            this.pb_iconform.Name = "pb_iconform";
            this.pb_iconform.Size = new System.Drawing.Size(51, 50);
            this.pb_iconform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_iconform.TabIndex = 0;
            this.pb_iconform.TabStop = false;
            // 
            // PanelCont
            // 
            this.PanelCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.PanelCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCont.Location = new System.Drawing.Point(240, 75);
            this.PanelCont.Name = "PanelCont";
            this.PanelCont.Size = new System.Drawing.Size(1014, 582);
            this.PanelCont.TabIndex = 3;
            // 
            // vPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 657);
            this.Controls.Add(this.PanelCont);
            this.Controls.Add(this.pan_sup);
            this.Controls.Add(this.fpan_lateral);
            this.MaximizeBox = false;
            this.Name = "vPrincipal";
            this.Text = "Reparaciones Gamer & Basic";
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.fpan_lateral.ResumeLayout(false);
            this.fpan_lateral.PerformLayout();
            this.pan_sup.ResumeLayout(false);
            this.pan_sup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_iconform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lbl_sep1;
        private FontAwesome.Sharp.IconButton btn_Cliente;
        private System.Windows.Forms.FlowLayoutPanel fpan_lateral;
        private System.Windows.Forms.PictureBox pb_Logo;
        private FontAwesome.Sharp.IconButton btn_Reparaciones;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_Producto;
        private FontAwesome.Sharp.IconButton btn_Venta;
        private System.Windows.Forms.Panel pan_sup;
        private FontAwesome.Sharp.IconPictureBox pb_iconform;
        private System.Windows.Forms.Label lbl_nameform;
        private System.Windows.Forms.Panel PanelCont;
    }
}