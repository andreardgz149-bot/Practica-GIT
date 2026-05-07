using System.Text;

class Cliente
{
    //atributos

    public string nombre { get; private set; }
    public string correo { get; private set; }
  

   //constructor
    public Cliente(string n, string c)
    {
        nombre = n;
        correo=c;
    }
   //metodos
    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {nombre} | Correo: {correo}");
    }

    public void HacerPedido (Pedido pedido) 
    {
        Console.WriteLine (nombre + " realizó un pedido con éxito");
    }
}
