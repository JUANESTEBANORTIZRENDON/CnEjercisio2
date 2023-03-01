using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnEjercisio2
{
    internal class Program
    {
        /// <summary>
        ///nombre:Juan Esteban Ortiz Rendon
        ///Fecha:28/08/2023
        ///Descripcion:Algoritmo para cargar datos sobre los tres ladops de un triangulo y muestre cual es el lado de mayor valor y si es un triangulo equilatero np
        ///</summary>

        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor escriba el Lado 1 del triangulo");
            double l1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Porfavor escriba el Lado 2 del triangulo");
            double l2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Porfavor escriba el Lado 3 del triangulo");
            double l3 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("El lado mayor es:" + NumMayor(l1, l2, l3));
            Equilatero(l1, l2, l3);
            Console.ReadKey();

        }
        public static double NumMayor(double l1, double l2, double l3)
        {


            if (l1 > l2 & l1 > l3)
            {

                return l1;
            }

            else if (l2 > l1 & l2 > l3)
            {
                return l2;
            }
            else
            {
                return l3;
            }


        }
        public static double Equilatero(double l1, double l2, double l3)
        {


            if (l1 == l2 & l1 == l3 & l2 == l3)
            {

                Console.WriteLine("El triangulo es Equilatero");
                return l1;
            }
            else
            {

                Console.WriteLine("El triangulo no es equilatero");
                return l2;
            }
        }
    }

}
