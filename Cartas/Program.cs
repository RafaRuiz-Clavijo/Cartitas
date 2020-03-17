using System;

namespace Cartas
{
    class Program
    {
        static void Main(string[] args)
        {
            //El usuario escoge una carta al azar y puede elegir su apuesta
            //Tiene que tener mas de 5000 para jugar, si no tiene esa plata se va
            //Puede elegir Color (si gana recibe 2x)
            //Puede elegir Simbolo (Si gana recibe 4x)
            //Puede elegir Numero (Si gana recibe 8x)
            //Puede elegir Carta exacta (Si gana recibe 32x)
            //El jugador elige cuanto apuesta
            //Ve si gana


            Gerente g = new Gerente();
            g.dinero = 0;
            g.Plata();
            g.Verificar(g.dinero);

            //Ya que supuestamente hay dinero se puede jugar

            Naipes juego = new Naipes();
            juego.dinero = g.dinero;
            juego.a = 0;
            juego.b = 0;
            juego.c = 0;
            juego.num = "";
            juego.simb = "";
            juego.col = "";
            juego.apuesta = 0;
            juego.dinero_apostado = 0;
            while (juego.dinero > 0)
            {
                Console.WriteLine("Dinero: " + juego.dinero);
                juego.ElegirCarta();
                juego.ElegirApuesta();
                juego.Resultado();
                juego.PlayAgain();
            }
        }
    }
}
