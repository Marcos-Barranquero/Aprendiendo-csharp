using System;

namespace _21.__Ejercicios_Métodos
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine(CalcularMensualidad(120, -3.0));
			CalcularCreditoEntero(24, 12000, 3);

			Console.ReadKey();
		}

		static double CalcularMensualidad(double cantidad, double porcentaje)
		{
			return cantidad + (cantidad * porcentaje/100);
		}

		static void CalcularCreditoEntero(int nmeses, double cantidad, double porcentaje)
		{
			Console.WriteLine($"Crédito por {cantidad} a pagar en {nmeses} meses. " +
			                  $"Comisión mensual: {porcentaje} %");

			double cantidadPorMes = cantidad / nmeses;
			double pagoCadaMes = CalcularMensualidad(cantidadPorMes, porcentaje);

			Console.WriteLine($"Cada mes se pagará {pagoCadaMes} euros.");

			Console.WriteLine($"En total se pagará {pagoCadaMes * nmeses} euros.");

			Console.WriteLine($"El banco se llevará en concepto de intereses la cantidad de " +
			                  $"{pagoCadaMes * nmeses - cantidad} euros.");


		}
	}
}