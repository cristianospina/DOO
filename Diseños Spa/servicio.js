document.addEventListener("DOMContentLoaded", function () {
  const serviciosContainer = document.getElementById("tablaBody1");

  async function obtenerInformacionServicio() {
    try {
      const apiUrl = "http://localhost:443/api/v1/servicios";
      const response = await fetch(apiUrl);
      const data = await response.json();

      if (data && data.datos && data.datos.length > 0) {
        data.datos.forEach(servicio => {
          const servicioElement = document.createElement("tr");
          servicioElement.classList.add("servicio");

          const contenidoHTML = `
            <td>${servicio.id}</td>
            <td>${servicio.nombre}</td>
            <td>${servicio.descipcion}</td>
            <td>${servicio.tiposervicio}</td>
            <td>${servicio.tarifa}</td>`;

          servicioElement.innerHTML = contenidoHTML;
          serviciosContainer.appendChild(servicioElement);
        });
      } else {
        serviciosContainer.textContent = "No se encontró información del servicio.";
      }
    } catch (error) {
      console.error("Error al obtener el servicio:", error);
      serviciosContainer.textContent = "Ocurrió un error al obtener el servicio. Por favor, inténtalo de nuevo más tarde.";
    }
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
        "nombre": nombreServicio,
        "descipcion": descripcionServicio,
        "tiposervicio": tipoServicio ,
        "tarifa": valorServicio
        
      };
  
      fetch('http://localhost:443/api/v1/servicios', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
      })
      .then(response => {
        if (response.ok) {
          console.log('Datos enviados correctamente a la API.');
          window.alert('¡Servicio creado exitosamente!');
          window.location.reload();
          
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
  
      const id = document.querySelector('#id').value;
      const nuevoNombre = document.querySelector('#nombre').value;
      const nuevaDescripcion = document.querySelector('#descripcion').value;
      const tipoServicio = document.querySelector('#tiposervicio').value;
      const valorservicio = document.querySelector('#tarifa').value;
  
      const data = {
        "id": id,
        "nombre": nuevoNombre,
        "descipcion": nuevaDescripcion,
        "tiposervicio": tipoServicio,
        "tarifa": valorservicio
      };
  
      fetch(`http://localhost:443/api/v1/servicios/${id}`, {
        method: 'PUT',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
      })
      .then(response => {
        if (response.ok) {
          console.log('Servicio modificado correctamente.');
          window.alert('¡Servicio modificado exitosamente!');
          window.location.reload();
          
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
  
      const id = document.querySelector('#nombreEliminar').value;
  
      const data = {
        "id": id
      };
  
      fetch(`http://localhost:443/api/v1/servicios/${id}`, {
        method: 'DELETE',
        headers: {
          'Content-Type': 'application/json'
        },
      })
      .then(response => {
        if (response.ok) {
          console.log('Servicio eliminado correctamente.');
          window.alert('¡Servicio eliminado exitosamente!');
          window.location.reload();
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
  