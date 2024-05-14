class Ticketera
{
private static Dictionary<int, Cliente> DicClientes = new Dictionary<int, Cliente>();
private static int ultimoIdEntrada = 0;
int DevolverUltimoID;

public static int AgregarCliente(Cliente clienteIngresado){
    int ID = ultimoIdEntrada + 1;
    ultimoIdEntrada = ID;
    DicClientes.Add(ultimoIdEntrada, clienteIngresado);
    return ID;
    
}

public static bool CambiarEntrada(int id, int tipo, int cant){

    bool sePudo = false;
    int[] precios = new int[]{45000, 60000, 30000, 100000};
    if (DicClientes.ContainsKey(id))
    {
        if (precios[tipo - 1] > precios[DicClientes[id].TipoEntrada - 1])
        {
            DicClientes[id].FechaInscripcion = DateTime.Now;
            DicClientes[id].TipoEntrada = tipo;
            DicClientes[id].Cantidad = cant;
            Console.WriteLine("Se realizó el cambio");
            sePudo = true;
        } else
        {
            Console.WriteLine("NO se realizó el cambio");
            sePudo = false;
        }
    }
    return sePudo;


}

public static Cliente BuscarCliente (int ID){
    Cliente clienteEncontrado;
    if (DicClientes.ContainsKey(ID))
    {
        clienteEncontrado = DicClientes[ID];
    } else
    {
        clienteEncontrado = null;
    }
    return clienteEncontrado;
}

public static List<string> EstadisticasTicketera (){
    const int VALOR1 = 45000, VALOR2 = 60000, VALOR3 = 30000, VALOR4 = 100000;
    int entrada1 = 0, entrada2 = 0, entrada3 = 0, entrada4 = 0;

    List<string> listaEstadisticas = new List<string>();
    listaEstadisticas.Add($"En total hay {DicClientes.Count} clientes");

    foreach (Cliente valor in DicClientes.Values)
    {
        if (valor.TipoEntrada == 1)
        {
            entrada1++;          
        } else if(valor.TipoEntrada == 2)
        {
            entrada2++;
        }else if(valor.TipoEntrada == 3)
        {
            entrada3++;
        }else
        {
            entrada4++;
        }
    }
    listaEstadisticas.Add($"DIA 1: {entrada1} - DIA 2: {entrada2} - DIA 3: {entrada3} - FULL: {entrada4}");

    int recaudacion1 = entrada1 * VALOR1, recaudacion2 = entrada2  * VALOR2, recaudacion3 = entrada3 * VALOR3, recaudacion4 = entrada4 * VALOR4;
    int recaudacionTotal = recaudacion1 + recaudacion2 + recaudacion3 + recaudacion4;

    int porcRec1 = (recaudacion1 * 100) / recaudacionTotal;
    int porcRec2 = (recaudacion2 * 100) / recaudacionTotal;
    int porcRec3 = (recaudacion3 * 100) / recaudacionTotal;
    int porcRec4 = (recaudacion4 * 100) / recaudacionTotal;

    listaEstadisticas.Add($"% RECAUDACION: DIA 1: {porcRec1}% - DIA 2: {porcRec2}% - DIA 3: {porcRec3}% - FULL: {porcRec4}%");

    listaEstadisticas.Add($"RECAUDACION POR DIA: DIA 1: ${recaudacion1} - DIA 2: ${recaudacion2} - DIA 3: ${recaudacion3} - FULL: ${recaudacion4}");
    listaEstadisticas.Add($"En total se recaudó {recaudacionTotal}");

    return listaEstadisticas;


}



}   

