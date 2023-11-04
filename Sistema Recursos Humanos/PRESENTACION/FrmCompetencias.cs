using Sistema_Recursos_Humanos.DATOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Recursos_Humanos
{
    public partial class FrmCompetencias : Form
    {
        CDCompetencias cd = new CDCompetencias();
        string IdCompetencia;
        string Operacion = "Insertar";
        public FrmCompetencias()
        {
            InitializeComponent();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuAdmin menu = new MenuAdmin();
            menu.Show();
        }
        #region
        private void MostrarCom()
        {
            dataGridView1.DataSource = cd.MostrarCompetencias();
        }
        private void limpiarForm()
        {
            textBox1.Clear();
            cbEstado.Text = "";
        }
        #endregion

        private void FrmCompetencias_Load(object sender, EventArgs e)
        {
            MostrarCom();
            cbEstado.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Operacion == "Insertar")
            {
                if (Validar())
                {
                    cd._Descripcion = textBox1.Text;
                    cd._Estado = cbEstado.Text;
                    cd.InsertarCom();
                    MostrarCom();
                    limpiarForm();
                    Borrar();
                    MessageBox.Show("Se inserto correctamente");
                }
            }
            else if (Operacion == "Editar")
            {
                if (Validar())
                {

                    cd._IdCompetencia = Convert.ToInt32(IdCompetencia);
                    cd._Descripcion = textBox1.Text;
                    cd._Estado = cbEstado.Text;

                    cd.EditarCom();
                    Operacion = "Insertar";
                    limpiarForm();
                    Borrar();
                    MostrarCom();
                    MessageBox.Show("Se edito correctamente");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Operacion = "Editar";
                IdCompetencia = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells["Descripción"].Value.ToString();
                cbEstado.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();

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
                    cd._IdCompetencia = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    cd.EliminarCom();
                    MessageBox.Show("Se elimino satisfactoriamente");
                    MostrarCom();
                }
                else
                    MessageBox.Show("seleccione una fila por favor");
            }
            catch (Exception)
            {

                MessageBox.Show("Hay datos relacionados");
            }
        }
        private bool Validar()
        {
            bool ok = true;

            if (textBox1.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox1, "Ingrese el Nombre");
            }
            bool resultado = Regex.IsMatch(textBox1.Text, @"[a-zA-ZñÑ\s]");
            if (!resultado)
            {
                ok = false;
                errorProvider1.SetError(textBox1, "Solo Letras");
            }

            

            return ok;

        }
        private void Borrar()
        {
            errorProvider1.SetError(textBox1, "");
           
          
        }
    }
}
