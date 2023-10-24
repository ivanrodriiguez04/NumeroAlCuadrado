using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroAlCuadrado.Servicios
{
    internal class NumCuadraroImplementacion : NumCuadradoInterfaz
    {
        public void calcularNumeroAlCuadrado()
        {
            double numero = pedirNum();
            double raiz=Math.Sqrt(numero);
            Console.WriteLine("La raiz cuadrada es :"+raiz);

            if (raiz * raiz == numero) 
            {
                Console.WriteLine("El numero es entero");
            } 
            else 
            {
                Console.WriteLine("El numero no es entero");
            }

        }
       
        private double pedirNum()
        {
            double numero;
            Console.WriteLine("Introduzca el numero deseado:");
            numero=Convert.ToDouble(Console.ReadLine());
            return numero;
        }
    }
}
