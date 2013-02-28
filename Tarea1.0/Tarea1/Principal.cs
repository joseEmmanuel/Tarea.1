using System;

namespace Tarea1
{
	class Principal
	{

		public void IngresaDatos ()
		{
			Persona persona = new Persona();

			Console.WriteLine("INGRESA TU NOMBRE");
			persona.nombre = Console.ReadLine();
			
			Console.WriteLine("INGRESA TU TELEFONO");
			persona.telefono = Console.ReadLine();
			
			
			Console.WriteLine("INGRESA TU EMAIL");
			persona.email = Console.ReadLine();
			
			
			Console.WriteLine("INGRESA TU DOMICILIO");
			persona.domicilio = Console.ReadLine();
			
			Console.Clear();
			Console.WriteLine("NOMBRE: "+ persona.nombre + 
			                  "\nTELEFONO: " + persona.telefono + 
			                  "\nEMAIL: " + persona.email +
			                  "\nDOMICILIO: " + persona.domicilio);
		}

			
			
		

		public static void Main (string[] args)
		{
			Principal programa = new Principal();
			programa.IngresaDatos();






		}
	}
}
