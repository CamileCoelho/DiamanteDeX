namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero, metade;

            do
            {
                Console.Clear();

                Console.WriteLine("Diamantes De X ");
                Console.WriteLine();

                Console.Write("Digite um valor ímpar para a altura do diamante: "); 
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (numero % 2 == 0)
                {
                    Console.WriteLine("Valor inválido. Tente novamente...");
                    Console.ReadLine();
                }
            } while (numero % 2 == 0);

            metade = (numero + 1) / 2;

            // Triângulo normal
            for (int i = 1; i <= metade; i++)
            {
                for (int j = 1; j <= metade - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }

            // Triângulo invertido
            for (int i = metade - 1; i >= 1; i--)
            {
                for (int j = 1; j <= metade - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }

        }
    }
}