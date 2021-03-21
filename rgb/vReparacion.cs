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
    public partial class vReparacion : Form
    {
        //ConexionSQL
        sqlcon sql = new sqlcon();
        //Validaciones
        validaV vali = new validaV();

        public vReparacion()
        {
            InitializeComponent();

            DataTable tabla;
            tabla = sql.tablas("repacatalogo", "select * from repacatalogo");

            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {

                    cb_rTipo.Items.Add("" + Convert.ToString(tabla.Rows[i][1]));
                }
            }
            cb_rTipo.SelectedIndex = 0;

            dgv_Busqueda.ForeColor = Color.Black;
            dgv_Busqueda.ReadOnly = true;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (!vali.validarGB(gb_Reparacion))
            {
                if (valc == true)
                {

                    if (sql.multiple("insert reparacion values('" + txt_bClic.Text + "', " +
                        "'" + txt_rModelo.Text + "'," + (cb_rTipo.SelectedIndex + 1) + ",'" + txt_rDetalles.Text + "', '" + txt_rDesc.Text + "', " +
                        "'" + string.Format("{0: yyyy-MM-dd}", dtp_rFecha.Value) + "','')"))
                    {
                        MessageBox.Show("Reparacion agregada con exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vali.limpiar(gb_Reparacion);
                        valc = false;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un problema al agregar la reparacion");
                    }
                }
                else {
                    MessageBox.Show("Ingrese la cedula de un cliente existente","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }
            else {
                MessageBox.Show("No puede dejar ningun campo vacio","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btn_Validar_Click(object sender, EventArgs e)
        {
            if (txt_bClic.Text.Equals(""))
            {
                MessageBox.Show("No puede dejar la cedula vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                validaid();
                if (valc == true)
                {
                    MessageBox.Show("Cliente encontrado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No existe ningun cliente con esta cedula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        bool valc = false;
        string idv = "";

        private void validaid()
        {

            DataTable tabla;
            tabla = sql.tablas("cliente", "select * from cliente where cedula = '" + txt_bClic.Text + "'");

            if (tabla.Rows.Count > 0)
            {
                idv = txt_bClic.Text;
                valc = true;
                btn_Validar.IconColor = Color.Green;
            }
            else
            {
                valc = false;
                btn_Validar.IconColor = Color.Red;
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (chb_bfecha.Checked)
            {
                if (txt_bCodigo.Text.Equals(""))
                {
                    if (txt_bCedula.Text.Equals(""))
                    {
                        if (txt_bNombre.Text.Equals(""))
                        {
                            btn_vEliminar.Enabled = true;
                            DataTable tabla;
                            tabla = sql.tablas("reparacion", "select c.nombre, c.cedula, r.modelo, re.nombre,r.detalles,r.descrip_p,r.fecha_ing from reparacion r inner join cliente c on r.cedula = c.cedula " +
                                "inner join repacatalogo re on r.idtipo = re.idtipo where r.fecha_ing BETWEEN '"+ string.Format("{0: yyyy-MM-dd}", dtp_inicio.Value) + "' AND '"+ string.Format("{0: yyyy-MM-dd}", dtp_fin.Value) + "'");

                            if (tabla.Rows.Count > 0)
                            {
                                dgv_Busqueda.DataSource = tabla;
                            }
                        }
                        else
                        {
                            btn_vEliminar.Enabled = true;
                            DataTable tabla;
                            tabla = sql.tablas("reparacion", "select c.nombre, c.cedula, r.modelo, re.nombre, r.detalles, r.descrip_p, r.fecha_ing " +
                                "from reparacion r inner join cliente c on r.cedula = c.cedula inner join repacatalogo re on r.idtipo = re.idtipo " +
                                "where c.nombre like '%" + txt_bNombre.Text + "%' and r.fecha_ing BETWEEN '" + string.Format("{0: yyyy-MM-dd}", dtp_inicio.Value) + "' AND '" + string.Format("{0: yyyy-MM-dd}", dtp_fin.Value) + "'");

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

                        tabla = sql.tablas("reparacion", "select c.nombre, c.cedula, r.modelo, re.nombre, r.detalles, r.descrip_p, r.fecha_ing " +
                            "from reparacion r inner join cliente c on r.cedula = c.cedula inner join repacatalogo re on r.idtipo = re.idtipo " +
                            "where c.cedula = '" + txt_bCedula.Text + "'");
                        if (tabla.Rows.Count > 0)
                        {
                            dgv_Busqueda.DataSource = tabla;
                        }
                        else
                        {
                            MessageBox.Show("La reparacion no existe.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);//REVISA ESTA LINEA HOY QUE ESTA MAL
                        }
                    }
                }
                else
                {

                    btn_vEliminar.Enabled = true;
                    DataTable tabla;

                    tabla = sql.tablas("reparacion", "select c.nombre, c.cedula, r.modelo, re.nombre, r.detalles, r.descrip_p, r.fecha_ing " +
                        "from reparacion r inner join cliente c on r.cedula = c.cedula inner join repacatalogo re on r.idtipo = re.idtipo " +
                        "where r.codigo = '" + txt_bCodigo.Text + "'");
                    if (tabla.Rows.Count > 0)
                    {
                        dgv_Busqueda.DataSource = tabla;
                    }
                    else
                    {
                        MessageBox.Show("La reparacion no existe.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);//REVISA ESTA LINEA HOY QUE ESTA MAL
                    }
                }
            }
            else {
                if (txt_bCodigo.Text.Equals(""))
                {
                    if (txt_bCedula.Text.Equals(""))
                    {
                        if (txt_bNombre.Text.Equals(""))
                        {
                            btn_vEliminar.Enabled = true;
                            DataTable tabla;
                            tabla = sql.tablas("reparacion", "select c.nombre, c.cedula, r.modelo, re.nombre,r.detalles,r.descrip_p,r.fecha_ing from reparacion r inner join cliente c on r.cedula = c.cedula inner join repacatalogo re on r.idtipo = re.idtipo");

                            if (tabla.Rows.Count > 0)
                            {
                                dgv_Busqueda.DataSource = tabla;
                            }
                        }
                        else
                        {
                            btn_vEliminar.Enabled = true;
                            DataTable tabla;
                            tabla = sql.tablas("reparacion", "select c.nombre, c.cedula, r.modelo, re.nombre, r.detalles, r.descrip_p, r.fecha_ing " +
                                "from reparacion r inner join cliente c on r.cedula = c.cedula inner join repacatalogo re on r.idtipo = re.idtipo " +
                                "where c.nombre like '%" + txt_bNombre.Text + "%'");

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

                        tabla = sql.tablas("reparacion", "select c.nombre, c.cedula, r.modelo, re.nombre, r.detalles, r.descrip_p, r.fecha_ing " +
                            "from reparacion r inner join cliente c on r.cedula = c.cedula inner join repacatalogo re on r.idtipo = re.idtipo " +
                            "where c.cedula = '" + txt_bCedula.Text + "'");
                        if (tabla.Rows.Count > 0)
                        {
                            dgv_Busqueda.DataSource = tabla;
                        }
                        else
                        {
                            MessageBox.Show("La reparacion no existe.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);//REVISA ESTA LINEA HOY QUE ESTA MAL
                        }
                    }
                }
                else
                {

                    btn_vEliminar.Enabled = true;
                    DataTable tabla;

                    tabla = sql.tablas("reparacion", "select c.nombre, c.cedula, r.modelo, re.nombre, r.detalles, r.descrip_p, r.fecha_ing " +
                        "from reparacion r inner join cliente c on r.cedula = c.cedula inner join repacatalogo re on r.idtipo = re.idtipo " +
                        "where r.codigo = '" + txt_bCodigo.Text + "'");
                    if (tabla.Rows.Count > 0)
                    {
                        dgv_Busqueda.DataSource = tabla;
                    }
                    else
                    {
                        MessageBox.Show("La reparacion no existe.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);//REVISA ESTA LINEA HOY QUE ESTA MAL
                    }
                }
            }
        }

        private void btn_vEliminar_Click(object sender, EventArgs e)
        {
            if (sql.multiple("delete from reparacion where cedula = '" + dgv_Busqueda.CurrentRow.Cells[1].Value.ToString() + "'"))
            {
                MessageBox.Show("Eliminado con exito");
            }
            else {
                MessageBox.Show("Error al eliminar");
            }
        }
    }
}
