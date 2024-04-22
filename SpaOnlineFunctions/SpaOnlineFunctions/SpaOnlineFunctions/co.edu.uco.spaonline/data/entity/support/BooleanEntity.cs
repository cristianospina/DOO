using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.data.entity.support
{
    public class BooleanEntity
    {
        private bool valor;
        private bool valorDefecto;

        private BooleanEntity(bool valor, bool valorDefecto) { 
            setValorDefecto(valorDefecto);
            SetValor(valor);
        }

        public static BooleanEntity crear(bool valor, bool valorDefecto) {
            return new BooleanEntity(valor, valorDefecto);
        }
        public bool IsValor()
        {
            return valor;
        }
        public bool IsValorDEfecto() { 
            return valorDefecto;
        }
        private void SetValor(bool valor)
        {
            this.valor = valor;
        }
        private void setValorDefecto(bool valorDefecto) {
            this.valor = valorDefecto;
        }
    }
}
