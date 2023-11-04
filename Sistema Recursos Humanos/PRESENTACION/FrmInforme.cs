using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Recursos_Humanos.PRESENTACION
{
    public partial class FrmInforme : Form
    {
        public FrmInforme()
        {
            InitializeComponent();
        }
        public DateTime Fecha1 { get; set; }
        public DateTime Fecha2 { get; set; }

        private void FrmInforme_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1154, 610);
            this.reportesTableAdapter.Fill(this.datareporte.reportes, Fecha1, Fecha2);
            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime Fecha1 = Desde.Value;
            DateTime Fecha2 = Hasta.Value;
            this.reportesTableAdapter.Fill(this.datareporte.reportes, Fecha1, Fecha2);
            this.reportViewer1.RefreshReport();

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEmpleados ad = new FrmEmpleados();
            ad.Show();
        }
    }
}
