using Microsoft.CodeAnalysis;
using SpaOnlineFunctions.co.edu.uco.spaonline.data.entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.data.dao
{
    interface TipoIdentificacionDAO
    {
        void crear(TipoIdentificacionEntity entity);

        void modificar(TipoIdentificacionEntity entity);

        void eliminar(Guid id);

        Optional<TipoIdentificacionEntity> ConsultarPorId(Guid id);

        List<TipoIdentificacionEntity> consultar(SqlCommand cmd);
    }
}
