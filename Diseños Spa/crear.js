document.addEventListener("DOMContentLoaded", async function () {
    const serviciosContainer = document.getElementById("tablaBody1");
    const form = document.querySelector('#Crear form');
    const selectTipoServicio = document.getElementById('nombre-select');

    async function obtenerInformacionServicio() {
        try {
            const apiUrlServicios = "http://localhost:443/api/v1/servicios";
            const responseServicios = await fetch(apiUrlServicios);
            const dataServicios = await responseServicios.json();

            if (dataServicios && dataServicios.datos && dataServicios.datos.length > 0) {
                // Obtenemos los tipos de servicio primero
                const apiUrlTiposServicio = "http://localhost:443/api/v1/tiposervicios";
                const responseTiposServicio = await fetch(apiUrlTiposServicio);
                const dataTiposServicio = await responseTiposServicio.json();

                const tiposServicioMap = new Map(dataTiposServicio.datos.map(tipo => [tipo.id, tipo.nombre]));

                dataServicios.datos.forEach(servicio => {
                    const servicioElement = document.createElement("tr");
                    servicioElement.classList.add("servicio");

                    const tipoServicioNombre = tiposServicioMap.get(servicio.tiposervicio.id) || 'Desconocido';

                    const contenidoHTML = `
                    <td>${servicio.nombre}</td>
                    <td>${servicio.descipcion}</td>
                    <td>${tipoServicioNombre}</td>
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

    async function cargarTiposServicio() {
        try {
            const response = await fetch('http://localhost:443/api/v1/tiposervicios');
            const data = await response.json();

            if (data && data.datos && data.datos.length > 0) {
                data.datos.forEach(tipo => {
                    const option = document.createElement('option');
                    option.value = tipo.id;
                    option.textContent = tipo.nombre;
                    selectTipoServicio.appendChild(option);
                });
            } else {
                console.log('No se encontraron tipos de servicio.');
            }
        } catch (error) {
            console.error('Error al cargar tipos de servicio:', error);
        }
    }

    cargarTiposServicio();
    obtenerInformacionServicio();

    form.addEventListener('submit', function (event) {
        event.preventDefault();

        const nombreServicio = document.querySelector('#nombre-servicio').value;
        const descripcionServicio = document.querySelector('#descripcion-servicio').value;
        const valorServicio = document.querySelector('#valor-servicio').value;
        const tipoServicio = selectTipoServicio.value;

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
            alert('La descripción del servicio solo debe contener letras y espacios.');
            return;
        }
        if (descripcionServicio.length > maxDescripcionLength) {
            alert(`La descripción del servicio no debe exceder los ${maxDescripcionLength} caracteres.`);
            return;
        }
        const valorRegex = /^[0-9\s]+$/;
        const maxValorLength = 12;
        if (!valorRegex.test(valorServicio)) {
            alert('El valor del servicio solo debe contener números y ser positivo. Verifica que no tenga letras o signo negativo.');
            return;
        }
        if (valorServicio.length > maxValorLength) {
            alert(`El valor del servicio no debe exceder los ${maxValorLength} caracteres.`);
            return;
        }

        const data = {
            "id":null,
            "nombre": nombreServicio,
            "descipcion": descripcionServicio,
            "tiposervicio": {
                "id":tipoServicio,
                "nombre":""
            },
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
