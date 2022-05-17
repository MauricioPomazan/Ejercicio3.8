using ParcilApp;

AtraccionTuristica oAtraccion = new AtraccionTuristica();
oAtraccion.pNombre = "Casino jaja";
oAtraccion.pCosto = 1000;

Crucero oCrucero = new Crucero();
oCrucero.Duracion = 3;
oCrucero.Descripcion = "Crucero por italia";
oCrucero.Destino = 1;
oCrucero.CostoDiario = 100;
oCrucero.Atraccion = oAtraccion; //aca estamos componiendo la relacion a 1
oCrucero.Numero = 1223;
oCrucero.CantidadEstrellas = 4;

VisitaCiudad oVisita = new VisitaCiudad("Costa Sacate");



Agencia oAgencia = new Agencia(10); // creamos una agencia con 10 posibles cruceros como oferta
bool resultado =oAgencia.RegistrarPaquete(oCrucero);// Agregamos un crucero a la agencia
if (resultado)
{
    Console.WriteLine("Se agrego un crucero con EXITO" + "\n");
}
else
    Console.WriteLine(" No Se agrego un crucero");

oAgencia.RegistrarPaquete(oVisita);

Console.WriteLine(oAgencia.MostrarCrucerosA(1));

Console.WriteLine(oAgencia.CostoTotalDePaquetes());

Console.ReadLine();
