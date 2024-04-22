using Microsoft.CodeAnalysis;
using SpaOnlineFunctions.co.edu.uco.spaonline.data.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.data.dao
{
    interface ClienteDAO
    {
        void crear(ClienteEntity entity);

        void modificar(ClienteEntity entity);

        void eliminar(Guid id);

        Optional<ClienteEntity> consultarPorId(Guid id);

        List<ClienteEntity> consultar(ClienteEntity entity);
    }
}
