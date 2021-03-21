using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace rgb
{
    public partial class vPrincipal : Form
    {

        //iconos
        private IconButton currentBtn;

        public vPrincipal()
        {
            InitializeComponent();
            
        }

        //PanelSub Dragger
        #region panelSuperior
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pan_sup_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region BotonesConfig
        //Colores
        private struct Colores
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(240, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 255);
        }
        private void actButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                dsbButton();
                //Btn
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //pansub
                pb_iconform.IconChar = currentBtn.IconChar;
                pb_iconform.IconColor = currentBtn.IconColor;
                lbl_nameform.Text = currentBtn.Text;
            }
        }

        private void dsbButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }
        #endregion


        private void reset()
        {
            dsbButton();
            pb_iconform.IconChar = IconChar.Home;
            pb_iconform.IconColor = Color.Gainsboro;
            lbl_nameform.Text = "Principal";
        }

        private void Abrir_Form(object formhijo)
        {

            if (this.PanelCont.Controls.Count > 0)
                this.PanelCont.Controls.RemoveAt(0);

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelCont.Controls.Add(fh);
            this.PanelCont.Tag = fh;
            fh.Show();
        }

        //Botones Laterales
        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            actButton(sender,Colores.color1);
            Abrir_Form(new vCliente());
        }

        private void btn_Reparaciones_Click(object sender, EventArgs e)
        {
            actButton(sender, Colores.color2);
            Abrir_Form(new vReparacion());
        }

        private void btn_Producto_Click(object sender, EventArgs e)
        {
            actButton(sender, Colores.color3);
            Abrir_Form(new vProducto());
        }

        private void btn_Venta_Click(object sender, EventArgs e)
        {
            actButton(sender, Colores.color4);
            Abrir_Form(new vVentas());
        }

        private void pb_Logo_Click(object sender, EventArgs e)
        {
            reset();
            if (this.PanelCont.Controls.Count > 0)
                this.PanelCont.Controls.RemoveAt(0);
        }
    }
}
