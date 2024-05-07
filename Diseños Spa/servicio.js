
document.addEventListener("DOMContentLoaded", function() {
    const serviciosContainer = document.getElementById("tablaBody");

    
    function obtenerInformacionServicio() {
        
        const apiUrl = "http://localhost:7105/api/Servicio/1";

        
        fetch(apiUrl)
            .then(response => response.json())
            .then(data => {
                
                if (data && data.servicio) {
                    
                    const servicio = data.servicio;
                    

                    
                    const servicioElement = document.createElement("tr");
                    servicioElement.classList.add("servicio");

                    const nombreServicioElement = document.createElement("td");
                    nombreServicioElement.textContent = servicio.nombre;

                    const descripcionServicioElement = document.createElement("td");
                    descripcionServicioElement.textContent = servicio.descripcion;

                    const tipoServicioServicioElement = document.createElement("td");
                    tipoServicioServicioElement.textContent = servicio.tipoServicio;

                    const valorServicioServicioElement = document.createElement("td");
                    valorServicioServicioElement.textContent = servicio.valorServicio;

                    servicioElement.appendChild(nombreServicioElement);
                    servicioElement.appendChild(descripcionServicioElement);
                    servicioElement.appendChild(tipoServicioServicioElement);
                    servicioElement.appendChild(valorServicioServicioElement);

                    serviciosContainer.appendChild(servicioElement);
                } else {
                    
                    serviciosContainer.textContent = "No se encontró información del servicio.";
                }
            })
            .catch(error => {
                console.error("Error al obtener el servicio:", error);
                serviciosContainer.textContent = "Ocurrió un error al obtener el servicio. Por favor, inténtalo de nuevo más tarde.";
            });
    }


    obtenerInformacionServicio();
});

document.addEventListener("DOMContentLoaded", function() {
    const serviciosContainer = document.getElementById("tablaBody2");

    
    function obtenerInformacionServicio() {
        
        const apiUrl = "http://localhost:7105/api/Servicio/2";

        
        fetch(apiUrl)
            .then(response => response.json())
            .then(data => {
                
                if (data && data.servicio) {
                    
                    const servicio = data.servicio;
                    

                    
                    const servicioElement = document.createElement("tr");
                    servicioElement.classList.add("servicio");

                    const nombreServicioElement = document.createElement("td");
                    nombreServicioElement.textContent = servicio.nombre;

                    const descripcionServicioElement = document.createElement("td");
                    descripcionServicioElement.textContent = servicio.descripcion;

                    const tipoServicioServicioElement = document.createElement("td");
                    tipoServicioServicioElement.textContent = servicio.tipoServicio;

                    const valorServicioServicioElement = document.createElement("td");
                    valorServicioServicioElement.textContent = servicio.valorServicio;

                    servicioElement.appendChild(nombreServicioElement);
                    servicioElement.appendChild(descripcionServicioElement);
                    servicioElement.appendChild(tipoServicioServicioElement);
                    servicioElement.appendChild(valorServicioServicioElement);

                    serviciosContainer.appendChild(servicioElement);
                } else {
                    
                    serviciosContainer.textContent = "No se encontró información del servicio.";
                }
            })
            .catch(error => {
                console.error("Error al obtener el servicio:", error);
                serviciosContainer.textContent = "Ocurrió un error al obtener el servicio. Por favor, inténtalo de nuevo más tarde.";
            });
    }


    obtenerInformacionServicio();
});
// Este es para Crear un servicio o bueno... esa es la idea
document.addEventListener('DOMContentLoaded', function() {
    const form = document.querySelector('#Crear form');
  
    form.addEventListener('submit', function(event) {
      event.preventDefault();
  
      const nombreServicio = document.querySelector('#nombre-servicio').value;
      const descripcionServicio = document.querySelector('#descripcion-servicio').value;
      const valorServicio = document.querySelector('#valor-servicio').value;
      const tipoServicio = document.querySelector('#nombre_select').value;
  
      const data = {
        "nombre_servicio": nombreServicio,
        "descripcion_servicio": descripcionServicio,
        "valor_servicio": valorServicio,
        "tipo_servicio": tipoServicio
      };
  
      fetch('https://apimocha.com/serviciospa/servicio', {
        method: 'PUT',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
      })
      .then(response => {
        if (response.ok) {
          console.log('Datos enviados correctamente a la API.');
          
        } else {
          console.error('Error al enviar datos a la API:', response.status);
          
        }
      })
      .catch(error => {
        console.error('Error al enviar datos a la API:', error);
      });
    });
  });


  // Para modificar
  document.addEventListener('DOMContentLoaded', function() {
    const form = document.querySelector('#Modificar form');
  
    form.addEventListener('submit', function(event) {
      event.preventDefault();
  
      const nombreServicioModificar = document.querySelector('#nombreAnterior').value;
      const nuevoNombre = document.querySelector('#nombre').value;
      const nuevaDescripcion = document.querySelector('#descripcion').value;
      const tipoServicio = document.querySelector('#tiposervicio').value;
      const valorservicio = document.querySelector('#valorservicio').value;
  
      const data = {
        "nombreAnterior": nombreServicioModificar,
        "nombre": nuevoNombre,
        "descripcion": nuevaDescripcion,
        "tiposervicio": tipoServicio,
        "valorservicio": valorservicio
      };
  
      fetch('https://apimocha.com/serviciospa/servicio/${nombreServicioModificar}', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
      })
      .then(response => {
        if (response.ok) {
          console.log('Servicio modificado correctamente.');
          // Aquí puedes realizar alguna acción adicional si es necesario
        } else {
          console.error('Error al modificar el servicio:', response.status);
          // Manejar el caso de error, si es necesario
        }
      })
      .catch(error => {
        console.error('Error al modificar el servicio:', error);
      });
    });
  });

  // Eliminar Servicio
  document.addEventListener('DOMContentLoaded', function() {
    const form = document.querySelector('#Eliminar form');
  
    form.addEventListener('submit', function(event) {
      event.preventDefault();
  
      const nombreServicioEliminar = document.querySelector('#nombreEliminar').value;
  
      const data = {
        "nombre_servicio_eliminar": nombreServicioEliminar
      };
  
      fetch('https://apimocha.com/serviciospa/servicio/${nombreEliminar}', {
        method: 'DELETE',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
      })
      .then(response => {
        if (response.ok) {
          console.log('Servicio eliminado correctamente.');
          // Aquí puedes realizar alguna acción adicional si es necesario
        } else {
          console.error('Error al eliminar el servicio:', response.status);
          // Manejar el caso de error, si es necesario
        }
      })
      .catch(error => {
        console.error('Error al eliminar el servicio:', error);
      });
    });
  });
  