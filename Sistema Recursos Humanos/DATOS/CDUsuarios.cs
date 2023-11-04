using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Recursos_Humanos.DATOS
{
    public class CDUsuarios
    {
        private MiConexion db = new MiConexion();

        SqlDataReader rd;
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        public DataTable Mostrar()
        {

            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "MostrarUsuaios";
            cmd.CommandType = CommandType.StoredProcedure;
            rd = cmd.ExecuteReader();
            dt.Load(rd);
            db.CerrarConexion();
            return dt;

        }
        public void Insertar(string Cuenta, string Contrasena, string Rol)
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "InsertarUsuarios";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cuenta", Cuenta);
            cmd.Parameters.AddWithValue("@Contrasena", Contrasena);
            cmd.Parameters.AddWithValue("@Rol", Rol);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            db.CerrarConexion();
        }
        public void Editar(string Cuenta, string Contrasena, string Rol, int IdUsuario)
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "EditarUsuarios";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cuenta", Cuenta);
            cmd.Parameters.AddWithValue("@Contrasena", Contrasena);
            cmd.Parameters.AddWithValue("@Rol", Rol);
            cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            db.CerrarConexion();
        }
        public void Eliminar(int IdUsuario)
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "EliminarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            db.CerrarConexion();
        }
    }
}
