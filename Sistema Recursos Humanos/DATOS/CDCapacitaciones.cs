using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Recursos_Humanos.DATOS
{
    public class CDCapacitaciones
    {
        private MiConexion db = new MiConexion();

        SqlDataReader rd;
        SqlCommand cmd = new SqlCommand();
        private int IdCapacitaciones;
        private string Descripcion;
        private string Nivel;
        private DateTime FechaDesde;
        private DateTime FechaHasta;
        private string Institucion;
       

        //metodos get y set
        public int _IdCapacitaciones
        {
            get { return _IdCapacitaciones; }
            set { IdCapacitaciones = value; }
        }
        public string _Descripcion
        {
            get { return _Descripcion; }
            set {  Descripcion = value; }
        }
        public string _Nivel
        {
            get { return _Nivel; }
            set { Nivel = value; }
        }
        public DateTime _FechaDesde
        {
            get { return _FechaDesde; }
            set { FechaDesde = value; }
        }
        public DateTime _FechaHasta
        {
            get { return _FechaHasta; }
            set { FechaHasta = value; }
        }
        public string _Institucion
        {
            get { return _Institucion; }
            set { Institucion = value; }
        }

        public DataTable MostrarCapacitaciones()
        {

            DataTable Tabla = new DataTable();
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "ListarCapacitaciones";
            cmd.CommandType = CommandType.StoredProcedure;
            rd = cmd.ExecuteReader();
            Tabla.Load(rd);
            rd.Close();
            db.CerrarConexion();
            return Tabla;

        }

        public void InsertarCapa()
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "InsertarCapacitaciones";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
            cmd.Parameters.AddWithValue("@Nivel", Nivel);
            cmd.Parameters.AddWithValue("@FechaDesde", FechaDesde);
            cmd.Parameters.AddWithValue("@FechaHasta", FechaHasta);
            cmd.Parameters.AddWithValue("@Institucion", Institucion);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void EditarCapa()
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "update Capacitaciones set Descripcion = '" + Descripcion + "', Nivel = '" + Nivel + "', FechaDesde = '" + FechaDesde + "',  FechaHasta = '" + FechaHasta + "', Institucion = '" + Institucion + "' WHERE IdCapacitacion = " + IdCapacitaciones;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            db.CerrarConexion();
        }
        public void EliminarCapa()
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "delete Capacitaciones where IdCapacitacion=" + IdCapacitaciones;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            db.CerrarConexion();
        }
    }
}
