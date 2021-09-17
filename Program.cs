using System;

namespace Projetil
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double pi = Math.PI;

            double g = 9.80665;

            string veloc, ang;

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-*-Projetil-*-");
            Console.ResetColor();
            Console.WriteLine(" ");

            Console.Write("Entre com a velocidade, em m/s..: ");
            veloc = Console.ReadLine();

            Console.Write("Entre com o ângulo, em graus....: ");
            ang = Console.ReadLine();
            Console.WriteLine(" ");

            double v = Convert.ToDouble(veloc);
            double a = Convert.ToDouble(ang);

            double rad = (a * pi) / 180;

            double senA = Math.Sin(rad);

            double sen2A = Math.Sin((2*rad));

            double xMax = Math.Pow(v,2) * (sen2A) / g;

            double hMax = Math.Pow((v * senA), 2) / (2 * g);

            Console.WriteLine($"Alcance........: {xMax:N2}m");
            Console.WriteLine($"Altura máxima..: {hMax:N2}m");
           Console.WriteLine(" ");


        }
    }
}
