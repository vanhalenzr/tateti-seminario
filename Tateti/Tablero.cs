using System;
using System.Collections;

namespace Tateti
{
	public class Tablero
	{
		public Hashtable posiciones;
			

		public Tablero ()
		{
			posiciones = new Hashtable();
				for(int x=1; x<10; x++)
					posiciones.Add(x," ");
		}



		public void PintarTablero ()
		{
			Console.Clear();

			Console.WriteLine("**********************************************");
			Console.WriteLine("| Welcome to the most cheater Tateti Ever!!! |");
			Console.WriteLine("**********************************************\n");

			for(int x=1; x<10; x++)
			{
				Console.Write("[{0}]", posiciones[x]);
				//Comprobamos si ya se imprimieron 3 posiciones
				//y hacemos un salto de línea
				if(x%3==0)
					Console.Write("\n");
			}
		}
	}
}
