using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Recursos_Humanos.DATOS
{
    public class CDCompetencias
    {
        private MiConexion db = new MiConexion();

        SqlDataReader rd;
        SqlCommand cmd = new SqlCommand();
        private int IdCompetencia;
        private string Descripcion;
        private string Estado;


        //metodos get y set
        public int _IdCompetencia
        {
            get { return _IdCompetencia; }
            set { IdCompetencia = value; }
        }
        public string _Descripcion
        {
            get { return _Descripcion; }
            set { Descripcion = value; }
        }
        public string _Estado
        {
            get { return _Estado; }
            set { Estado = value; }
        }
        
        public DataTable MostrarCompetencias()
        {

            DataTable Tabla = new DataTable();
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "ListarComp";
            cmd.CommandType = CommandType.StoredProcedure;
            rd = cmd.ExecuteReader();
            Tabla.Load(rd);
            rd.Close();
            db.CerrarConexion();
            return Tabla;

        }

        public void InsertarCom()
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "InsertarComp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void EditarCom()
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "update Competencias set Descripcion = '" + Descripcion + "', Estado = '" + Estado + "' WHERE IdCompetencia = " + IdCompetencia;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            db.CerrarConexion();
        }
        public void EliminarCom()
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "delete Competencias where IdCompetencia=" + IdCompetencia;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            db.CerrarConexion();
        }
    }
}
