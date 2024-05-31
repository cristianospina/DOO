 // Eliminar Servicio
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
              <td><input type="radio" name="servicioSeleccionado" value="${servicio.id}"></td>
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
  document.addEventListener('DOMContentLoaded', function() {
    const form = document.querySelector('#eliminar-form');

    form.addEventListener('submit', function(event) {
        event.preventDefault();

        const selectedService = document.querySelector('input[name="servicioSeleccionado"]:checked');
        if (!selectedService) {
            alert('Por favor, selecciona un servicio para eliminar.');
            return;
        }

        const id = selectedService.value;
        const uuidRegex = /^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$/i;
        if (!uuidRegex.test(id)) {
            alert('El ID del servicio debe ser un UUID válido.');
            return;
        }

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
                console.error('Error al eliminar el servicio:', response.status ,'Por favor valida que el ID exista en la lista que aparece en la parte de abajo' );
                window.alert(`Error al eliminar el servicio (servicio no encontrado). Por favor validar que el servicio si exista para poder eliminarlo `);
            }
        })
        .catch(error => {
            console.error('Error al eliminar el servicio:', error);
        });
    });
});

  