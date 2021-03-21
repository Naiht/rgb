using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rgb
{
    public partial class vCliente : Form
    {
        //ConexionSQL
        sqlcon sql = new sqlcon();
        //Validaciones
        validaV vali = new validaV();
        bool valc = false;
        string idv = "";

        public vCliente()
        {
            InitializeComponent();
            dgv_Busqueda.ForeColor = Color.Black;
            dgv_Busqueda.ReadOnly = true;
        }

        //Agregar Cliente
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (!vali.validarGB(gb_datosCliente))
            {
                DataTable tabla;
                tabla = sql.tablas("cliente","select * from cliente where cedula = '" + txt_aCedula.Text + "'");
                
                if (tabla.Rows.Count > 0){
                    MessageBox.Show("El cliente ya existe.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (sql.multiple("insert cliente values ('" + txt_aCedula.Text + "'," +
                     "'" + txt_aNombre.Text + "','" + txt_aNumero.Text + "','" + txt_aDir.Text + "')"))
                    {
                        MessageBox.Show("Cliente agregado con exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vali.limpiar(gb_datosCliente);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un problema al agregar el cliente");
                    }
                }
            }
            else {
                MessageBox.Show("No puede dejar ningun campo vacío.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Buscar cliente
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_bCedula.Text.Equals(""))
            {
                if (txt_bNumero.Text.Equals(""))
                {
                    DataTable tabla;
                    tabla = sql.tablas("cliente", "select * from cliente");

                    if (tabla.Rows.Count > 0)
                    {
                        dgv_Busqueda.DataSource = tabla;
                    }
                }
                else
                {
                    DataTable tabla;
                    tabla = sql.tablas("cliente", "select * from cliente where numero = '" + txt_bNumero.Text + "'");

                    if (tabla.Rows.Count > 0)
                    {
                        dgv_Busqueda.DataSource = tabla;
                    }
                    else
                    {

                    }
                }
            }
            else
            {
                DataTable tabla;
                tabla = sql.tablas("cliente", "select * from cliente where cedula = '" + txt_bCedula.Text + "'");

                if (tabla.Rows.Count > 0)
                {
                    dgv_Busqueda.DataSource = tabla;
                }
                else
                {
                    MessageBox.Show("El cliente no existe.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);//REVISA ESTA LINEA HOY QUE ESTA MAL
                }
            }
        }

        //Actualizar cliente
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            bool modif = false;
            string query = "";
            DialogResult dr;

            if (valc == false)
            {
                MessageBox.Show("Por favor valide la cedula antes de modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                if (vali.validarGB(gb_Datos))
                {
                    MessageBox.Show("No puede dejar ningun campo vacío.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        DataTable tabla;
                        tabla = sql.tablas("cliente", "select * from cliente where cedula = '" + txt_dCedula.Text + "'");

                        dr = MessageBox.Show("¿Modifico la cedula?", "Adverentica", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {
                            modif = true;
                        }
                        else
                        {
                            modif = false;
                        }

                        if (tabla.Rows.Count > 0 && modif == true)
                        {
                            MessageBox.Show("El ID del cliente ya existe.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (modif == true)
                            {
                                query = "update cliente set " +
                                "cedula = '" + txt_dCedula.Text + "', nombre = '" + txt_dNombre.Text + "', numero = '" + txt_dNumero.Text + "', " +
                                "direccion = '" + txt_dDireccion.Text + "' where cedula = '" + idv + "'";
                            }
                            else
                            {
                                query = "update cliente set " +
                                "nombre = '" + txt_dNombre.Text + "', numero = '" + txt_dNumero.Text + "', " +
                                "direccion = '" + txt_dDireccion.Text + "' where cedula = '" + idv + "'";
                            }

                            if (sql.multiple(query))
                            {
                                MessageBox.Show("Cliente modificado con exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                valc = false;
                                modif = false;
                                vali.limpiar(gb_Datos);
                                btn_Validar.IconColor = Color.Gainsboro;
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un problema al modificar el cliente");
                            }
                        }
                    }
                    catch (Exception z) {
                        MessageBox.Show("Cedula invalida","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }
        //Borrar cliente
        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            if (txt_dCedula.Text.Equals(""))
            {
                MessageBox.Show("Necesita ingresar una cedula valida", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable tabla;
                tabla = sql.tablas("cliente", "select * from cliente where cedula = '" + txt_dCedula.Text + "'");

                if (tabla.Rows.Count > 0)
                {
                    if (sql.multiple("delete from cliente where cedula = '" + txt_dCedula.Text + "'"))
                    {
                        MessageBox.Show("Cliente eliminado con exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vali.limpiar(gb_Datos);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un problema al eliminar el cliente");
                    }
                }
                else
                {
                    MessageBox.Show("El cliente no existe.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        //Validar id
        private void btn_Validar_Click(object sender, EventArgs e)
        {
            if (txt_dCedula.Text.Equals("")) {
                MessageBox.Show("No puede dejar la cedula vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                validaid();
                if (valc == true)
                {
                    MessageBox.Show("Cedula valida para modificar", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cedula incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void validaid() {
            
            DataTable tabla;
            tabla = sql.tablas("cliente", "select * from cliente where cedula = '" + txt_dCedula.Text + "'");

            if (tabla.Rows.Count > 0)
            {
                idv = txt_dCedula.Text;
                valc = true;
                btn_Validar.IconColor = Color.Green;
            }
            else
            {
                valc = false;
                btn_Validar.IconColor = Color.Red;
            }
        }

        private void dgv_Busqueda_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_dCedula.Text = "" + dgv_Busqueda.CurrentRow.Cells[0].Value.ToString();
            txt_dNombre.Text = "" + dgv_Busqueda.CurrentRow.Cells[1].Value.ToString();
            txt_dNumero.Text = "" + dgv_Busqueda.CurrentRow.Cells[2].Value.ToString();
            txt_dDireccion.Text = "" + dgv_Busqueda.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
