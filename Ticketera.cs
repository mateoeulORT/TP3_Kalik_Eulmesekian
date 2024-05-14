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

int CambiarEntrada;

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

}   
