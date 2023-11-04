using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Recursos_Humanos.DATOS
{
    public class CDEmpleados
    {
        private MiConexion db = new MiConexion();
        SqlDataReader rd;
        SqlCommand cmd = new SqlCommand();

        private int IdEmpleado;
        public int _IdEmpleado
        {
            get { return IdEmpleado; }
            set { IdEmpleado = value; }
        }
        public DataTable MostrarEmpleados()
        {

            DataTable Tabla = new DataTable();
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "MostrarEmpleados";
            cmd.CommandType = CommandType.StoredProcedure;
            rd = cmd.ExecuteReader();
            Tabla.Load(rd);
            rd.Close();
            db.CerrarConexion();
            return Tabla;

        }
        public void Eliminar()
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "delete Empleados where IdEmpleado=" + IdEmpleado;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            db.CerrarConexion();
        }
    }
}
