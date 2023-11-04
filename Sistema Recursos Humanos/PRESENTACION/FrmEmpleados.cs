using Sistema_Recursos_Humanos.DATOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Recursos_Humanos.PRESENTACION
{
    public partial class FrmEmpleados : Form
    {
        CDEmpleados db = new CDEmpleados();
        string IdEmpleado;
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdmin menu = new MenuAdmin();
            menu.Show();
        }

        #region
        void MostrarEmpleados()
        {
            dataGridView1.DataSource = db.MostrarEmpleados();
        }
        #endregion
        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
            cmCriterio.SelectedIndex = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    db._IdEmpleado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    db.Eliminar();
                    MessageBox.Show("Se elimino satisfactoriamente");
                    MostrarEmpleados();
                }
                else
                    MessageBox.Show("seleccione una fila por favor");
            }
            catch (Exception)
            {

                MessageBox.Show("Hay datos relacionados");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmCriterio.SelectedIndex == 0)
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-0G71LL0\\SQLEXPRESS;Initial Catalog=RRHH;Integrated Security=True");
                    con.Open();
                    string sql = "select * from Empleados where Nombre = '" + textBuscar.Text + "'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader rd;
                    rd = cmd.ExecuteReader();
                    con.Close();
                }
                else if (cmCriterio.SelectedIndex == 1)
                {

                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-0G71LL0\\SQLEXPRESS;Initial Catalog=RRHH;Integrated Security=True");
                    con.Open();
                    string sql = "select * from Empleados where Puesto = '" + textBuscar.Text + "'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader rd;
                    rd = cmd.ExecuteReader();
                    con.Close();
                }
               
                else if (cmCriterio.SelectedIndex == 2)
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-0G71LL0\\SQLEXPRESS;Initial Catalog=RRHH;Integrated Security=True");
                    con.Open();
                    string sql = "select * from Empleados where area = '" + textBuscar.Text + "'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader rd;
                    rd = cmd.ExecuteReader();
                    con.Close();
                }
                else if (cmCriterio.SelectedIndex == 3)
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-0G71LL0\\SQLEXPRESS;Initial Catalog=RRHH;Integrated Security=True");
                    con.Open();
                    string sql = "select * from Empleados where SalarioMensual = '" + textBuscar.Text + "'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader rd;
                    rd = cmd.ExecuteReader();
                    con.Close();
                }
                else if (cmCriterio.SelectedIndex == 4)
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-0G71LL0\\SQLEXPRESS;Initial Catalog=RRHH;Integrated Security=True");
                    con.Open();
                    string sql = "select * from Empleados where Identificacion = '" + textBuscar.Text + "'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader rd;
                    rd = cmd.ExecuteReader();
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar" + ex);
            }
        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            MostrarEmpleados();
            textBuscar.Clear();
        }

      private void button1_Click(object sender, EventArgs e)
        {
          this.Hide();
            FrmInforme rep = new FrmInforme();
            rep.Show();
        }

    }
}