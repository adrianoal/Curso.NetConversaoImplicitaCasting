using System;
using System.Globalization;

namespace ConversaoImplicitaCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversao implicita de tipos:

            float x = 4.5F;
            double y = x;

            Console.WriteLine("Resolução de Conversao implicita: Ex: De float p/ double");
            Console.WriteLine(y);
            Console.WriteLine();


            // Conversao explícita entre tipos compatíveis: Chama-sa Casting!
            // Neste caso e necessario definir o CASTING
            // Ex: De double P/ float


            double a;
            float b;
            a = 5.1;
            b = (float)a; // Isto significar dizar p/ o compilador q pode jogar o conteudo de a q contem 8 bytes dentro de b q contem 4 bytes, se tiver perda de informacao, nao tem problema.

            Console.WriteLine("Casting --> Ex: De double P/ float:");
            Console.WriteLine(b);
            Console.WriteLine();

            // Neste caso e necessario definir o CASTING
            // Ex: De double P/ int
            // Neste caso teve uma perda de informacao, pq os valores apos a virgula sao truncados

            double c;
            int d;
            c = 5.1;
            d = (int)c;

            Console.WriteLine("Casting --> Ex: De double P/ int:");
            Console.WriteLine(d);
            Console.WriteLine();

            // Neste caso e necessario definir o CASTING
            // Ex: De double P/ int

            int e = 5;
            int f = 2;
            double resultado = (double)e / f;

            Console.WriteLine("Casting --> Ex: De int P/ double:");
            Console.WriteLine(resultado);



        }
    }
}
