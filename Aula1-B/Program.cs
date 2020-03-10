using System;

namespace Aula1_B
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Informe seu nome: ");
			string nome = Console.ReadLine();
			Console.Write("Informe sua idade: ");
			int idade = Convert.ToInt16(Console.ReadLine());
			string texto = idade >= 18 ? "maior" : "menor";
			Console.Write($"Seu nome é {nome} e você é {texto} de idade.");
		}
	}
}
