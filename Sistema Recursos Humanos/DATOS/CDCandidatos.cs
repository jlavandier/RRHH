using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Recursos_Humanos.DATOS
{
    public class CDCandidatos
    {
        private MiConexion db = new MiConexion();

        SqlDataReader rd;
        SqlCommand cmd = new SqlCommand();
        private int IdCandidato;
        private string Cedula;
        private string Nombre;
        private int PuestoAspira;
        private string Departamento;
        private Double SalarioAspira;
        private int Competencias;
        private int Capacitaciones;
        private int Experiencia;
        private string Recomendacion;
        private int Idioma;

        //metodos get y set
        public int _IdCandidato
        {
            get { return IdCandidato; }
            set { IdCandidato = value; }
        }
        public string _Cedula
        {
            get { return Cedula; }
            set { Cedula = value; }
        }
        public string _Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public int _PuestoAspira    
        {
            get { return _PuestoAspira; }
            set { PuestoAspira = value; }
        }
        public string _Departamento
        {
            get { return Departamento; }
            set { Departamento= value; }
        }
        public Double _SalarioAspira
        {
            get { return _SalarioAspira; }
            set { SalarioAspira = value; }
        }
        public int _Competencias
        {
            get { return _Competencias; }
            set { Competencias = value; }
        }
        public int _Capacitaciones
        {
            get { return _Capacitaciones; }
            set { Capacitaciones = value; }
        }
        public int _Experiencia
        {
            get { return _Experiencia; }
            set { Experiencia = value; }
        }
        public string _Recomendacion
        {
            get { return _Recomendacion; }
            set { Recomendacion= value; }
        }
        public int _Idioma
        {
            get { return _Idioma; }
            set { Idioma = value; }
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
        public DataTable ListarComp()
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
        public DataTable ListarCapaci()
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
        public DataTable Listarex()
        {

            DataTable Tabla = new DataTable();
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "MostrarExperiencias";
            cmd.CommandType = CommandType.StoredProcedure;
            rd = cmd.ExecuteReader();
            Tabla.Load(rd);
            rd.Close();
            db.CerrarConexion();
            return Tabla;

        }


        public void InsertarCan()
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "InsertarCan";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cedula", Cedula );
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@PuestoAspira", PuestoAspira);
            cmd.Parameters.AddWithValue("@Departamento", Departamento);
            cmd.Parameters.AddWithValue("@SalarioAspira", SalarioAspira);
            cmd.Parameters.AddWithValue("@Competencias", Competencias);
            cmd.Parameters.AddWithValue("@Capacitaciones", Capacitaciones);
            cmd.Parameters.AddWithValue("@ExperinciaLab", Experiencia);
            cmd.Parameters.AddWithValue("@Recomendacion", Recomendacion);
            cmd.Parameters.AddWithValue("@Idioma", Idioma);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public void EditarC()
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "update Candidatos set Cedula = '"+Cedula+"', Nombre = '"+ Nombre +"', PuestoAspira = "+PuestoAspira+ ",  Departamento = '"+ Departamento + "', SalarioAspira = "+ SalarioAspira + ", Competencias = "+ Competencias + ",Capacitaciones = " + Capacitaciones + ",ExperinciaLab = " + Experiencia + ",Recomendacion = '" + Recomendacion + "',Idioma= "+ Idioma +" WHERE IdCandidato = " + IdCandidato;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            db.CerrarConexion();
        }
        public void Eliminar()
        {
            cmd.Connection = db.AbrirConexion();
            cmd.CommandText = "delete Candidatos where IdCandidato=" + IdCandidato;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            db.CerrarConexion();
        }
    }
}
