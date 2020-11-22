using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    class Herramienta
    {
        private string entrada1;
        private string entrada2;
        private string mensaje1;
        private string mensaje2;
		private string mensajeAdvertencia = "No puedes introducir ningún otro caracter.Solo números.";
        private float n1;
        private float n2;
        private float resultado;

        public void setMensajes(string primermensaje, string segundomensaje)
        {
            this.mensaje1 = primermensaje;
            this.mensaje2 = segundomensaje;
        }
        public void realizarSuma()// Devuelve verdadero si el dato ingresado es un numero
        {
			while (true)
			{
				Console.WriteLine(mensaje1);
				entrada1 = Console.ReadLine();
				if (float.TryParse(entrada1,out n1))
				{
					break;
				}
				else
				{
					Console.WriteLine(mensajeAdvertencia);
				}
			}

			while (true)
			{
				Console.WriteLine(mensaje2);
				entrada2 = Console.ReadLine();
				if (float.TryParse(entrada2, out n2))
				{
					break;
				}
				else
				{
					Console.WriteLine(mensajeAdvertencia);
				}
			}
			resultado = n1 + n2;
		}
        public void imprimirResultado()
        {
            Console.WriteLine("\nEl resultado es: " + resultado + "\nPresiona cualquier tecla para finalizar el programa");
			Console.ReadKey(true);
        }
    }
}
