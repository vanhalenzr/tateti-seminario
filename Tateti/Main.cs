using System;
using System.Collections;

namespace tateti
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//inicializamos las variables
			int jugador_actual = 1;
			int ficha_actual = 1;

			Juego juego= new Juego();
			//abrimos un bucle que dure indefinidamente 
			//hasta que finalice el juego
			while (true) 
			{
				juego.PintarTablero ();
				if (ficha_actual==0)
				{
					Console.Write("Jugador {0}: ingrese el nro de ficha a mover:",jugador_actual);
					int ficha_a_mover= Convert.ToInt32(Console.ReadLine());
					Console.Write("Jugador {0}: ingrese posición para la ficha {1}:",jugador_actual,ficha_a_mover);
					int posicion_elegida = Convert.ToInt32(Console.ReadLine());
					//imprimiendo el tipo ficha apropiado según el 
					//jugador actual
					juego.Jugar(jugador_actual,ficha_a_mover,posicion_elegida);
				}
				else
				{
					Console.Write("Jugador {0}: ingrese posición para la ficha {1}:",jugador_actual,ficha_actual);
					int posicion_elegida = Convert.ToInt32(Console.ReadLine());
					//imprimiendo el tipo ficha apropiado según el 
					//jugador actual
					juego.Jugar(jugador_actual,ficha_actual,posicion_elegida);
				}
				jugador_actual++;

				if (jugador_actual==3)
				{
					jugador_actual=1;
					//solucion al problema despues del movimiento 8
					if(ficha_actual>0)
						ficha_actual++;
					if (ficha_actual==4)
					{
						ficha_actual=0;
					}
				}

			}

		}


	}
}