using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.__POO___Clases
{
	class Program
	{
		static void Main(string[] args)
		{
			Empleado e1 = new Empleado();
			e1.nombre = "Juan";
			e1.apellido = "Roldán";
			e1.departamento = "Mantenimiento";
			e1.sexo = false;
			e1.sueldo = 2000;

			Console.WriteLine(e1.obtenerFicha());

			Console.ReadKey();


		}
	}

	public class Empleado
	{	
		// Properties
		public string nombre { get; set; }
		public string apellido { get; set; }
		public string departamento { get; set; }
		public bool sexo { get; set; } // 0 => Hombre, 1 => Mujer

		public string sexo_legible
		{
			get
			{
				if(sexo) return "Mujer";
				else return "Hombre";
			}
		}
		public double sueldo { get; set; }

		// Métodos
		public string obtenerFicha()
		{
			string ficha = $"Nombre: {this.nombre} {this.apellido}, Sueldo: {this.sueldo}, Sexo: {this.sexo_legible}";

			return ficha;
		}

		public void subirsueldo(double dinero)
		{
			this.sueldo += dinero;
		}




	}
}
