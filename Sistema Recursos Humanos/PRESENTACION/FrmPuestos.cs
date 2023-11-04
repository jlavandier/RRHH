using Sistema_Recursos_Humanos.DATOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Recursos_Humanos
{
    public partial class FrmPuestos : Form
    {
        CDPuestos cd = new CDPuestos();
        string IdPuesto;
        string Operacion = "Insertar";
        public FrmPuestos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuAdmin menu = new MenuAdmin();
            menu.Show();
        }
        #region
        private void ListarPuestos()
        {
            CDPuestos cd = new CDPuestos();
            dataGridView1.DataSource = cd.ListarPuestos();
            cbestado.SelectedIndex = 0;
            cbIdiomas.SelectedIndex = 0;
            cmCriterio.SelectedIndex = 0;
            cmriesgo.SelectedIndex = 0;
            
        }

        private void ListarIdiomas()
        {
            CDPuestos cd = new CDPuestos();
            cbIdiomas.DataSource = cd.Listaridiomas();
            cbIdiomas.DisplayMember = "Descripción";
            cbIdiomas.ValueMember = "ID";
        }
        private void limpiarForm()
        {
            textNombre.Clear();
            cmriesgo.Text = "";
            textSminimo.Text = "";
            textSmaximo.Text = "";
            cbIdiomas.Text = "";
            cbestado.Text = "";
        }
        #endregion
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Operacion == "Insertar")
            {
                if (Validar())
                {
                    cd._Ocupacion = textNombre.Text;
                    cd._NivelRiesgo = cmriesgo.Text;
                    cd._SalarioMinimo = Convert.ToDouble(textSminimo.Text);
                    cd._SalarioMaximo = Convert.ToDouble(textSmaximo.Text);
                    cd._idiomas = Convert.ToInt32(cbIdiomas.SelectedValue);
                    cd._Estado = cbestado.Text;
                    cd.InsertarPues();
                    limpiarForm();
                    Borrar();
                    ListarPuestos();
                    MessageBox.Show("Se inserto correctamente");
                }
            }
            else if (Operacion == "Editar")
            {
                if (Validar())
                {
                    cd._IdPuesto = Convert.ToInt32(IdPuesto);
                    cd._Ocupacion = textNombre.Text;
                    cd._NivelRiesgo = cmriesgo.Text;
                    cd._SalarioMinimo = Convert.ToDouble(textSminimo.Text);
                    cd._SalarioMaximo = Convert.ToDouble(textSmaximo.Text);
                    cd._idiomas = Convert.ToInt32(cbIdiomas.SelectedValue);
                    cd._Estado = cbestado.Text;
                    cd.EditarPues();
                    Operacion = "Insertar";
                    ListarPuestos();
                    MessageBox.Show("Se edito correctamente");
                    limpiarForm();
                    Borrar();
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    cd._IdPuesto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    cd.EliminarPues();
                    MessageBox.Show("Se elimino satisfactoriamente");
                    ListarPuestos();
                }
                else
                    MessageBox.Show("seleccione una fila por favor");

            }
            catch (Exception)
            {

                MessageBox.Show("Hay datos relacionados !!!!");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Operacion = "Editar";
                IdPuesto = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                textNombre.Text = dataGridView1.CurrentRow.Cells["Ocupación"].Value.ToString();
                cmriesgo.Text = dataGridView1.CurrentRow.Cells["Riesgo"].Value.ToString();
                textSminimo.Text = dataGridView1.CurrentRow.Cells["SalarioMinimo"].Value.ToString();
                textSmaximo.Text = dataGridView1.CurrentRow.Cells["SalarioMaximo"].Value.ToString();
                cbIdiomas.Text = dataGridView1.CurrentRow.Cells["Idioma"].Value.ToString();
                cbestado.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
                
            }
            else
                MessageBox.Show("seleccione una fila por favor");

        }

        private void FrmPuestos_Load(object sender, EventArgs e)
        {
            ListarIdiomas();
            ListarPuestos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmCriterio.SelectedIndex == 0)
                {
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=RRHH;Integrated Security=True");
                    con.Open();
                    string sql = "select * from Puestos where Ocupacion = '" + textbuscar.Text + "'";
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

                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=RRHH;Integrated Security=True");
                    con.Open();
                    string sql = "select * from Puestos where Idioma = '" + textbuscar.Text + "'";
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
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=RRHH;Integrated Security=True");
                    con.Open();
                    string sql = "select * from Puestos where Riesgo = '" + textbuscar.Text + "'";
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

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ListarPuestos();
            limpiarForm();
            textbuscar.Clear();
        }
        private bool Validar()
        {
            bool ok = true;
            if (textNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textNombre, "Ingrese el Nombre");
            }
            bool resultador = Regex.IsMatch(textNombre.Text, @"[a-zA-ZñÑ\s]");
            if (!resultador)
            {
                ok = false;
                errorProvider1.SetError(textNombre, "Solo Letras");
            }
            if (textSminimo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textSminimo, "Ingrese el salario minimo");
            }
            if (textSmaximo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textSmaximo, "Ingrese el salario maximo");
            }
           
            bool resultadoN = Regex.IsMatch(textSminimo.Text, @"^[+]?([0-9]+(?:[\.][0-9]*)?|\.[0-9]+)$");
            if (!resultadoN)
            {

                ok = false;
                errorProvider1.SetError(textSminimo, "Solo Numeros Positivos");

            }
           
            
            bool resultadoNn = Regex.IsMatch(textSmaximo.Text, @"^[+]?([0-9]+(?:[\.][0-9]*)?|\.[0-9]+)$");
            if (!resultadoNn)
            {

                ok = false;
                errorProvider1.SetError(textSmaximo, "Solo Numeros Positivos");

            }
          
            return ok;
        }
        private void Borrar()
        {
            errorProvider1.SetError(textNombre, "");
            errorProvider1.SetError(textSmaximo, "");
            errorProvider1.SetError(textSminimo, "");
          

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
