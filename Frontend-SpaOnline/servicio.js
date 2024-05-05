document.addEventListener("DOMContentLoaded", function() {
    const serviciosContainer = document.getElementById("servicios1");

    
    function obtenerInformacionServicio() {
        numero = 1;
        const apiUrl = "http://localhost:7105/api/Servicio/1";

        
        fetch(apiUrl)
            .then(response => response.json())
            .then(data => {
                
                if (data && data.servicio) {
                    
                    const servicio = data.servicio;

                    
                    const servicioElement = document.createElement("div");
                    servicioElement.classList.add("servicio");

                    const nombreServicioElement = document.createElement("h3");
                    nombreServicioElement.textContent = servicio.nombre;

                    const descripcionServicioElement = document.createElement("p");
                    descripcionServicioElement.textContent = servicio.descripcion;

                    servicioElement.appendChild(nombreServicioElement);
                    servicioElement.appendChild(descripcionServicioElement);

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
    const serviciosContainer = document.getElementById("servicios2");

    
    function obtenerInformacionServicio() {
        
        const apiUrl = "http://localhost:7105/api/Servicio/2";

        
        fetch(apiUrl)
            .then(response => response.json())
            .then(data => {
                
                if (data && data.servicio) {
                    
                    const servicio = data.servicio;

                    
                    const servicioElement = document.createElement("div");
                    servicioElement.classList.add("servicio");

                    const nombreServicioElement = document.createElement("h3");
                    nombreServicioElement.textContent = servicio.nombre;

                    const descripcionServicioElement = document.createElement("p");
                    descripcionServicioElement.textContent = servicio.descripcion;

                    servicioElement.appendChild(nombreServicioElement);
                    servicioElement.appendChild(descripcionServicioElement);

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
