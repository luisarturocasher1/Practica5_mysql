
using System;

namespace Practica5_mysql
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Alumnos al = new Alumnos();
			int registros= 0;
			
				
		
			
				Console.WriteLine("Elige ");
				Console.WriteLine("1.Agrega tupla");
				Console.WriteLine("2.Consultar tuplas.");
				
				
				int con = Int32.Parse( Console.ReadLine() );
				switch(con)
						
					{
					case 1:
						
						int codigo = 0;
						Console.WriteLine("dame el codigo del Alumno:");
						codigo = int.Parse( Console.ReadLine() );
						
								
						Console.WriteLine("dame el nombre del Alumno:");
						String nombre = Console.ReadLine();
						int telefono = 0;
					
						Console.WriteLine("Ingrese el TELÉFONO del Alumno:");
						telefono = Int.Parse( Console.ReadLine() );
					
						
						Console.WriteLine("Ingrese el E-MAIL del Alumno:");
						String email = Console.ReadLine();
					
										
						al.insertarRegistroNuevo(codigo,nombre,telefono,email);
						break;	
						
						
					case 2:
			
					al.mostrarTodos();
				
						break;
					
						
					
				}
				
			Console.ReadKey(true);	
		}
	}
}


