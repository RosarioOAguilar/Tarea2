using System;

namespace Herencia2
{
	public class Empleado:Persona
	{
		protected float sueldo;
		public float Sueldo
		{
			get{
				return sueldo;
			}
			set{
				sueldo=value;
			}
		}
		new public void Imprimir ()
		{
			base.Imprimir();
			Console.WriteLine("sueldo:$"+sueldo);		
		}
	}
}