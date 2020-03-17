using System;
using System.Collections.Generic;
using System.Text;

namespace Cartas
{
    public class Gerente
    {
        public int dinero;

        public void Plata()
        {
            Console.WriteLine("Indique la cantidad de dinero que posee (Minimo 5000 para entrar)");
            dinero = Convert.ToInt32(Console.ReadLine());
        }
        public void Verificar(int n)
        {
            if (n >= 5000)
            {
                Console.WriteLine("Puede entrar a jugar");
            }
            else
            {
                Console.WriteLine("Lo siento no puede pasar");
                Environment.Exit(0);
            }
        }
    }
}
