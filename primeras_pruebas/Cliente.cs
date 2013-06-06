using System;

namespace primeras_pruebas
{
	public class Cliente
{
	private string codigo, nombre, apellido, direccion, localidad, telefono;
	
	private DateTime fecha_nacimiento;

	private void CapturarNombre()
	{
			Console.Write ("Ingrese su nombre: ");
			nombre = Console.ReadLine();
			if (nombre == "") {
				Console.WriteLine("Error! No es un nombre válido");
				CapturarNombre();
			}
	}

	private void CapturarApellido()
	{
			Console.Write("Ingrese su apellido: ");
			apellido = Console.ReadLine();
			if (apellido == "") {
				Console.WriteLine("Error! No es un apellido válido");
				CapturarApellido();
			}
	}

	private void CapturarDireccion()
	{
			Console.Write("Ingrese su dirección: ");
			direccion = Console.ReadLine();
			if (direccion == "") {
				Console.WriteLine("Error! No es una dirección válida");
				CapturarDireccion();
			}
	}

	private void CapturarLocalidad()
	{
			Console.Write("Ingrese su localidad: ");
			localidad = Console.ReadLine();
			if (localidad == "") {
				Console.WriteLine("Error! No es una localidad válida");
				CapturarLocalidad();
			}
	}
	
	private DateTime CapturarFecha()
	{
			Console.Write ("Ingrese su Fecha de Nacimiento: ");
			try {
				fecha_nacimiento = Convert.ToDateTime (Console.ReadLine ());
			} catch {
				Console.WriteLine ("Error! ingrese la fecha correctamente");
				CapturarFecha();
			}
			return fecha_nacimiento;
	}

	private string AnunciarEdad ()
    {
            //Tomamos la fecha de hoy y la almacenamos en la
			//variable "hoy"
			DateTime hoy = DateTime.Now;
            int edad=0;
			//Evalua si la persona ya cumplio años en el año
			//actual
            if (hoy.DayOfYear >= fecha_nacimiento.DayOfYear)
            {
                edad = hoy.Year - fecha_nacimiento.Year;
            } else {
                edad = (hoy.Year - fecha_nacimiento.Year)-1;
            }
            return "Tengo "+edad + " años";
           
    }

	private void CapturarTelefono()
	{
			Console.Write("Por último ingrese su teléfono: ");
			telefono = Console.ReadLine();
			if (telefono == "") {
				Console.WriteLine("Error! No es un telefono válido");
				CapturarTelefono();
			}
	}
	
	private void CapturarCodigo ()
	{
			Console.Write("Ingrese un código: ");
			codigo = Console.ReadLine();
			if (codigo == "") {
				Console.WriteLine("Error! No es un codigo válido");
				CapturarCodigo();
			}
	}

	private string Presentarse ()
	{
			return "Hola soy "+apellido+" "+nombre;
	}
	
	private string AnunciarDomicilio ()
	{
			return "Vivo en  "+direccion+" "+localidad;
	}

	public void Hablar ()
	{
			for (int x = 0; x < 32; x++)
				Console.Write("*");

			Console.WriteLine("");
			Console.WriteLine(Presentarse());
			Console.WriteLine(AnunciarDomicilio());
			Console.WriteLine(AnunciarEdad());
	}
	
	public void CapturarDatos ()
	{
			CapturarCodigo();
			CapturarApellido();
			CapturarNombre();
			CapturarDireccion();
			CapturarFecha();
			CapturarLocalidad();
			CapturarTelefono();
	}
 
	public void ImprimirFicha() 
	{
		Console.WriteLine("\n******************************");
		Console.WriteLine("| PRUEBAS DE CONSOLA EN \"C#\" |");
		Console.WriteLine("******************************");
		Console.WriteLine("**************************");
		Console.WriteLine("| FICHA PERSONAL CLIENTE |");
		Console.WriteLine("**************************");
		Console.WriteLine("Nombre: " + nombre);
		Console.WriteLine("Apellido: " + apellido);
		Console.WriteLine("Direccion: " + direccion); 
		Console.WriteLine("Localidad: " + localidad);
		Console.WriteLine("Fecha de Nacimiento: " + fecha_nacimiento.ToShortDateString());
		Console.WriteLine("Telefono: " + telefono);
	}
}
}

