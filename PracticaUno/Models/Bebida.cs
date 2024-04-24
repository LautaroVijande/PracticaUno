using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.Models
{
    internal class Bebida
    {
        public string nombre { get; set; }
        public int cantidad { get; set; }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetCantidad() 
        { 
           return cantidad;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }
        public Bebida(string nombre, int cantidad) //CONSTRUCTOR
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
        } 

        public void tomarse(int cuantoBebio)//CONSTRUCTOR
        {
            this.cantidad -= cuantoBebio;
        }

        public Bebida() { }
    }

}
