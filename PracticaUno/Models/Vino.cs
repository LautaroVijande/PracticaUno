using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.Models
{
    internal class Vino : Bebida
    {
        public Vino(int Cantidad, string Nombre = "Vino")
            : base(Nombre, Cantidad)        
        {

        }
            
        public int alcohol { get; set; }            
        
        public void maxRecomendado ()
        {
            Console.WriteLine("El maximo de vinos es de dos botellas por persona");
        }
    }
}
