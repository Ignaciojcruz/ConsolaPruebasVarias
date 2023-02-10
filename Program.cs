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
            //Console.WriteLine(27);
            //FIRST FACTORIAL ****************************
            //int numero = FirstFactorial(8);
            //Console.WriteLine(numero.ToString());

            ////FIRST REVERSE
            //string cadena = FirstReverse("I Love Code");
            //Console.WriteLine(cadena);

            ////MULTIPLOS 3 Y 5
            //int numero = Multiplos3y5(10);
            //Console.WriteLine(numero.ToString());

            //ReverseUp5LettersWords
            //Console.WriteLine(ReverseUp5LettersWords("emocleW"));
            //Console.WriteLine(ReverseUp5LettersWordsBestSolution("Stop Spinning My Words!"));

            //SumaDigitosDelnumero();

            IdAndShip();


            Console.ReadKey();
            
        }

        //Devuelve la multiplicación de todos los numeros anteriores al enviado
        //i.e. f(4) = 4 * 3 * 2 * 1 = 24
        public static int FirstFactorial(int num)
        {
            // code goes her
            int acumulator = num;
            int cont = 1;

            while (cont < num)
            {
                acumulator = acumulator * (num - cont);
                cont++;
            }

            return acumulator;

        }

        //Retorna el texto enviado en reversa
        //i.e. f(este texto) = otxet etse
        public static string FirstReverse(string str)
        {
            // code goes here  
            List<char> list = new List<char>();

            ////Lista de letras
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

        //Retorna suma los multiplos de 3 y 5 de los números anteriores al enviado
        //i.e. f(10) = 3 + 5 + 6 + 9 = 23
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

        //Retorna frase enviada dando vuelta las palabras que contengan 5 o más letras
        //i.e. f(Stop Spinning My Words!) = Stop gninnipS My sdroW!
        public static string ReverseUp5LettersWords(string sentence)
        {
            //pasar frase enviada y dejarla en una lista de palabras (ojo con los que no sean letras como "!")                                    
            //Lista de palabras
            string[] words = sentence.Split(' ');
            List<string> listaResultado = new List<string>();
            string word = "", especial = "", wordReverse = "";
            char especialChar = ' ';

            
            
            //recorrer lista de palabras
            foreach (string item in words)
            {
                //identificar signos en palabra
                word = "";
                wordReverse = "";
                especialChar = ' ';
                byte[] asciiInput = Encoding.ASCII.GetBytes(item);
                foreach (byte element in asciiInput)
                {
                    if((element >= 65 && element <= 90) || (element >= 97 && element <= 122))
                    {
                        word = word + (char)element;
                    }
                    else
                    {
                        especialChar = (char)element;
                        especial = especialChar.ToString();
                    }
                }

                //si length palabra mayor a 5 hacerle reversa
                if (word.Length >= 5)
                {
                    char[] array = word.ToCharArray();
                    Array.Reverse(array);

                    wordReverse = new string(array);
                    word = "";
                }

                word = word + wordReverse + especial;

                listaResultado.Add(word);   

            }
            
            string fraseResultado = "";

            foreach (string item in listaResultado)
            {
                fraseResultado = fraseResultado + item + " ";                
            }

            fraseResultado = fraseResultado.TrimEnd();

            //devolver listado de palabras
            return fraseResultado;
        }
        public static string ReverseUp5LettersWordsBestSolution(string sentence)
        {
            return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
        }


        //Suma los dígitos del numero enviado
        public static void SumaDigitosDelnumero()
        {
            uint n = UInt32.Parse(Console.ReadLine());
            byte ans = 0;
            uint number = n;
            uint ver = 0;

            while (number > 0)
            {
                ver = number % 10;
                ans += Convert.ToByte(number % 10);
                number /= 10;
            }

            Console.WriteLine(ans);            
        }

        //Id and Ship from CodeChf
        public static void IdAndShip()
        {
            // your code goes here
            int T = int.Parse(Console.ReadLine());
            int i = 0;

            while (i < T)
            {
                string input = Console.ReadLine().ToUpper();
                char letter = input[0];

                switch (letter)
                {
                    case 'B':
                        Console.WriteLine("BattleShip");
                        break;

                    case 'C':
                        Console.WriteLine("Cruiser");
                        break;

                    case 'D':
                        Console.WriteLine("Destroyer");
                        break;

                    default:
                        break;
                }
                i++;
            }
        }

    }
}
