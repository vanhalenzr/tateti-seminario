using System;
using System.Collections;


namespace tateti
{
	public class Juego
	{
		//declaramos las propiedades
		public Tablero tablero; 
		public Jugador jugador1;
		public Jugador jugador2;

		public Juego ()
		{
			//inicializamos los objetos asociados a las
			//propiedades
			tablero = new Tablero ();
			jugador1= new Jugador("X");
			jugador2= new Jugador("O");
		}

		public int SeleccionarFicha (int jugador)
		{
			Console.Write("Jugador {0}: ingrese el nro de ficha a mover:",jugador);
			int ficha_a_mover= Convert.ToInt32(Console.ReadLine());
			return ficha_a_mover;
		}

		public int SeleccionarPosicion (int jugador, int ficha)
		{
			Console.Write("Jugador {0}: ingrese posición para la ficha {1}:",jugador,ficha);
			int posicion_elegida = Convert.ToInt32(Console.ReadLine());
			return posicion_elegida;
		}

		public void PintarTablero ()
		{

			tablero.Limpiar();
			foreach (DictionaryEntry ficha in jugador1.fichas) 
			{
				//grabamos la posicion de la ficha del jugador 
				//en el tablero, sumandole el nro de ficha
				tablero.posiciones[ficha.Value]=jugador1.tipo_ficha+ficha.Key.ToString();
			}
			foreach (DictionaryEntry ficha in jugador2.fichas) 
			{
				//grabamos la posicion de la ficha del jugador 
				//en el tablero, sumandole el nro de ficha
				tablero.posiciones[ficha.Value]=jugador2.tipo_ficha+ficha.Key.ToString();
			}
			tablero.PintarTablero();
		
		}
		public void Jugar (int jugador, int ficha, int posicion)
		{
			if (jugador == 1) 
				jugador1.fichas[ficha]=posicion;
			else
				jugador2.fichas[ficha]=posicion;

		}
	}
}

