using Microsoft.CodeAnalysis;
using SpaOnlineFunctions.co.edu.uco.spaonline.data.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.data.dao
{
    interface ServicioDAO
    {
        void crear(ServicioEntity entity);

        void modificar(ServicioEntity entity);

        void eliminar(Guid id);

        Optional<ServicioEntity> consultarPorId(Guid id);

        List<ServicioEntity> consultar(ServicioEntity entity);
    }
}
