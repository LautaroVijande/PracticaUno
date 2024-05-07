using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.Models
{
    internal class Cerveza : Bebida
    {
        public Cerveza (int Cantidad, string Nombre = "Cerveza")
            : base(Nombre, Cantidad)
        {

        }

        public int alcohol { get; set; }

        public void maxRecomendado()
        {
            Console.WriteLine("El maximo de vinos es de 5 litros por persona");
        }
    }
}
