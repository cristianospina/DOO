const menu = document.querySelector('.menu');
const navLinks = document.querySelectorAll('.nav-links li a');

menu.addEventListener('click', () => {
  menu.classList.toggle('active');
  navLinks.forEach(link => {
    link.classList.toggle('active');
  });
});

const serviciosGrid = document.querySelector('.servicios-grid');
const servicios = document.querySelectorAll('.servicio');

servicios.forEach(servicio => {
  servicio.addEventListener('click', () => {
    const modal = document.createElement('div');
    modal.classList.add('modal');

    const contenidoModal = document.createElement('div');
    contenidoModal.classList.add('modal-contenido');

    const tituloModal = document.createElement('h3');
    tituloModal.textContent = servicio.querySelector('h3').textContent;

    const imagenModal = document.createElement('img');
    imagenModal.src = servicio.querySelector('img').src;
    imagenModal.alt = servicio.querySelector('img').alt;

    const descripcionModal = document.createElement('p');
    descripcionModal.textContent = servicio.querySelector('p').textContent;

    const botonCerrarModal = document.createElement('button');
    botonCerrarModal.textContent = 'Cerrar';
    botonCerrarModal.addEventListener('click', () => {
      modal.remove();
    });

    contenidoModal.appendChild(tituloModal);
    contenidoModal.appendChild(imagenModal);
    contenidoModal.appendChild(descripcionModal);
    contenidoModal.appendChild(botonCerrarModal);

    modal.appendChild(contenidoModal);
    document.body.appendChild(modal);
  });
});
