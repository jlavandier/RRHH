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
    public partial class FrmCandidatos : Form
    {
        CDCandidatos cd = new CDCandidatos();
        string IdCandidato;
        string Operacion = "Insertar";


        public FrmCandidatos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuConsul con = new MenuConsul();
            con.Show();
        }

        private void FrmCandidatos_Load(object sender, EventArgs e)
        {
            MostrarCan();
            ListarPuestos();
            ListarIdiomas();
            ListarCapacitaciones();
            ListarCompetencias();
            ListarExperiencia();
            cbxCriterio.SelectedIndex = 0;

        }
        #region
        private void ListarCapacitaciones()
        {
            CDCandidatos cd = new CDCandidatos();
            CbCapacitaciones.DataSource = cd.ListarCapaci();
            CbCapacitaciones.DisplayMember = "Descripción";
            CbCapacitaciones.ValueMember = "ID";
        }

        private void ListarCompetencias()
        {
            CDCandidatos cd = new CDCandidatos();
            CbCompetencias.DataSource = cd.ListarComp();
            CbCompetencias.DisplayMember = "Descripción";
            CbCompetencias.ValueMember = "ID";
        }

        private void ListarPuestos()
        {
            CDCandidatos cd = new CDCandidatos();
            CmPuesto.DataSource = cd.ListarPuestos();
            CmPuesto.DisplayMember = "Ocupación";
            CmPuesto.ValueMember = "ID";
        }

        private void ListarIdiomas()
        {
            CDCandidatos cd = new CDCandidatos();
            cbidioma.DataSource = cd.Listaridiomas();
            cbidioma.DisplayMember = "Descripción";
            cbidioma.ValueMember = "ID";
        }

        private void ListarExperiencia()
        {
            CDCandidatos cd = new CDCandidatos();
            CbExperilab.DataSource = cd.Listarex();
            CbExperilab.DisplayMember = "Puesto";
            CbExperilab.ValueMember = "ID";
        }
        private void MostrarCan()
        {
            CDCandidatos mod = new CDCandidatos();
            dataGridView1.DataSource = mod.MostrarCan();
        }
        private void limpiarForm()
        {
            textCedula.Clear();
            textNombre.Text = "";
            CmPuesto.Text = "";
            cmdepartamento.Text = "";
            textAspira.Text = "";
            CbCompetencias.Text = "";
            CbCapacitaciones.Text = "";
            CbExperilab.Text = "";
            cbidioma.Text = "";
            textRecomendado.Text = "";
        }
        #endregion

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (Operacion == "Insertar")
            {

                if (Validar())
                {
                    cd._Cedula = textCedula.Text;
                    cd._Nombre = textNombre.Text;
                    cd._PuestoAspira = Convert.ToInt32(CmPuesto.SelectedValue);
                    cd._Departamento = cmdepartamento.Text;
                    cd._SalarioAspira = Convert.ToDouble(textAspira.Text);
                    cd._Competencias = Convert.ToInt32(CbCompetencias.SelectedValue);
                    cd._Capacitaciones = Convert.ToInt32(CbCapacitaciones.SelectedValue);
                    cd._Experiencia = Convert.ToInt32(CbExperilab.SelectedValue);
                    cd._Recomendacion = textRecomendado.Text;
                    cd._Idioma = Convert.ToInt32(cbidioma.SelectedValue);
                    cd.InsertarCan();
                    MessageBox.Show("Se inserto correctamente");
                    Borrar();
                    limpiarForm();
                    MostrarCan();
                }

            }


            else if (Operacion == "Editar")
            {
                if (Validar()){ 
                    cd._IdCandidato = Convert.ToInt32(IdCandidato);
                cd._Cedula = textCedula.Text;
                cd._Nombre = textNombre.Text;
                cd._PuestoAspira = Convert.ToInt32(CmPuesto.SelectedValue);
                cd._Departamento = cmdepartamento.Text;
                cd._SalarioAspira = Convert.ToDouble(textAspira.Text);
                cd._Competencias = Convert.ToInt32(CbCompetencias.SelectedValue);
                cd._Capacitaciones = Convert.ToInt32(CbCapacitaciones.SelectedValue);
                cd._Experiencia = Convert.ToInt32(CbExperilab.SelectedValue);
                cd._Recomendacion = textRecomendado.Text;
                cd._Idioma = Convert.ToInt32(cbidioma.SelectedValue);



                cd.EditarC();
                Operacion = "Insertar";
                MessageBox.Show("Se edito correctamente");
                limpiarForm();
                Borrar();
                MostrarCan();
            }
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                    Operacion = "Editar";
                    IdCandidato = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                    textCedula.Text = dataGridView1.CurrentRow.Cells["cédula"].Value.ToString();
                    textNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                    CmPuesto.Text = dataGridView1.CurrentRow.Cells["Puesto"].Value.ToString();
                    cmdepartamento.Text = dataGridView1.CurrentRow.Cells["Departamento"].Value.ToString();
                    textAspira.Text = dataGridView1.CurrentRow.Cells["SalarioAspira"].Value.ToString();
                    CbCompetencias.Text = dataGridView1.CurrentRow.Cells["Competencias"].Value.ToString();
                    CbCapacitaciones.Text = dataGridView1.CurrentRow.Cells["Capacitacion"].Value.ToString();
                    CbExperilab.Text = dataGridView1.CurrentRow.Cells["Experiencia"].Value.ToString();
                    textRecomendado.Text = dataGridView1.CurrentRow.Cells["Recomendacion"].Value.ToString();
                    cbidioma.Text = dataGridView1.CurrentRow.Cells["Idioma"].Value.ToString();
               
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
                    cd._IdCandidato = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    cd.Eliminar();
                    MessageBox.Show("Se elimino satisfactoriamente");
                    MostrarCan();
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
                if (cbxCriterio.SelectedIndex == 0)
                {
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=RRHH;Integrated Security=True");
                    con.Open();
                    string sql = "select * from Candidatos where Nombre = '" + textBuscar.Text + "'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader rd;
                    rd = cmd.ExecuteReader();
                    con.Close();
                }
                else if (cbxCriterio.SelectedIndex == 1)
                {

                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=RRHH;Integrated Security=True");
                    con.Open();
                    string sql = "select * from Candidatos where Cedula = '" + textBuscar.Text + "'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader rd;
                    rd = cmd.ExecuteReader();
                    con.Close();
                }
                else if (cbxCriterio.SelectedIndex == 2)
                {
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=RRHH;Integrated Security=True");
                    con.Open();
                    string sql = "select * from Candidatos where SalarioAspira = '" + textBuscar.Text + "'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader rd;
                    rd = cmd.ExecuteReader();
                    con.Close();
                }
                else if (cbxCriterio.SelectedIndex == 3)
                {
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=RRHH;Integrated Security=True");
                    con.Open();
                    string sql = "select * from Candidatos where Idioma = '" + textBuscar.Text + "'";
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
            MostrarCan();
            limpiarForm();
            textBuscar.Text = "";
        }
        private bool Validar()
        {
            bool ok = true;

            if (textCedula.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textCedula, "Ingrese la  Cédula");
            }
            if (!validaCedula(textCedula.Text))
            {
                ok = false;
                errorProvider1.SetError(textCedula, "Cedula no aceptada");
            }

            if (textNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textNombre, "Ingrese el Nombre");
            }
            bool resultado = Regex.IsMatch(textNombre.Text, @"[a-zA-ZñÑ\s]");
            if (!resultado)
            {
                ok = false;
                errorProvider1.SetError(textNombre, "Solo Letras");
            }

            if (textAspira.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textAspira, "Ingrese un Salario");
            }

            bool resultadoN = Regex.IsMatch(textAspira.Text, @"^[+]?([0-9]+(?:[\.][0-9]*)?|\.[0-9]+)$");
            if (!resultadoN)
            {
               
                    ok = false;
                    errorProvider1.SetError(textAspira, "Solo Numeros Positivos");
                
            }


            if (textRecomendado.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textRecomendado, "Ingrese el Nombre");
            }
            bool resultador = Regex.IsMatch(textRecomendado.Text, @"[a-zA-ZñÑ\s]");
            if (!resultador)
            {
                ok = false;
                errorProvider1.SetError(textRecomendado, "Solo Letras");
            }


            return ok;

        }
        private void Borrar()
        {
            errorProvider1.SetError(textCedula, "");
            errorProvider1.SetError(textNombre, "");
            errorProvider1.SetError(CmPuesto, "");
            errorProvider1.SetError(cmdepartamento, "");
            errorProvider1.SetError(textAspira, "");
            errorProvider1.SetError(CbCompetencias, "");
            errorProvider1.SetError(CbCapacitaciones, "");
            errorProvider1.SetError(CbExperilab, "");
            errorProvider1.SetError(cbidioma, "");
            errorProvider1.SetError(textRecomendado, "");
        }
        public static bool validaCedula(string pCedula)

        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }
        
    }
}
