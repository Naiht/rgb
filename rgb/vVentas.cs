using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace rgb
{
    public partial class vVentas : Form
    {
        //ConexionSQL
        sqlcon sql = new sqlcon();
        //Validaciones
        validaV vali = new validaV();
        public vVentas()
        {
            InitializeComponent();
            dgv_Busqueda.ForeColor = Color.Black;
            dgv_Busqueda.ReadOnly = true;
            dgv_bProd.ForeColor = Color.Black;
            dgv_bProd.ReadOnly = true;
            dgv_Venta.ForeColor = Color.Black;
            dgv_Venta.ReadOnly = true;
            dgv_Ventab.ForeColor = Color.Black;
            dgv_Ventab.ReadOnly = true;
            iniVentas();
        }

        private void iniVentas()
        {
            dgv_Venta.Columns.Add("", "Producto");
            dgv_Venta.Columns.Add("", "Codigo");
            dgv_Venta.Columns.Add("", "Cantidad");
            dgv_Venta.Columns.Add("", "Precio");
        }

        #region bprod+ADD
        private void btn_bProd_Click(object sender, EventArgs e)
        {
            if (txt_bProdc.Text.Equals(""))
            {
                if (txt_bProdn.Text.Equals(""))
                {
                    DataTable tabla;
                    tabla = sql.tablas("producto", "select p.cod_prod, p.nombre, p.cantidad, p.precio, c.marca from producto p inner join prodcatalogo c on p.id_marca = c.id_marca");

                    if (tabla.Rows.Count > 0)
                    {
                        dgv_bProd.DataSource = tabla;
                    }
                }
                else
                {
                    DataTable tabla;
                    tabla = sql.tablas("prodcuto", "select p.cod_prod, p.nombre, p.cantidad, p.precio, c.marca from producto p inner join prodcatalogo c on p.id_marca = c.id_marca where nombre like '%" + txt_bProdn.Text + "%'");

                    if (tabla.Rows.Count > 0)
                    {
                        dgv_bProd.DataSource = tabla;
                    }
                    else
                    {

                    }
                }
            }
            else
            {
                DataTable tabla;
                tabla = sql.tablas("prodcuto", "select p.cod_prod, p.nombre, p.cantidad, p.precio, c.marca from producto p inner join prodcatalogo c on p.id_marca = c.id_marca where cod_prod = '" + txt_bProdc.Text + "'");

                if (tabla.Rows.Count > 0)
                {
                    dgv_bProd.DataSource = tabla;
                }
                else
                {
                    MessageBox.Show("El producto no existe.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);//REVISA ESTA LINEA HOY QUE ESTA MAL
                }
            }
        }

        float total = 0;

        private void dgv_bProd_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cantidad = 0;
            try
            {
                cantidad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad", "Cantidad producto", "0", this.Size.Width / 2, this.Size.Height / 2));
            }
            catch (Exception z)
            {
            }

            if (cantidad > int.Parse(dgv_bProd.CurrentRow.Cells[2].Value.ToString()))
            {
                MessageBox.Show("No hay suficiente producto", "");
            }
            else if (cantidad > 0)
            {
                string precio;
                int n = dgv_Venta.Rows.Add();
                dgv_Venta.Rows[n].Cells[0].Value = dgv_bProd.CurrentRow.Cells[1].Value.ToString();//nombre
                dgv_Venta.Rows[n].Cells[1].Value = dgv_bProd.CurrentRow.Cells[0].Value.ToString();//codigo
                dgv_Venta.Rows[n].Cells[2].Value = cantidad;
                dgv_Venta.Rows[n].Cells[3].Value = dgv_bProd.CurrentRow.Cells[3].Value.ToString();//precio

                precio = dgv_bProd.CurrentRow.Cells[3].Value.ToString();

                dgv_bProd.CurrentRow.Cells[2].Value = int.Parse(dgv_bProd.CurrentRow.Cells[2].Value.ToString()) - cantidad;
                total += float.Parse(precio) * cantidad;
                txt_Total.Text = "" + total;
            }
        }
        #endregion

        #region venta
        private void btn_Vender_Click(object sender, EventArgs e)
        {
            if (!txt_Venc.Text.Equals(""))
            {
                if (dgv_Venta.Rows.Count <= 1)
                {
                    MessageBox.Show("Necesita agregar minimo un producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (sql.multiple("insert pedido values ('" + txt_Venc.Text + "', " + txt_Total.Text + " ,'" + string.Format("{0: yyyy-MM-dd}", DateTime.Today) + "')"))
                    {
                        if (agppedido())
                        {
                            MessageBox.Show("Venta realizada con exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgv_Venta.Rows.Clear();
                            vali.limpiar(gb_Ventas);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un problema al agregar la venta");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un problema al agregar la venta");
                    }
                }
            }
            else
            {
                MessageBox.Show("No puede dejar ningun campo vacío.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool agppedido()
        {
            int factura = 0;
            DataTable tabla;
            tabla = sql.tablas("pedido", "select * from pedido");

            factura = int.Parse(tabla.Rows[tabla.Rows.Count - 1][0].ToString());

            int fila = int.Parse(dgv_Venta.Rows.Count.ToString());
            int i = 0;
            while (i < fila - 1)
            {
                sql.multiple("insert ppedido values (" + factura + ",'" + dgv_Venta.Rows[i].Cells[1].Value.ToString() + "'," + dgv_Venta.Rows[i].Cells[3].Value.ToString() + "," + dgv_Venta.Rows[i].Cells[2].Value.ToString() + ")");
                sql.multiple("update producto set cantidad =" + int.Parse(dgv_bProd.CurrentRow.Cells[2].Value.ToString()) + " where cod_prod = '" + dgv_Venta.Rows[i].Cells[1].Value.ToString() + "'");
                i++;
            }
            return true;
        }
        #endregion

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_bCodigo.Text.Equals(""))
            {
                if (txt_bNombre.Text.Equals(""))
                {
                    btn_vEliminar.Enabled = true;
                    DataTable tabla;
                    tabla = sql.tablas("pedido", "select * from pedido");

                    if (tabla.Rows.Count > 0)
                    {
                        dgv_Busqueda.DataSource = tabla;
                    }
                }
                else
                {
                    btn_vEliminar.Enabled = true;
                    DataTable tabla;
                    tabla = sql.tablas("pedido", "select * from pedido where nombre_c like '%" + txt_bNombre.Text + "%'");

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
                btn_vEliminar.Enabled = true;
                DataTable tabla;
                tabla = sql.tablas("pedido", "select * from pedido where cod_prod = '" + txt_bCodigo.Text + "'");

                if (tabla.Rows.Count > 0)
                {
                    dgv_Busqueda.DataSource = tabla;
                }
                else
                {
                    MessageBox.Show("El pedido no existe.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);//REVISA ESTA LINEA HOY QUE ESTA MAL
                }
            }
        }

        private void dgv_Busqueda_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataTable tabla;
            tabla = sql.tablas("pedido", "Select pr.nombre,pp.cantidadp,pp.preciop,fecha_p from pedido p inner join ppedido pp on p.num_pedido = pp.num_pedido " +
                "inner join producto pr on pp.cod_prod = pr.cod_prod  where p.num_pedido = " + dgv_Busqueda.CurrentRow.Cells[0].Value.ToString());

            if (tabla.Rows.Count > 0)
            {
                lbl_Ncliente.Text = "Cliente: " + dgv_Busqueda.CurrentRow.Cells[1].Value.ToString();
                lbl_ptotal.Text = "Total: " + dgv_Busqueda.CurrentRow.Cells[2].Value.ToString();
                dgv_Ventab.DataSource = tabla;
            }
        }

        private void btn_vEliminar_Click(object sender, EventArgs e)
        {
            if (sql.multiple("delete from ppedido where num_pedido = " + dgv_Busqueda.CurrentRow.Cells[0].Value.ToString()))
            {
                if (sql.multiple("delete from pedido where num_pedido = " + dgv_Busqueda.CurrentRow.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Pedido eliminado con exito");
                    dgv_Ventab.DataSource = null;
                    lbl_Ncliente.Text = "Cliente: ";
                    lbl_ptotal.Text = "Total: ";
                }
                else
                {
                    MessageBox.Show("Error al eliminar");
                }
            }
            else
            {
                MessageBox.Show("Error al eliminar");
            }
        }

        private void dgv_Venta_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cantidad = 0;
            try
            {
                cantidad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad", "Cantidad producto", "0", this.Size.Width / 2, this.Size.Height / 2));
            }
            catch (Exception z)
            {
                MessageBox.Show("Ingrese una cantidad correcta");
            }

            if (cantidad > int.Parse(dgv_bProd.CurrentRow.Cells[2].Value.ToString()))
            {
                MessageBox.Show("No hay suficiente producto", "");
            }
            else if (cantidad > 0)
            {
                string precio;
                
                dgv_Venta.CurrentRow.Cells[2].Value = cantidad;
                

                dgv_bProd.CurrentRow.Cells[2].Value = int.Parse(dgv_bProd.CurrentRow.Cells[2].Value.ToString()) + cantidad;
               
                total = 0;
                
                int fila = int.Parse(dgv_Venta.Rows.Count.ToString());
                int i = 0;
                while (i < fila - 1)
                {
                    precio = dgv_Venta.Rows[i].Cells[3].Value.ToString();
                    total += float.Parse(precio) * int.Parse(dgv_Venta.Rows[i].Cells[2].Value.ToString());
                    i++;
                }
                txt_Total.Text = "" + total;
            }
        }
    }
}
