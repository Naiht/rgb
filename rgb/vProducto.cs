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
    public partial class vProducto : Form
    {

        //ConexionSQL
        sqlcon sql = new sqlcon();
        //Validaciones
        validaV vali = new validaV();
        bool valc = false;
        string idv = "";

        public vProducto()
        {
            InitializeComponent();
            dgv_Busqueda.ForeColor = Color.Black;
            dgv_Busqueda.ReadOnly = true;
           
            //Acceso a la tabla prod catalogo para traer las marcas al combo box
            DataTable tabla;
            tabla = sql.tablas("prodcatalogo", "select * from prodcatalogo");

            if (tabla.Rows.Count > 0)
            {
                for (int i =0; i < tabla.Rows.Count; i++) {
           
                    cb_Marcas.Items.Add(""+Convert.ToString(tabla.Rows[i][1]));
                    cb_dMarca.Items.Add("" + Convert.ToString(tabla.Rows[i][1]));
                }
            }
            cb_Marcas.SelectedIndex = 0;
            cb_dMarca.SelectedIndex = 0;
        }

        //Agregar prudcto
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (!vali.validarGB(gb_datosProd))
            {
                DataTable tabla;
                tabla = sql.tablas("prodcuto", "select * from producto where cod_prod = '" + txt_aCodProd.Text + "'");

                if (tabla.Rows.Count > 0)
                {
                    MessageBox.Show("El producto ya existe.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int marca = (cb_Marcas.SelectedIndex + 1);
                    if (sql.multiple("insert producto values ('" + txt_aCodProd.Text + "',"+txt_aCantidad.Text+","+txt_aPrecio.Text+",'"+txt_aNombreP.Text+"',"+marca+")"))
                    {
                        MessageBox.Show("Producto agregado con exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vali.limpiar(gb_datosProd);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un problema al agregar el producto");
                    }
                }
            }
            else
            {
                MessageBox.Show("No puede dejar ningun campo vacío.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Buscar producto
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_bCodigo.Text.Equals(""))
            {
                if (txt_bNombre.Text.Equals(""))
                {
                    DataTable tabla;
                    tabla = sql.tablas("producto", "select p.cod_prod, p.nombre, p.cantidad, p.precio, c.marca from producto p inner join prodcatalogo c on p.id_marca = c.id_marca");

                    if (tabla.Rows.Count > 0)
                    {
                        dgv_Busqueda.DataSource = tabla;
                    }
                }
                else
                {
                    DataTable tabla;
                    tabla = sql.tablas("prodcuto", "select p.cod_prod, p.nombre, p.cantidad, p.precio, c.marca from producto p inner join prodcatalogo c on p.id_marca = c.id_marca where nombre like '%" + txt_bNombre.Text+ "%'");

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
                tabla = sql.tablas("prodcuto", "select p.cod_prod, p.nombre, p.cantidad, p.precio, c.marca from producto p inner join prodcatalogo c on p.id_marca = c.id_marca where cod_prod = '" + txt_bCodigo.Text + "'");

                if (tabla.Rows.Count > 0)
                {
                    dgv_Busqueda.DataSource = tabla;
                }
                else
                {
                    MessageBox.Show("El producto no existe.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);//REVISA ESTA LINEA HOY QUE ESTA MAL
                }
            }
        }

        
        //Actualizar producto
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            bool modif = false;
            string query = "";
            DialogResult dr;

            if (valc == false)
            {
                MessageBox.Show("Por favor valide la cedula antes de modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (vali.validarGB(gb_Datos))
                {
                    MessageBox.Show("No puede dejar ningun campo vacío.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        DataTable tabla;
                        tabla = sql.tablas("producto", "select * from producto where cod_prod = '" + txt_dCodigo.Text + "'");

                        dr = MessageBox.Show("¿Modifico el codigo?", "Adverentica", MessageBoxButtons.YesNo);

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
                            MessageBox.Show("El codigo del producto ya existe.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (modif == true)
                            {
                                query = "update producto " +
                                    "set cod_prod = '"+txt_dCodigo.Text+"', cantidad = "+txt_dCantidad.Text+", " +
                                    "precio = "+txt_dPrecio.Text+", nombre = '"+txt_dNombre.Text+"', id_marca = "+ (cb_dMarca.SelectedIndex+1) +" where cod_prod = '"+idv+"'";
                            }
                            else
                            {
                                query = "update producto " +
                                    "set cantidad = " + txt_dCantidad.Text + ", " +
                                    "precio = " + txt_dPrecio.Text + ", nombre = '" + txt_dNombre.Text + "', id_marca = " + (cb_dMarca.SelectedIndex + 1) + " where cod_prod = '" + idv + "'";
                            }

                            if (sql.multiple(query))
                            {
                                MessageBox.Show("Producto modificado con extio", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                valc = false;
                                modif = false;
                                vali.limpiar(gb_Datos);
                                btn_Validar.IconColor = Color.Gainsboro;
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un problema al modificar el producto");
                            }
                        }
                    }
                    catch (Exception z)
                    {
                        MessageBox.Show("Producto invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Borrar producto
        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            if (txt_dCodigo.Text.Equals(""))
            {
                MessageBox.Show("Necesita ingresar un codigo valida", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable tabla;
                tabla = sql.tablas("producto", "select * from producto where cod_prod = '" + txt_dCodigo.Text + "'");

                if (tabla.Rows.Count > 0)
                {
                    if (sql.multiple("delete from producto where cod_prod = '" + txt_dCodigo.Text + "'"))
                    {
                        MessageBox.Show("Producto eliminado con exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vali.limpiar(gb_Datos);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un problema al eliminar el Producto");
                    }
                }
                else
                {
                    MessageBox.Show("El Producto no existe.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //Validar id
        private void btn_Validar_Click(object sender, EventArgs e)
        {
            if (txt_dCodigo.Text.Equals(""))
            {
                MessageBox.Show("No puede dejar el codigo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                validaid();
                if (valc == true)
                {
                    MessageBox.Show("Codigo valido para modificar", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Codigo incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void validaid()
        {

            DataTable tabla;
            tabla = sql.tablas("prodcuto", "select * from producto where cod_prod = '" + txt_dCodigo.Text + "'");

            if (tabla.Rows.Count > 0)
            {
                idv = txt_dCodigo.Text;
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
            txt_dCodigo.Text = ""+dgv_Busqueda.CurrentRow.Cells[0].Value.ToString();
            txt_dCantidad.Text = "" + dgv_Busqueda.CurrentRow.Cells[2].Value.ToString();
            txt_dNombre.Text = "" + dgv_Busqueda.CurrentRow.Cells[1].Value.ToString();
            txt_dPrecio.Text = "" + dgv_Busqueda.CurrentRow.Cells[3].Value.ToString();
            cb_dMarca.SelectedItem = dgv_Busqueda.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
