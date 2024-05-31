document.addEventListener("DOMContentLoaded", async function () {
    const selectServicio = document.getElementById("selectServicio");
    const idInput = document.getElementById("id");
    
    async function obtenerServicios() {
      try {
        const apiUrl = "http://localhost:443/api/v1/servicios";
        const response = await fetch(apiUrl);
        const data = await response.json();
  
        if (data && data.datos && data.datos.length > 0) {
          data.datos.forEach(servicio => {
            const option = document.createElement("option");
            option.value = servicio.id;
            option.textContent = servicio.nombre;
            selectServicio.appendChild(option);
          });
        } else {
          const option = document.createElement("option");
          option.textContent = "No se encontraron servicios";
          selectServicio.appendChild(option);
        }
      } catch (error) {
        console.error("Error al obtener los servicios:", error);
      }
    }
  
    obtenerServicios();
  
    selectServicio.addEventListener('change', function () {
      const selectedId = this.value;
      if (selectedId) {
        idInput.value = selectedId;
      }
    });
  
    const form = document.querySelector('#Modificar form');
  
    form.addEventListener('submit', function(event) {
      event.preventDefault();
  
      const id = idInput.value;
      const nuevoNombre = document.querySelector('#nombre').value;
      const nuevaDescripcion = document.querySelector('#descripcion').value;
      const tipoServicio = document.querySelector('#tiposervicio').value;
      const valorServicio = document.querySelector('#tarifa').value;
  
      
      const uuidRegex = /^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$/i;
      if (!uuidRegex.test(id)) {
          alert('El ID del servicio debe ser un UUID válido.');
          return;
      }
      const nombreRegex = /^[a-zA-Z\s]+$/;
      const maxNombreLength = 50;
        if (!nombreRegex.test(nuevoNombre)) {
            alert('El nombre del servicio solo debe contener letras.');
            return;
        }
        if (nuevoNombre.length > maxNombreLength) {
          alert(`El nombre del servicio no debe exceder los ${maxNombreLength} caracteres.`);
          return;
      }
        const descripcionRegex = /^[a-zA-Z\s.,]+$/;
        const maxDescripcionLength = 400;
        if (!descripcionRegex.test(nuevaDescripcion)) {
            alert('La descripcion del servicio solo debe contener letras y espacios.');
            return;
        }
        if (nuevaDescripcion.length > maxDescripcionLength) {
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
        "id": id,
        "nombre": nuevoNombre,
        "descipcion": nuevaDescripcion,
        "tiposervicio": tipoServicio,
        "tarifa": valorServicio
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

 