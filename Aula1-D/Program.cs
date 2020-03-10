using System;

namespace Aula1_D
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 10; i++)
			{
				Console.Write(i < 9 ?  i + ", " : i + ".");
			}
			Console.Write("\n");
			int j = 0;
			while (j < 10)
			{
				Console.Write(j < 9 ? j + ", " : j + ".");
				j++;
			}
		}
	}
}
