using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnline.co.edu.uco.spaonline.data.dao
{
    public class SQLDAO
    {
        private readonly ConnectionInfo _conexion;

        protected SQLDAO (ConnectionInfo conexion) {
            SetConexion(conexion);
        }

        private void SetConexion(ConnectionInfo conexion) { 
            //this._conexion = conexion;
        }
    }
}