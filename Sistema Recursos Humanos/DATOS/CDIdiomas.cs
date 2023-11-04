using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Recursos_Humanos.DATOS
{
    public class CDIdiomas
    {
        private MiConexion db = new MiConexion();

        SqlDataReader rd;
        SqlCommand cmd = new SqlCommand();
        private int IdIdioma;
        private string idioma;
        private string Estado;


        //metodos get y set
        public int _IdIdioma
        {
            get { return _IdIdioma; }
            set { IdIdioma = value; }
        }
        public string _idioma
        {
            get { return _idioma; }
            set { idioma = value; }
        }
        public string _Estado
        {
            get { return _Estado; }
            set { Estado = value; }
        }

        public DataTable MostrarIdiomas()
        {

            DataTable Tabla = new DataTable();
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "Listaridioma";
            cmd.CommandType = CommandType.StoredProcedure;
            rd = cmd.ExecuteReader();
            Tabla.Load(rd);
            rd.Close();
            db.CerrarConexion();
            return Tabla;

        }

        public void InsertarIdiomas()
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "Insertaridiomas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idioma", idioma);
            cmd.Parameters.AddWithValue("@Disponibilidad", Estado);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void EditarIdiomas()
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "update Idiomas set idioma = '" + idioma + "', Disponibilidad = '" + Estado + "' WHERE IdIdioma = " + IdIdioma;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            db.CerrarConexion();
        }
        public void EliminarIdiomas()
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "delete Idiomas  where IdIdioma=" + IdIdioma;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            db.CerrarConexion();
        }
    }
}
