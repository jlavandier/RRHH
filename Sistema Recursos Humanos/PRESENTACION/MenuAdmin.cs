using Sistema_Recursos_Humanos.PRESENTACION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Recursos_Humanos
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void timermenu_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblfecha.Text = DateTime.Now.ToString("dddd MMM yyy");
        }

      
        private void MenuAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FrmUsuarios USU = new FrmUsuarios();
            USU.Show();
        }

        private void BtnPuestos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPuestos puestos = new FrmPuestos();
            puestos.Show();
        }

        private void btnseleccion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSeleccion Aprobado = new FrmSeleccion();
            Aprobado.Show();

        }

        private void btnCompetencias_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCompetencias Comp = new FrmCompetencias();
            Comp.Show();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEmpleados Emp = new FrmEmpleados();
            Emp.Show();
        }

        private void btnIdiomas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmIdiomas Idi = new FrmIdiomas();
            Idi.Show();
        }

        private void btnCapacitaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCapacitacion cap = new FrmCapacitacion();
            cap.Show();
        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
