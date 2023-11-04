using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Recursos_Humanos.DATOS
{
    public class CDExperiencias
    {
        MiConexion db = new MiConexion();
        SqlDataReader rd;
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable Mostrar()
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "MostrarExperiencias";
            cmd.CommandType = CommandType.StoredProcedure;
            rd = cmd.ExecuteReader();
            dt.Load(rd);
            db.CerrarConexion();
            return dt;
        }
        public void Insertar(string Empresa,string Puesto, DateTime FechaDesde, DateTime FechaHasta,Double Salario)
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "InsertarExperiencias";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Empresa", Empresa);
            cmd.Parameters.AddWithValue("@Puesto", Puesto);
            cmd.Parameters.AddWithValue("@FechaDesde", FechaDesde);
            cmd.Parameters.AddWithValue("@FechaHasta", FechaHasta);
            cmd.Parameters.AddWithValue("@Salario", Salario);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            db.CerrarConexion();
        }
        public void Editar(string Empresa,string Puesto, DateTime FechaDesde, DateTime FechaHasta,  Double Salario,int IdExperienciaLab)
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "EditarExp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Empresa", Empresa);
            cmd.Parameters.AddWithValue("@Puesto", Puesto);
            cmd.Parameters.AddWithValue("@FechaDesde", FechaDesde);
            cmd.Parameters.AddWithValue("@FechaHasta", FechaHasta);
            cmd.Parameters.AddWithValue("@Salario", Salario);
            cmd.Parameters.AddWithValue("@IdExperienciaLab", IdExperienciaLab);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            db.CerrarConexion();
        }
        public void Eliminar(int IdExperienciaLab)
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "EliminarExperiencia";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdExperienciaLab", IdExperienciaLab);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            db.CerrarConexion();
        }
 
    }
}
