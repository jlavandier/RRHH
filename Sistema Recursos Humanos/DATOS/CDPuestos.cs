using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Recursos_Humanos.DATOS
{
    public class CDPuestos
    {
        private MiConexion db = new MiConexion();

        SqlDataReader rd;
        SqlCommand cmd = new SqlCommand();
        private int IdPuesto;
        private string Ocupacion;
        private string NivelRiesgo;
        private Double SalarioMinimo;
        private Double SalarioMaximo;
        private int idiomas;
        private string Estado;
        

        //metodos get y set
        public int _IdPuesto
        {
            get { return _IdPuesto; }
            set { IdPuesto = value; }
        }
        public string _Ocupacion
        {
            get { return _Ocupacion; }
            set { Ocupacion = value; }
        }
        public string _NivelRiesgo
        {
            get { return _NivelRiesgo; }
            set { NivelRiesgo = value; }
        }
        public Double _SalarioMinimo
        {
            get { return _SalarioMinimo; }
            set { SalarioMinimo = value; }
        }
        public Double _SalarioMaximo
        {
            get { return _SalarioMaximo; }
            set { SalarioMaximo = value; }
        }
        public int _idiomas
        {
            get { return _idiomas; }
            set { idiomas = value; }
        }
        public string _Estado
        {
            get { return _Estado; }
            set { Estado = value; }
        }

        public DataTable Listaridiomas()
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

        public void InsertarPues()
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "Insertarpuesto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ocupacion", Ocupacion);
            cmd.Parameters.AddWithValue("@Riesgo",NivelRiesgo);
            cmd.Parameters.AddWithValue("@SalarioMinimo", SalarioMinimo);
            cmd.Parameters.AddWithValue("@SalarioMaximo", SalarioMaximo);
            cmd.Parameters.AddWithValue("@Idioma", idiomas);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void EditarPues()
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "update Puestos set Ocupacion = '" + Ocupacion + "', Riesgo = '" + NivelRiesgo + "', SalarioMinimo = " + SalarioMinimo + ",  SalarioMaximo = '" + SalarioMaximo + "', Idioma = " + idiomas + ", Estado = '" + Estado + "' WHERE IdPuesto = " + IdPuesto;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            db.CerrarConexion();
        }

        public void EliminarPues()
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "delete Puestos where IdPuesto=" + IdPuesto;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            db.CerrarConexion();
        }
    }
}
