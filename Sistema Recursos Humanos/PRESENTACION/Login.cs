
using Sistema_Recursos_Humanos.PRESENTACION;
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

namespace Sistema_Recursos_Humanos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string Codigo = "";
        /*
          private void textusuario_KeyPress(object sender, KeyPressEventArgs e)
          {
              if (e.KeyChar == (char)13)//Enter key
                  textclave.Focus();
          }

          private void textclave_KeyPress(object sender, KeyPressEventArgs e)
          {
              if (e.KeyChar == (char)13)
                  btnLogin.PerformClick();
          }
          */
        
        SqlConnection db = new SqlConnection(@"Server=DESKTOP-0G71LL0\SQLEXPRESS;DataBase=RRHH;Integrated Security=true");
        public void login(string cuenta, string contrasena)
        {

            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand("SELECT Cuenta,Rol FROM Usuarios WHERE Cuenta=@cuenta AND Contrasena=@contrasena", db);
                cmd.Parameters.AddWithValue("Cuenta", cuenta);
                cmd.Parameters.AddWithValue("Contrasena", contrasena);
                SqlDataAdapter rd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                rd.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        FrmUsuarios Men = new FrmUsuarios();
                        Men.Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "Consultor")
                    {
                        MenuConsul Menc = new MenuConsul();
                        Menc.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o Clave incorrecta");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                db.Close();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login(this.textusuario.Text, this.textclave.Text);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}


