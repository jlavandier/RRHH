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
    public partial class MenuConsul : Form
    {
        public MenuConsul()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblfecha.Text = DateTime.Now.ToString("dddd MMM yyy");
        }

        private void BtnCandidatos_Click(object sender, EventArgs e)
        {
            this.Hide();    
            FrmCandidatos frm = new FrmCandidatos();
            frm.Show();

        }

        private void btnExperiencia_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmExperiencias ex = new FrmExperiencias();
            ex.Show();

        }

        private void MenuConsul_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
