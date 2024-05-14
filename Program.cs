int rtaMenu, dni, tipoEntrada, cantidad, ID;
string nombre, apellido;

DateTime fechaCompra = new DateTime();
Cliente cliente;

do
{
    Console.WriteLine("1. Nueva Inscricion");
    Console.WriteLine("2. Obtener estadisticas");
    Console.WriteLine("3. Buscar cliente");
    Console.WriteLine("4. Cambiar entrada de un cliente");
    Console.WriteLine("5. Salir");
    
    rtaMenu = IngresarMenu("INGRESE UNA OPCION:");

    switch (rtaMenu)
    {
        
        case 1:
            dni = INgresarINT("Ingrese el DNI");
        
            nombre = IngresarString("Ingrese el nombre:");
            apellido = IngresarString("Ingrese el apellido:");

            Console.WriteLine("Igrese el tipo de entrada: 1. Dia 1($45.000) - 2. Dia 2($60.000) - 3. Dia 3($30.000) - 4. Full pass($100.000)");
            tipoEntrada = IngresarTipoEntrada("Ingrese una opcion:");

            cantidad = INgresarINT ("Ingrese la cant de entradas");

            fechaCompra = IngresarFecha();

            cliente = new Cliente (dni, nombre, apellido, fechaCompra, tipoEntrada, cantidad);

            ID = Ticketera.AgregarCliente(cliente);
            Console.WriteLine("Tu ID de entrada es #"+ID);
            break;

        case 2:
            break;

        case 3:
            int idIngresado = INgresarINT("Ingrese el id de una entrada:");
            Cliente clienteBuscado = Ticketera.BuscarCliente(idIngresado);

            Console.WriteLine("----- INFO DE CLIENTE #" + idIngresado + " -----");
            Console.WriteLine("NOMBRE:" + clienteBuscado.Nombre);
            Console.WriteLine("APELLIDO:" +clienteBuscado.Apellido);
            Console.WriteLine("DNI:" +clienteBuscado.DNI);
            Console.WriteLine("FECHA INSCRIPCION:" +clienteBuscado.FechaInscripcion);
            Console.WriteLine("TIPO ENTRADA:" +clienteBuscado.TipoEntrada);
            Console.WriteLine("CANTIDAD:" +clienteBuscado.Cantidad);
            break;

        case 4:
            break;
            
        default:
            break;
    }

} while (rtaMenu != 5);



static int IngresarMenu (string mensaje){
    int num;
    do
    {
        Console.WriteLine(mensaje);
        num = int.Parse(Console.ReadLine());
    } while (num < 0 || num > 5);
    return num;
}

static int INgresarINT(string mensaje){
    
    int DNI;
    Console.WriteLine(mensaje);
    DNI = int.Parse(Console.ReadLine());
    return DNI;
}

static int IngresarTipoEntrada (string mensaje){
    int num;
    do
    {
        Console.WriteLine(mensaje);
        num = int.Parse(Console.ReadLine());
    } while (num < 0 || num > 4);
    return num;
}

static string IngresarString(string mensaje){
    string rta;
    do
    {
        Console.WriteLine(mensaje);
        rta = Console.ReadLine();
    } while (rta == string.Empty);
    return rta;

}

static DateTime IngresarFecha (){
    int dia, mes, año;
    Console.WriteLine("Ingrese el dia, luego el mes y luego el año:");
    dia = int.Parse(Console.ReadLine());
    mes = int.Parse(Console.ReadLine());
    año = int.Parse(Console.ReadLine());
    DateTime fecha = new DateTime(año, mes, dia);
    return fecha;
} 


