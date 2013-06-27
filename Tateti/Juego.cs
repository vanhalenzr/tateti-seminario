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
			int ficha_a_mover = 0;

			do
			{
				Console.Write("Jugador {0}: ingrese el nro de ficha a mover:",jugador);
				try
				{
					ficha_a_mover= Convert.ToInt32(Console.ReadLine());
				}
				catch
				{
					ficha_a_mover = 0;
					Console.WriteLine("\n****************************************************");
					Console.WriteLine("| Error, se esperaba que ingrese un valor numérico |");
					Console.WriteLine("****************************************************");
				}

				if (ficha_a_mover < 1 || ficha_a_mover > 3)
				{
					Console.WriteLine("\n********************************************************************************");
					Console.WriteLine("Usted esta jugando en un tablero imaginario, deje de usar estupefacientes y consiga ayuda psiquiátrica");
					Console.WriteLine("********************************************************************************");
					Console.ReadLine();
				}

			}while(ficha_a_mover < 1 || ficha_a_mover > 9);

			return ficha_a_mover;
		}

		public int SeleccionarPosicion (int jugador, int ficha)
		{
			int posicion_elegida = 0;

			do
			{
				Console.Write ("Jugador {0}: ingrese posición para la ficha {1}:", jugador, ficha);
				try
				{
					posicion_elegida = Convert.ToInt32 (Console.ReadLine ());
				}
				catch
				{
					posicion_elegida = 0;
					Console.WriteLine("\n****************************************************");
					Console.WriteLine("| Error, se esperaba que ingrese un valor numérico |");
					Console.WriteLine("****************************************************");
				}

				if (posicion_elegida < 1 || posicion_elegida > 9)
				{
					Console.WriteLine("\n********************************************************************************");
					Console.WriteLine("Usted esta jugando en un tablero imaginario, deje de usar estupefacientes y consiga ayuda psiquiátrica");
					Console.WriteLine("********************************************************************************");
					Console.ReadLine();
				}

			}while(posicion_elegida < 1 || posicion_elegida > 9);
			
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

