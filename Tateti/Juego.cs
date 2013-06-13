using System;

namespace Tateti
{
	public class Juego
	{
		public Tablero tablero;
		public Jugador jugador1;
		public Jugador jugador2;

		public Juego ()
		{
			//declaramos e inicializamos los objetos
			tablero = new Tablero();
			jugador1 = new Jugador("X");
			jugador2 = new Jugador("O");
		}

		public void Jugar (int jugador, int ficha, int posicion)
		{
			if (jugador == 1)
					tablero.posiciones[posicion] = jugador1.tipo_ficha;
				else
					tablero.posiciones[posicion] = jugador2.tipo_ficha;
		}

	}
}

