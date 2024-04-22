using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnline.co.edu.uco.spaonline.data.dao.Concrete
{
    internal class TipoIdentificacionMySQL : SQLDAO
    {
        protected TipoIdentificacionMySQL(ConnectionInfo conexion) : base(conexion)
        {
        }
    }
}
