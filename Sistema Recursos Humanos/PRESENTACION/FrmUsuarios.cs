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
    public partial class FrmUsuarios : Form
    {
        CDUsuarios Modelo = new CDUsuarios();
        private int IdUsuario;
        private bool Editar = false;

        public FrmUsuarios()
        {
            InitializeComponent();
            Cbrol.SelectedIndex = 0;
            
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }
        #region
        private void MostrarUsuarios()
        {
            CDUsuarios mod = new CDUsuarios();
            dataGridView1.DataSource = mod.Mostrar();
        }
        private void limpiarForm()
        {
            textcuenta.Clear();
            textclave.Text = "";
            Cbrol.Text = "";
           
        }
        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                if (Validar())
                {
                    Modelo.Insertar(textcuenta.Text, textclave.Text, Cbrol.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarUsuarios();
                    Borrar();
                    limpiarForm();
                }
            }
            //EDITAR
            if (Editar == true)
            {
                if (Validar())
                {
                    Modelo.Editar(textcuenta.Text, textclave.Text, Cbrol.Text, Convert.ToInt32(IdUsuario));
                    MessageBox.Show("se edito correctamente");
                    MostrarUsuarios();
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
                IdUsuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdUsuario"].Value.ToString());
                textcuenta.Text = dataGridView1.CurrentRow.Cells["Cuenta"].Value.ToString();
                textclave.Text = dataGridView1.CurrentRow.Cells["Contrasena"].Value.ToString();
                Cbrol.Text = dataGridView1.CurrentRow.Cells["Rol"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                IdUsuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdUsuario"].Value.ToString());
                Modelo.Eliminar(IdUsuario);
                MessageBox.Show("Eliminado correctamente");
                MostrarUsuarios();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdmin men = new MenuAdmin();
            men.Show();
        }

        private void FrmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }
        private bool Validar()
        {
            bool ok = true;
            if(textcuenta.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textcuenta, "Ingrese el Nombre de la Cuenta");
            }
            if (textclave.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textclave, "Ingrese la Clave de la Cuenta");
            }
            return ok;
        }
        private void Borrar()
        {
            errorProvider1.SetError(textcuenta, "");
            errorProvider1.SetError(textclave, "");
            
        }
    }
    }

