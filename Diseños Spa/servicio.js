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
      
      const nombreRegex = /^[a-zA-Z\s]+$/;
      const maxNombreLength = 50;
        if (!nombreRegex.test(nombreServicio)) {
            alert('El nombre del servicio solo debe contener letras.');
            return;
        }
        if (nombreServicio.length > maxNombreLength) {
          alert(`El nombre del servicio no debe exceder los ${maxNombreLength} caracteres.`);
          return;
      }
        const descripcionRegex = /^[a-zA-Z\s.,]+$/;
        const maxDescripcionLength = 400;
        if (!descripcionRegex.test(descripcionServicio)) {
            alert('La descripcion del servicio solo debe contener letras y espacios.');
            return;
        }
        if (descripcionServicio.length > maxDescripcionLength) {
          alert(`La descripción del servicio no debe exceder los ${maxDescripcionLength} caracteres.`);
          return;
      }
        const valorRegex = /^[0-9\s]+$/;
        const maxValorLength = 12;
        if (!valorRegex.test(valorServicio)) {
          alert('El valor del servicio solo debe contener numeros y que sean pósitivos. valida por favor que no tenga letras o signo de negativo');
            return;
        }
        if (valorServicio.length > maxValorLength) {
          alert(`El valor del servicio no debe exceder los ${maxValorLength} caracteres.`);
          return;
      }


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
          window.alert(`Error al crear el servicio, no puede tener el mismo nombre con el mismo tipo`);
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
      
      const uuidRegex = /^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$/i;
      if (!uuidRegex.test(id)) {
          alert('El ID del servicio debe ser un UUID válido.');
          return;
      }
      const nombreRegex = /^[a-zA-Z\s]+$/;
      const maxNombreLength = 50;
        if (!nombreRegex.test(nombreServicio)) {
            alert('El nombre del servicio solo debe contener letras.');
            return;
        }
        if (descripcionServicio.length > maxNombreLength) {
          alert(`El nombre del servicio no debe exceder los ${maxNombreLength} caracteres.`);
          return;
      }
        const descripcionRegex = /^[a-zA-Z\s.,]+$/;
        const maxDescripcionLength = 400;
        if (!descripcionRegex.test(descripcionServicio)) {
            alert('La descripcion del servicio solo debe contener letras y espacios.');
            return;
        }
        if (descripcionServicio.length > maxDescripcionLength) {
          alert(`La descripción del servicio no debe exceder los ${maxDescripcionLength} caracteres.`);
          return;
      }
        const valorRegex = /^[0-9\s]+$/;
        const maxValorLength = 12;
        if (!valorRegex.test(valorServicio)) {
          alert('El valor del servicio solo debe contener numeros y que sean pósitivos. valida por favor que no tenga letras o signo de negativo');
            return;
        }
        if (descripcionServicio.length > maxValorLength) {
          alert(`El valor del servicio no debe exceder los ${maxValorLength} caracteres.`);
          return;
      }

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
          console.error('Error al modificar el servicio:', response.status , 'Por favor valida que el ID exista en la lista que aparece en la parte de abajo');
        }
      })
      .catch(error => {
        console.error('Error al modificar el servicio:', error);
      });
    });
  });

 