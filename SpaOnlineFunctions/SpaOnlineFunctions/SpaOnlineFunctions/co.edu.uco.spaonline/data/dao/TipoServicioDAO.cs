using Microsoft.CodeAnalysis;
using SpaOnlineFunctions.co.edu.uco.spaonline.data.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.data.dao
{
    interface  TipoServicioDAO
    {
        void crear(TipoServicioEntity entity);

        void modificar(TipoServicioEntity entity);

        void eliminar(Guid id);

        Optional<TipoServicioEntity> consultarPorId(Guid id);

        List<TipoServicioEntity> consultar(TipoServicioEntity entity);
    }
}
