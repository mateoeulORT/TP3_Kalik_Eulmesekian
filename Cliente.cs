class Cliente {
    //Atributos
    public int DNI { get; private set; }
    public string Nombre { get; private set; }
     public string Apellido { get; private set; }
    public DateTime FechaInscripcion { get; set; } 
    int TipoEntrada {get; set;}
    int Cantidad{get; set;}

   public Cliente(int dni, string nombre, string apellido, DateTime fechaInscripcion, int tipoEntrada, int cant)
   {
      DNI = dni;
      Nombre = nombre;
      Apellido = apellido;
      FechaInscripcion = fechaInscripcion;
      TipoEntrada = tipoEntrada;
      Cantidad = cant;

   }
    

}