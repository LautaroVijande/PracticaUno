using PracticaUno.Models;

class program
{

    static void Main(string[] args)
    {
        int[] numeros = new int[5] {1, 2, 3, 4, 5 };
        int numero1 = numeros[0];

        Console.WriteLine(numeros);
        Console.WriteLine(numeros.Length);

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Iteracion: " + i + " - " + numeros[i]);
        }

        Console.WriteLine("-------------------------------");

        foreach(var numero in numeros)
        {
            Console.WriteLine (numero);
        }

        Bebida bebida = new Bebida();
        Bebida bebida1 = new Bebida("CocaCola", 500);
        Bebida bebida2 = new Bebida("Fanta", 500);
        //bebida.nombre = "CocaCola";
        //bebida.cantidad = 500;

        bebida.SetNombre("Pepsi");
        bebida.SetCantidad(100);
        bebida1.tomarse(100); 
        bebida2.tomarse(300);
        Console.WriteLine("A la persona le queda " + bebida1.cantidad + "cc de la bebida " + bebida1.nombre);
        Console.WriteLine("A la persona le queda " + bebida2.cantidad + "cc de la bebida " + bebida2.nombre);
        Console.WriteLine("A la persona le queda " + bebida.cantidad + "cc de la bebida " + bebida.nombre);


        
    }

}