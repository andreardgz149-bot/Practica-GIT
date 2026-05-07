class Pedido
{
    //Atributos :P
    public string producto {get; private set;}
    
    public string total {get; private set;}

    //Constructor
    public Pedido (string p, string tot)
    {
        producto=p;

        total=tot;
    }

    //Métodos :D
    public void Mostrarinfo()
    {
        Console.WriteLine ($"El pedido consiste de: {producto} y su total es de: {total}");
    }

}