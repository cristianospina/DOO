
document.addEventListener("DOMContentLoaded", function() {
    const serviciosContainer = document.getElementById("tablaBody");

    
    function obtenerInformacionServicio() {
        numero = 1;
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
        numero = 1;
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
