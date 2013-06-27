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
					//pedimos al usuario que defina cual es la ficha
					//a mover
					int ficha_a_mover = juego.SeleccionarFicha(jugador_actual);
					int posicion_elegida = juego.SeleccionarPosicion(jugador_actual,ficha_a_mover);
					//imprimiendo el tipo ficha apropiado según el 
					//jugador actual
					juego.Jugar(jugador_actual,ficha_a_mover,posicion_elegida);
				}
				else
				{
					int posicion_elegida = juego.SeleccionarPosicion(jugador_actual,ficha_actual);
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