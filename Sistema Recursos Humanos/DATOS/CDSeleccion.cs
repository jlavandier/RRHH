using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Recursos_Humanos.DATOS
{
    public  class CDSeleccion
    {
        private MiConexion db = new MiConexion();

        SqlDataReader rd;
        SqlCommand cmd = new SqlCommand();

        public DataTable ListarPuestos()
        {

            DataTable Tabla = new DataTable();
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "ListarPuesto";
            cmd.CommandType = CommandType.StoredProcedure;
            rd = cmd.ExecuteReader();
            Tabla.Load(rd);
            rd.Close();
            db.CerrarConexion();
            return Tabla;
        }
        public DataTable MostrarCan()
        {

            DataTable Tabla = new DataTable();
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "ListarCandidatos";
            cmd.CommandType = CommandType.StoredProcedure;
            rd = cmd.ExecuteReader();
            Tabla.Load(rd);
            rd.Close();
            db.CerrarConexion();
            return Tabla;

        }
    }
}
