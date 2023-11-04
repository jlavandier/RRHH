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

namespace Sistema_Recursos_Humanos.PRESENTACION
{
    public partial class FrmSeleccion : Form
    {
        CDSeleccion cd = new CDSeleccion();
        public FrmSeleccion()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuAdmin menu = new MenuAdmin();
            menu.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEmpleados emp = new FrmEmpleados();
            emp.Show();
        }
        #region
        private void Puestos()
        {
            CmPuesto.DataSource = cd.ListarPuestos();
            CmPuesto.DisplayMember = "Ocupación";
            CmPuesto.ValueMember = "ID";
        }

        public void Limpiar()
        {
            textCedula.Clear();
            textsalario.Clear();
           
        }
        #endregion
       

        private void FrmSeleccion_Load(object sender, EventArgs e)
        {
            Puestos();
            CbDepartamento.SelectedIndex = 0;
            CbEstado.SelectedIndex = 0;
        }

     
        private void textCedula_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0G71LL0\\SQLEXPRESS;Initial Catalog=RRHH;Integrated Security=True");
            con.Open();
            string sql = "select * from Candidatos where Cedula = '" + textCedula.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd;
            rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                cmCandidato.Text = rd["Nombre"].ToString();
                CmPuesto.SelectedValue = rd["PuestoAspira"].ToString();
         
            }
            con.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-0G71LL0\\SQLEXPRESS;Initial Catalog=RRHH;Integrated Security=True");
                con.Open();
                string sql = "";
            if (Validar())
            {
                sql += "Insert into Empleados";
                sql += "(Identificacion,Nombre,FechaIngreso,area,Puesto,SalarioMensual,Disponibilidad)";
                sql += "values('" + textCedula.Text + "','" + cmCandidato.Text + "','" + Convert.ToDateTime(dateTimePicker1.Text) + "','" + CbDepartamento.Text + "','" + CmPuesto.Text + "','" + Convert.ToDouble(textsalario.Text) + "','" + CbEstado.Text + "');";

                sql += "Delete From Candidatos where Cedula='" + textCedula.Text + "';";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.ExecuteNonQuery();
                Borrar();
                Limpiar();


                con.Close();
            }

        }
        private bool Validar()
        {
            bool ok = true;
            if (textCedula.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textCedula, "Ingrese la Cedula");
            }
            if (!validaCedula(textCedula.Text))
            {
                ok = false;
                errorProvider1.SetError(textCedula, "Cedula no aceptada");
            }
            
            if (textsalario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textsalario, "Ingrese el salario Mensual");
            }
            bool resultadoN = Regex.IsMatch(textsalario.Text, @"^[+]?([0-9]+(?:[\.][0-9]*)?|\.[0-9]+)$");
            if (!resultadoN)
            {

                ok = false;
                errorProvider1.SetError(textsalario, "Solo Numeros Positivos");

            }
            return ok;
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
        private void Borrar()
        {
            errorProvider1.SetError(textCedula, "");
            errorProvider1.SetError(textsalario, "");
            


        }

        private void cmCandidato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
