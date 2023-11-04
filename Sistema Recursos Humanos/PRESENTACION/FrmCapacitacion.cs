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
    public partial class FrmCapacitacion : Form
    {
        CDCapacitaciones cd = new CDCapacitaciones();
        string IdCapacitaciones;
        string Operacion = "Insertar";
        public FrmCapacitacion()
        {
            InitializeComponent();
        }

        private void BaseMant_Load(object sender, EventArgs e)
        {
            MostrarCapa();
            cmCriterio.SelectedIndex = 0;
            CmNivel.SelectedIndex = 0;
            
        }
        #region
        private void MostrarCapa()
        {
            dataGridView1.DataSource = cd.MostrarCapacitaciones();
        }
        private void limpiarForm()
        {
            textDescripcion.Clear();
            CmNivel.Text = "";
            DtDesde.Text = "";
            DtHasta.Text = "";
            textInstitusion.Text = "";
        }
        #endregion
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuAdmin menu = new MenuAdmin();
            menu.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Operacion == "Insertar")
            {
                if (Validar())
                {
                    cd._Descripcion = textDescripcion.Text;
                    cd._Nivel = CmNivel.Text;
                    cd._FechaDesde = Convert.ToDateTime(DtDesde.Value);
                    cd._FechaHasta = Convert.ToDateTime(DtHasta.Value);
                    cd._Institucion = textInstitusion.Text;
                    cd.InsertarCapa();
                    MostrarCapa();
                    limpiarForm();
                    Borrar();
                    MessageBox.Show("Se inserto correctamente");
                }
            }
            else if (Operacion == "Editar")
            {
                if (Validar())
                {
                    cd._IdCapacitaciones = Convert.ToInt32(IdCapacitaciones);
                    cd._Descripcion = textDescripcion.Text;
                    cd._Nivel = CmNivel.Text;
                    cd._FechaDesde = Convert.ToDateTime(DtDesde.Value);
                    cd._FechaHasta = Convert.ToDateTime(DtHasta.Value);
                    cd._Institucion = textInstitusion.Text;
                    cd.EditarCapa();
                    Operacion = "Insertar";
                    MostrarCapa();
                    limpiarForm();
                    Borrar();
                    MessageBox.Show("Se edito correctamente");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Operacion = "Editar";
                IdCapacitaciones = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                textDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripción"].Value.ToString();
                CmNivel.Text = dataGridView1.CurrentRow.Cells["Nivel"].Value.ToString();
                DtDesde.Text = dataGridView1.CurrentRow.Cells["Desde"].Value.ToString();
                DtHasta.Text = dataGridView1.CurrentRow.Cells["Hasta"].Value.ToString();
                textInstitusion.Text = dataGridView1.CurrentRow.Cells["institución"].Value.ToString();
    
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
                    cd._IdCapacitaciones = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    cd.EliminarCapa();
                    MessageBox.Show("Se elimino satisfactoriamente");
                    MostrarCapa();
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
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=RRHH;Integrated Security=True");
                    con.Open();
                    string sql = "select * from Capacitaciones where Descripcion = '" + textBuscar.Text + "'";
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
                    string sql = "select * from Capacitaciones where Nivel = '" + textBuscar.Text + "'";
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
                    string sql = "select * from Capacitaciones where Institucion = '" + textBuscar.Text + "'";
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
            textBuscar.Clear();
            MostrarCapa();
        }
        private bool Validar()
        {
            bool ok = true;

            if (textDescripcion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textDescripcion, "Ingrese una descripcion");
            }
            bool resultado = Regex.IsMatch(textDescripcion.Text, @"[a-zA-ZñÑ\s]");
            if (!resultado)
            {
                ok = false;
                errorProvider1.SetError(textDescripcion, "Solo Letras");
            }
            if (textInstitusion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textInstitusion, "Ingrese el Nombre");
            }
            bool resultadon = Regex.IsMatch(textInstitusion.Text, @"[a-zA-ZñÑ\s]");
            if (!resultadon)
            {
                ok = false;
                errorProvider1.SetError(textInstitusion, "Solo Letras");
            }
            if (DtHasta.Value < DtDesde.Value)
            {
                ok = false;
                errorProvider1.SetError(DtHasta, "Fecha no puede ser Menor");
                errorProvider1.SetError(DtDesde, "Fecha no puede ser Mayor");

            }

            return ok;

        }
        private void Borrar()
        {
            errorProvider1.SetError(textDescripcion,"");
            errorProvider1.SetError(textInstitusion,"");
            errorProvider1.SetError(DtDesde,"");
            errorProvider1.SetError(DtHasta,"");
        }
    }
}
