using System;

namespace Aula1_C
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Informe o primeiro valor: ");
			int valor1 = Convert.ToInt16(Console.ReadLine());
			Console.Write("Informe o segundo valor: ");
			int valor2 = Convert.ToInt16(Console.ReadLine());
			Console.Write("Informe a operação desejada (+ - / *): ");
			string operacao = Console.ReadLine();
			int resultado = 0;
			if (isDivisaoZero(valor2, operacao))
			{
				Console.Write("Impossível dividir por zero.");
				return;
			}
			switch (operacao)
			{
				case "+": resultado = valor1 + valor2;
					break;
				case "-":
					resultado = valor1 - valor2;
					break;
				case "/":
					resultado = valor1 / valor2;
					break;
				case "*":
					resultado = valor1 * valor2;
					break;
				default: Console.Write("Operação inválida.");
					break;
			}
			Console.WriteLine($"{valor1} {operacao} {valor2} = {resultado}");
		}

		private static bool isDivisaoZero(int valor, string operacao)
		{
			return valor == 0 && operacao == "/";
		}

	}
}
