using PracticaUno.Models;

class program
{

    static void Main(string[] args)
    {
        Bebida bebida = new Bebida("CocaCola", 500);
        Bebida bebida2 = new Bebida("Fanta", 500);
        //bebida.nombre = "CocaCola";
        //bebida.cantidad = 500;

        bebida.tomarse(100); 
        bebida2.tomarse(300);
        Console.WriteLine("A la persona le queda " + bebida.cantidad + "cc de la bebida " + bebida.nombre);
        Console.WriteLine("A la persona le queda " + bebida2.cantidad + "cc de la bebida " + bebida2.nombre);

    }

}