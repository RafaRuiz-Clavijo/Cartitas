using System;
using System.Collections.Generic;
using System.Text;

namespace Cartas
{
    public class Naipes
    {
        public string num; //Indica el numero que indica el usuario
        public string simb; //Indica el simbolo que indica el usuario
        public string col; //Indica el color que indica el usuario
        public int a; //Indica el numero de la carta
        public int b; //Indica el simbolo de la carta
        public int c; //Indica el color de la carta
        public int dinero; //Indica el dinero del usuario
        public int dinero_apostado; //Indica el dinero apostado
        public int apuesta; //Indica la apuesta

        public void ElegirCarta()
        {
            Random rnd = new Random();
            a = rnd.Next(1, 14); //Elije el numero (A,2,3,4,5,6,7,8,9,10,J,Q,K)
            b = rnd.Next(1, 5); //Elige el simbolo (Corazon, Pica, Diamante, Trebol)
            c = rnd.Next(1, 3); //Elige color (Rojo, Negro)

            //La funcion rnd.Next va en un intervalo abierto al final

        }
        public void ElegirApuesta()
        {
            Console.WriteLine("Elija la apuesta: ");
            Console.WriteLine("1) Numero (8x)");
            Console.WriteLine("2) Simbolo (4x)");
            Console.WriteLine("3) Color (2x)");
            Console.WriteLine("4) Numero, Simbolo, Color (32x)");
            apuesta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Elije la cantidad de dinero a apostar");
            dinero_apostado = Convert.ToInt32(Console.ReadLine());
            if (dinero_apostado <= dinero)
            {
                dinero -= dinero_apostado;
            }
            else
            {
                Console.WriteLine("No tiene ese dinero, no puede apostar");
                Environment.Exit(0);
            }

            if (apuesta == 1 || apuesta == 4)
            {
                Console.WriteLine("Indique el numero/letra (A,2,3,4,5,6,7,8,9,10,J,Q,K)");
                num = Console.ReadLine();
            }
            if (apuesta == 2 || apuesta == 4)
            {
                Console.WriteLine("Indique el simbolo (Corazon, Pica, Diamante, Trebol)");
                simb = Console.ReadLine();
            }
            if (apuesta == 3 || apuesta == 4)
            {
                Console.WriteLine("Indique el color (Rojo, Negro)");
                col = Console.ReadLine();
            }

        }

        public void Resultado()
        {
            int n_carta = 0;
            int s_carta = 0;
            int c_carta = 0;

            if (apuesta == 1 || apuesta == 4)
            {
                if (num == "A")
                {
                    n_carta = 1;
                }
                else if (num == "J")
                {
                    n_carta = 11;
                }
                else if (num == "Q")
                {
                    n_carta = 12;
                }
                else if (num == "K")
                {
                    n_carta = 13;
                }
                else
                {
                    n_carta = Convert.ToInt32(num);
                }
            }

            if (apuesta == 2 || apuesta == 4)
            {
                if (simb == "Corazon")
                {
                    s_carta = 1;
                }
                if (simb == "Pica")
                {
                    s_carta = 2;
                }
                if (simb == "Diamante")
                {
                    s_carta = 3;
                }
                if (simb == "Trebol")
                {
                    s_carta = 4;
                }
            }

            if (apuesta == 3 || apuesta == 4){
                if (col == "Rojo")
                {
                    c_carta = 1;
                }
                if (col == "Negro")
                {
                    c_carta = 2;
                } 
            }

            if (apuesta == 1 && n_carta == a)
            {
                dinero += dinero_apostado * 8;
                Console.WriteLine("Adivinaste el numero");
            }
            else if (apuesta == 2 && s_carta == b)
            {
                dinero += dinero_apostado * 4;
                Console.WriteLine("Adivinaste el simbolo");
            }
            else if (apuesta == 3 && c_carta == c)
            {
                dinero += dinero_apostado * 2;
                Console.WriteLine("Adivinaste el color");
            }
            else if (apuesta == 4 && n_carta == a && s_carta == b && c_carta == c)
            {
                dinero += dinero_apostado * 32;
                Console.WriteLine("Adivinaste todo, felicidades");
            }
            else
            {
                Console.WriteLine("Perdiste");
            }
        }

        public void PlayAgain()
        {
            if (dinero > 0)
            {
                Console.WriteLine("Quieres jugar de nuevo? (YES/NO)");
                string res = Console.ReadLine();
                if (res == "NO")
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Te quedaste pobre, no puedes jugar");
                Environment.Exit(0);
            }

        }
    }
}
