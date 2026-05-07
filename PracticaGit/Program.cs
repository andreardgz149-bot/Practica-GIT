class Program
{

static void Main()
{
    Cliente cliente1 = new Cliente ("Jacob Martinez","jacob123@gmail.com");
  
    Pedido pedido1 = new Pedido ("Un Ferrari bien cool y un tomate", "Un montón de pesos wou");

    cliente1.HacerPedido (pedido1);
    cliente1.MostrarInfo ();
    pedido1.Mostrarinfo ();
}

}