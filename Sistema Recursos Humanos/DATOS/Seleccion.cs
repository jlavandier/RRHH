using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Recursos_Humanos.DATOS
{
    public class Seleccion
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
       /* public int _IdCandidato
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
            set { Departamento = value; }
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
            set { Recomendacion = value; }
        }
        public int _Idioma
        {
            get { return _Idioma; }
            set { Idioma = value; }
        }*/

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
