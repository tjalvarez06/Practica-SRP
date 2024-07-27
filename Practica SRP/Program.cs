

using Practica_SRP.Class;

Persona persona = new Persona("Juan Miguel", 30, "Calle Itla", "juan.miguel@itla.com");
ImpresionDatos impresionDatos = new ImpresionDatos();
impresionDatos.ImprimirDatos(persona);

EnvioCorreo envioCorreo = new EnvioCorreo();
envioCorreo.EnviarCorreoElectronico(persona);
