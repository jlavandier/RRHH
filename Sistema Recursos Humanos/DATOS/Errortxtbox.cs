using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Recursos_Humanos.Datos
{
    public partial class Errortxtbox : TextBox
    {
        public Errortxtbox()
        {
            InitializeComponent();
        }
        public Boolean Validar{
            set;
            get;
        }
        public Boolean SoloNumeros{
            set;
            get;
        }
       

    }
}
