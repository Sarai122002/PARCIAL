using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial__I
{
    class Program
    {
        static void Main(string[] args)
		{

			const int oportunidades = 3;
			int num, entrada;
			byte i, adivinado;
			string linea;
			num = 7;

			i = 1; adivinado = 0;
			do
			{
				Console.WriteLine("ADIVINE EL NUMERO!");
				Console.WriteLine("                            ");
				Console.Write("Piense un numero entre 1 y 10:");
				linea = Console.ReadLine();
				entrada = int.Parse(linea);
				if ((entrada == num))
				{
					Console.WriteLine("Has adivinado el numero");
					adivinado = 1;
				}
				else
				{
					if ((entrada > num))
					{
						Console.WriteLine("El numero es incorrecto intenta de nuevo");
						Console.WriteLine("                            ");
					}
					else
					{
						Console.WriteLine("El numero es incorrecto intenta nuevamente");
						Console.WriteLine("                            ");
					}
				}
				i++;
			} while (((i <= oportunidades) & (adivinado == 0)));
			if ((adivinado == 0))
			{
				Console.Write("Ha agotado tus intentos... El numero era: " + num);
			}

			Console.WriteLine();
			Console.Write("Pulse una Tecla:");
			Console.ReadLine();
		}
	}
}