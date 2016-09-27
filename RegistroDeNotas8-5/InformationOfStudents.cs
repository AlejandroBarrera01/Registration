using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace RegistroDeNotas8_5
{
    class InformationOfStudents
    {
        private string Cadena = "Data Source=(local); Initial Catalog=REGISTRODENOTAS; Integrated Security= True";
        private SqlConnection Coneccion;
        private SqlCommand Comando;

        //Metodo de Coneccion
        private void Conectar()
        {
            Coneccion = new SqlConnection(Cadena);
        }
        //Constructor

        public InformationOfStudents()
        {
            Conectar();
        }
        public bool Guardar(string Tabla, int ID, string Name, string LastName, string Subject, int IP, int IIP, int SIST, int NF, int EXAICONV , int NFCONV, int IICONV)
        {
            Coneccion.Open();
            Comando = new SqlCommand();
            Comando.CommandText = "INSERT INTO " + Tabla + "(ID, NAME, LASTNAME, SUBJEC, IP, IIP, SIST, NF, EXAICONV, NFCONV, IICONV) VALUES(" + ID + ",' " + Name + "',' " + LastName + "','" + Subject + "'," + IP + "," + IIP + "," + SIST + "," + NF + "," + EXAICONV + "," + NFCONV + "," + IICONV + ")";
            Comando.Connection = Coneccion;
            int i = Comando.ExecuteNonQuery();
            Coneccion.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Metodo Imprimir
        public DataTable Imprimir(string Tabla, int ID)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            string sql = "SELECT * FROM " + Tabla + "WHERE ID=" + ID;
            Coneccion.ConnectionString = Cadena;

            da = new SqlDataAdapter(sql, Coneccion);
            da.Fill(ds, Tabla);
            dt = ds.Tables[Tabla];
            return (dt);
        }
        public DataTable Imprimir(string Tabla)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            string sql = "SELECT DISTINCT SUBJEC FROM " + Tabla;
            Coneccion.ConnectionString = Cadena;

            da = new SqlDataAdapter(sql, Coneccion);
            da.Fill(ds, Tabla);
            dt = ds.Tables[Tabla];
            return (dt);
        }
        public DataTable Imprimir(string Tabla, string c)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            string sql = "SELECT ID, NAME, LASTNAME, IP, IIP, SIST, NF, EXAICONV, NFCONV, IICONV FROM "+ Tabla + " WHERE SUBJEC= '" + c +"'";
            Coneccion.ConnectionString = Cadena;
            da = new SqlDataAdapter(sql, Coneccion);
            da.Fill(ds, Tabla);
            dt = ds.Tables[Tabla];
            return (dt);

        }
        public DataTable AVG(string Tabla, string A)
        {

            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            string sql = "SELECT COUNT (*) FROM " + Tabla + " WHERE SUBJEC='" + A + "' AND NF>=60 OR EXAICONV>=60 OR NFCONV>=60 OR IICONV>=60";
            Coneccion.ConnectionString = Cadena;

            da = new SqlDataAdapter(sql, Coneccion);
            da.Fill(ds, Tabla);
            dt = ds.Tables[Tabla];
            return (dt);

        }
        
        


        private int ID;
        private string Name;
        private string LastName;
        private string Subject;
        private int IP;
        private int IIP;
        private int SIST;
        private int NF;
        private int EXAICONV;
        private int NFCONV;
        private int IICONV;
        

        public int GSID
        {
            get { return ID; }
            set { ID = value; }
        }
        public string GSName
        {
            get { return Name; }
            set { Name = value; }
        }
        public string GSLastName
        {
            get { return LastName; }
            set { LastName = value; }
        }
        public string GSSubject
        {
            get { return Subject; }
            set { Subject = value; }

        }
        public int GSIP
        {
            get { return IP; }
            set { IP = value; }
        }
        public int GSIIP
        {
            get { return IIP; }
            set { IIP = value; }
        }
        public int GSSIST
        {
            get { return SIST; }
            set { SIST = value; }
        }
        public int GSNF
        {
            get { return NF; }
            set { NF = value;  }
        }
        public int GSEXAICONV
        {
            get { return EXAICONV; }
            set { EXAICONV = value; }
        }
        public int GSNFCONV
        {
            get { return NFCONV; }
            set { NFCONV = value; }     
        }
        public int GSITCONV
        {
            get { return IICONV; }
            set { IICONV = value; }
        }
      
       

    }
}
