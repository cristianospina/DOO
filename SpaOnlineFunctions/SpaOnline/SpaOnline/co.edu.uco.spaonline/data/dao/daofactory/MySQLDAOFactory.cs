using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnline.co.edu.uco.spaonline.data.dao.daofactory
{
    internal class MySQLDAOFactory
    {
        SqlConnection sqldb = new SqlConnection(@"Data Source=localhost;Initial Catalog=ERPDBII; Integrated Security=SSPI");


        public MySQLDAOFactory() {
            AbrirConexion();        
        }

        protected void AbrirConexion() {
                sqldb.Open();      
        }
        public void CerrarConexion()
        {
            if (sqldb != null && sqldb.State == System.Data.ConnectionState.Open)
            {
                sqldb.Close();
                Console.WriteLine("Conexión cerrada correctamente.");
            }
        }
        
    }
}
