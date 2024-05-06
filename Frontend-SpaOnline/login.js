const form = document.getElementById('loginForm');

form.addEventListener('submit', function(event) {
    event.preventDefault();

    const username = document.getElementById('username').value;
    const password = document.getElementById('password').value;

    // Hacer una solicitud a la API para validar las credenciales
    fetch('URL_DE_TU_API', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify({
            username: username,
            password: password
        }),
    })
    .then(response => {
        if (!response.ok) {
            throw new Error('Error al validar las credenciales');
        }
        
        window.location.href = "ingresoServicio.html";
    })
    .catch(error => {
        
        console.error('Error:', error);
        alert("Usuario o contraseña incorrectos");
    });
});
