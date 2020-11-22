using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
	class Program
	{
		static void Integers()
		{

			string entrada1, entrada2;
			float resultado, n1, n2;


			while (true)
			{
				Console.WriteLine("Ingresa el primer número: ");
				entrada1 = Console.ReadLine();
				if (float.TryParse(entrada1, out n1))
				{
					//n1 = entrada1;
					break;
				}
				else
				{
					Console.WriteLine("No puedes introducir ningún otro caracter. Solo números.");
				}
			}

			while (true)
			{
				Console.WriteLine("Ingresa el segundo número: ");
				entrada2 = Console.ReadLine();
				if (float.TryParse(entrada2, out n2))
				{
					//n2 = entrada2;
					break;
				}
				else
				{
					Console.WriteLine("No puedes introducir ningún otro caracter. Solo números.");
				}
			}

			resultado = n1 + n2;
			Console.WriteLine("El resultado es: " + resultado);

			Console.ReadKey();
		}
		static void Main(string[] args)
		{
			Integers();
		}
	}
}
