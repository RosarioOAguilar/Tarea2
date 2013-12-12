using System;

namespace Herencia2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Persona persona1 = new Persona();
			persona1.Nombre="Rosario";
			persona1.Edad=19;
			Persona persona2 = new Persona();
			persona2.Nombre="Gerardo";
			persona2.Edad=18;
			Console.WriteLine("Informacion:");
			persona1.Imprimir();
			persona2.Imprimir();
			Empleado empleado1=new Empleado();
			empleado1.Nombre="Magno";
			empleado1.Edad=18;
			empleado1.Sueldo=4500;
			Empleado empleado2=new Empleado();
			empleado2.Nombre="Vladimir";
			empleado2.Edad=32;
			empleado2.Sueldo=6000;
			Console.WriteLine("\nlos datos de los empleados son");
			empleado1.Imprimir();
			empleado2.Imprimir();
			
			Console.ReadKey();
		}
	}
}