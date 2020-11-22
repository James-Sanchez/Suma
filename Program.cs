using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
	class Program
	{
		static void Main(string[] args)
		{
			Herramienta herramienta = new Herramienta();
			herramienta.setMensajes("Introduce el primer numero", "Introduce el segundo numero");
			herramienta.realizarSuma();
			herramienta.imprimirResultado();
		}
	}
}
