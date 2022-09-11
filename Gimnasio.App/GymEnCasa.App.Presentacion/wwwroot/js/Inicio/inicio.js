//Login//
var nombre1 = document.getElementById('usuario');
var contraseña = document.getElementById('Contraseña');
var error = document.getElementById('error');
error.style.color='red';
error.style.fontSize=30;


function validar(){
    var mensajesError = [];
    if(usuario.value == null || usuario.value == ''){
        mensajesError.push('Favor complete los datos de Ingreso')
    }
    if(contraseña.value == null || contraseña.value == ''){
        mensajesError.push('Favor complete los datos de Ingreso')
    }
    error.innerHTML = mensajesError.join(', ');
    
    return false
    }

//Registro Usuario//
var nombre1 = document.getElementById('nombre1');
var nombre2 = document.getElementById('nombre2');
var apellido1 = document.getElementById('apellido1');
var apellido2 = document.getElementById('apellido2');
var email = document.getElementById('email');
var edad = document.getElementById('Edad');
var telefono = document.getElementById('Telefono');
var direccion = document.getElementById('Direccion');
var contraseña = document.getElementById('Contraseña');
var error = document.getElementById('error');
error.style.color='red';
error.style.fontSize=20;


function validar(){
    var mensajesError = [];
    if(nombre1.value == null || nombre1.value == ''){
        mensajesError.push('ingresa por favor tu primer nombre')
    }
    if(apellido1.value == null || apellido1.value == ''){
        mensajesError.push('ingresa por favor tu primer apellido')
    }
    if(apellido2.value == null || apellido2.value == ''){
        mensajesError.push('ingresa por favor tu segundo apellido')
    }
    if(email.value == null || email.value == ''){
        mensajesError.push('ingresa por favor tu correo electronico personal')
    }
    if(edad.value == ''){
        mensajesError.push('ingresa por favor tu edad en años')
    }
    if(telefono.value == null || telefono.value == ''){
        mensajesError.push('ingresa por favor tu telefono')
    }
    if(direccion.value == null || direccion.value == ''){
        mensajesError.push('ingresa por favor tu direccion')
    }
    if(contraseña.value == null || contraseña.value == ''){
        mensajesError.push('ingresa por favor tu contraseña')
    }
    error.innerHTML = mensajesError.join(', ');
    
    return false
    }

    


