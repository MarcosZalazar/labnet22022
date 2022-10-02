const campoNombre = document.getElementById("fNombre");
const campoApellido = document.getElementById("fApellido");
const formularioRegistro= document.getElementById("formularioRegistro");

formularioRegistro.addEventListener("submit", 
function(e){
    e.preventDefault();

    if(ValidarCamposCompletados(campoNombre.value,"nombre") && 
       ValidarCamposCompletados(campoApellido.value,"apellido"))
    {
        alert("Hemos registrado sus datos. A la brevedad nos contactaremos con usted");
    }
});

function ValidarCamposCompletados(valorIngresado,campoAValidar)
{
    var ingresoValidado=true;
    if(valorIngresado.length==0)
    {
        alert(`El campo ${campoAValidar} está vacío.`);
        var ingresoValidado=false;
    }

    return ingresoValidado;
}

function BorrarFormulario()
{
    formularioRegistro.reset();
}
    
