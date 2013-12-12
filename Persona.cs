using System;

namespace Herencia2
{
	public class Persona
	{
		protected string nombre;
		protected int edad;
		public string Nombre
		{
			get {
				return nombre;
			}
			set 
			{
				nombre=value;
			}
			
		}
		public int Edad
		{
			get {
				return edad;
			}
			set{
				edad=value;
			}
		}
		public void Imprimir ()
		{
			Console.WriteLine("\nNombre:"+Nombre);
			Console.WriteLine("Edad:"+Edad);
		}
	}
}
