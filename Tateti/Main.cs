using System;
using System.Collections;

namespace Tateti
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Inicializamos variables
			int jugador_actual = 1;
			int ficha_actual = 1;

			while (true) 
			{
				tablero.PintarTablero ();
				if (ficha_actual == 0)
				{
					Console.Write("\nJugador {0}: Ingrese el nro de ficha a mover: ", jugador_actual, ficha_actual);
					ficha_actual = Convert.ToInt32(Console.ReadLine());
				}
				Console.Write("\nJugador {0}: Ingrese posición para la ficha {1}: ", jugador_actual, ficha_actual);
				int posicion_elegida = Convert.ToInt32(Console.ReadLine());

				tablero.Jugar (jugador_actual, ficha_actual, posicion_elegida)

				jugador_actual++;

				if (jugador_actual == 3)
				{
					jugador_actual=1;
					ficha_actual++;
					if (ficha_actual == 4)
						ficha_actual = 0;
				}

			}
		}

	}
}
