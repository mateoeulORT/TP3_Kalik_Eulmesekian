int rta;


do
{
    Console.WriteLine("1. Nueva Inscricion");
    Console.WriteLine("2. Obtener estadisticas");
    Console.WriteLine("3. Buscar cliente");
    Console.WriteLine("4. Cambiar entrada de un cliente");
    Console.WriteLine("5. Salir");
    
    rta = IngresarMenu("INGRESE UNA OPCION:");

    switch (rta)
    {
        
        case 1:
            break;

        case 2:
            break;

        case 3:
            break;

        default:
            break;
    }

} while (rta != 5);



static int IngresarMenu (string mensaje){
    int num;
    do
    {
        Console.WriteLine(mensaje);
        num = int.Parse(Console.ReadLine());
    } while (num < 0 || num > 5);
    return num;
}








