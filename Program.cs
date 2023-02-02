using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPruebasVarias
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            //FIRST FACTORIAL ****************************
            //int numero = FirstFactorial(8);
            //Console.WriteLine(numero.ToString());

            ////FIRST REVERSE
            //string cadena = FirstReverse("I Love Code");
            //Console.WriteLine(cadena);

            //MULTIPLOS 3 Y 5
            int numero = Multiplos3y5(1000);
            Console.WriteLine(numero.ToString());


            Console.ReadKey();
            
        }

        public static int FirstFactorial(int num)
        {

            // code goes here
            int acumulator = num;
            int cont = 1;

            while (cont < num)
            {
                acumulator = acumulator * (num - cont);
                cont++;
            }

            return acumulator;

        }

        public static string FirstReverse(string str)
        {

            // code goes here  
            List<char> list = new List<char>();

            foreach (char str2 in str.ToCharArray())
            {
                list.Add(str2);
            }

            list.Reverse();

            string respuesta = "";

            foreach (char item in list)
            {
                respuesta = respuesta + item;
            }

            return respuesta;

        }

        public static int Multiplos3y5(int numero)
        {
            int i = 0, suma = 0;

            while(i < numero)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    suma = suma + i;
                }

                i++;
            }

            return suma;
        }


    }
}
