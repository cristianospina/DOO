using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnline.co.edu.uco.spaonline.data
{
    public class TipoIdentificacionEntity
    {
        private Guid id;
        private string codigo;
        private string nombre;
        private Boolean estado;

        public TipoIdentificacionEntity(Guid id, string codigo, string nombre, bool estado)
        {
            SetId(id);
            SetCodigo(codigo);
            SetNombre(nombre);
            SetEstado(estado);
        }
        public static TipoIdentificacionEntity Crear(Guid id, string codigo, string nombre, bool estado)
        {
            return new TipoIdentificacionEntity(id, codigo, nombre, estado);
        }
        private void SetId(Guid id){
            this.id = id;
        }
        private void SetCodigo(string codigo){
            this.codigo = codigo;
        }
        private void SetNombre(string nombre){
            this.nombre = nombre;
        }
        private void SetEstado(bool estado){
            this.estado = estado; 
        }
        public Guid GetId(){
            return id; 
        }
        public string GetCodigo(){
            return codigo;
        }
        public string GetNombre(){
            return nombre;
        }
        public bool GetEstado(){
            return estado;
        }
    }
}
