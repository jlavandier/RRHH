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
    public partial class FrmExperiencias : Form
    {
        CDExperiencias Modelo = new CDExperiencias();
        private int IdExperienciaLab;
        private bool Editar = false;
        public FrmExperiencias()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuConsul con = new MenuConsul();
            con.Show();
        }

        private void FrmExperiencias_Load(object sender, EventArgs e)
        {
            MostrarExpe();
            criterio.SelectedIndex = 0;
        }
        #region
        private void MostrarExpe()
        {
            CDExperiencias mod = new CDExperiencias();
            dataGridView1.DataSource = mod.Mostrar();
        }
        private void limpiarForm()
        {
            textEmpresa.Clear();
            textPuestoocu.Text = "";
            pickerdes.Text = "";
            pickerhast.Text = "";
            textSalarioEx.Text = "";
        }
        #endregion
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (Editar == false)
            {

                if (Validar())
                {
                    Modelo.Insertar(textEmpresa.Text, textPuestoocu.Text, Convert.ToDateTime(pickerdes.Text), Convert.ToDateTime(pickerhast.Text), Convert.ToDouble(textSalarioEx.Text));
                    MessageBox.Show("se inserto correctamente");
                    MostrarExpe();
                    Borrar();
                    limpiarForm();
                }
             
            }

            //EDITAR
            if (Editar == true)
            {
                if (Validar())
                {
                    Modelo.Editar(textEmpresa.Text, textPuestoocu.Text, Convert.ToDateTime(pickerdes.Text), Convert.ToDateTime(pickerhast.Text), Convert.ToDouble(textSalarioEx.Text), IdExperienciaLab);
                    MessageBox.Show("se edito correctamente");
                    MostrarExpe();
                    Borrar();
                    limpiarForm();
                    Editar = false;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                IdExperienciaLab = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                textEmpresa.Text = dataGridView1.CurrentRow.Cells["Empresa"].Value.ToString();
                textPuestoocu.Text = dataGridView1.CurrentRow.Cells["Puesto"].Value.ToString();
                pickerdes.Text = dataGridView1.CurrentRow.Cells["FechaDesde"].Value.ToString();
                pickerhast.Text = dataGridView1.CurrentRow.Cells["FechaHasta"].Value.ToString();
                textSalarioEx.Text = dataGridView1.CurrentRow.Cells["Salario"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    IdExperienciaLab = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdExperienciaLab"].Value.ToString());
                    Modelo.Eliminar(IdExperienciaLab);
                    MessageBox.Show("Eliminado correctamente");
                    MostrarExpe();
                }
                else
                    MessageBox.Show("seleccione una fila por favor");
            }
            catch (Exception)
            {

                MessageBox.Show("Hay registros relacionados !!!!");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (criterio.SelectedIndex == 0)
                {
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=RRHH;Integrated Security=True");
                    con.Open();
                    string sql = "select * from ExperienciaLaboral where Empresa = '" + textBuscar.Text + "'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader rd;
                    rd = cmd.ExecuteReader();
                    con.Close();
                }
                else if (criterio.SelectedIndex == 1)
                {
                
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=RRHH;Integrated Security=True");
                    con.Open();
                    string sql ="select * from ExperienciaLaboral where Puesto = '" + textBuscar.Text + "'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource= dt;
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader rd;
                    rd = cmd.ExecuteReader();
                    con.Close();
                }
                else if (criterio.SelectedIndex == 2)
                {
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=RRHH;Integrated Security=True");
                    con.Open();
                    string sql = "select * from ExperienciaLaboral where Salario = '" + textBuscar.Text + "'";
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
                MessageBox.Show("Error al consultar"+ex);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            MostrarExpe();
            limpiarForm();
            textBuscar.Text = "";
        }
        private bool Validar()
        {
            bool ok = true;

            if (textEmpresa.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textEmpresa, "Ingrese la Empresa");
            }
            if (pickerhast.Value < pickerdes.Value)
            {
                ok = false;
                errorProvider1.SetError(pickerhast,"Fecha no puede ser Menor");
                errorProvider1.SetError(pickerdes,"Fecha no puede ser Mayor");
                
            }

            if (textPuestoocu.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textPuestoocu, "Ingrese el Puesto");
            }
            bool resultado = Regex.IsMatch(textEmpresa.Text, @"[a-zA-ZñÑ\s]");
            if (!resultado)
            {
                ok = false;
                errorProvider1.SetError(textEmpresa, "Solo Letras");
            }

            if (textSalarioEx.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textSalarioEx, "Ingrese un Salario");
            }

            bool resultadoN = Regex.IsMatch(textSalarioEx.Text, @"^[+]?([0-9]+(?:[\.][0-9]*)?|\.[0-9]+)$");
            if (!resultadoN)
            {

                ok = false;
                errorProvider1.SetError(textSalarioEx, "Solo Numeros Positivos");

            }

            bool resultador = Regex.IsMatch(textPuestoocu.Text, @"[a-zA-ZñÑ\s]");
            if (!resultador)
            {
                ok = false;
                errorProvider1.SetError(textPuestoocu, "Solo Letras");
            }


            return ok;

        }

        private void Borrar()
        {
            errorProvider1.SetError(textEmpresa, "");
            errorProvider1.SetError(textPuestoocu, "");
            errorProvider1.SetError(textSalarioEx, "");
            errorProvider1.SetError(pickerdes, "");
            errorProvider1.SetError(pickerhast, "");
           
        }


    }
}


