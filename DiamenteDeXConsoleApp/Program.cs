using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiamenteDeXConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                

            }



        }
        static string DigitarNumero()
        {
                Console.Write("Digite um número ímpar: ");
                string numerostring = Console.ReadLine()!;
                Console.WriteLine();
                return numerostring;
        }
        static int TratamentoDeEntrada(string numerostring)
        {
            int numero;
            while(!int.TryParse(numerostring, out numero) || numero % 2 == 0 )
            {
            Console.Write("Comando Inválido, ");
            numerostring = DigitarNumero();
            }
            return numero;

        }
        static void ExibirDesenho(int numero)
        {
            int espacos = numero / 2;
            int quantosX = 1;
            for (int i = 0; i <= numero; i++)
            {
                for (int e = 0; e <= espacos; e++)
                {
                    Console.Write(" ");
                }
                for (int x = 1; x <= quantosX; x++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
                if (i < numero / 2)
                {
                    espacos--;
                    quantosX += 2;
                }
                else
                {
                    espacos++;
                    quantosX -= 2;
                }
            }
        }

        static bool Continuar()
        {
            Console.WriteLine("Deseja Continuar (s/n)");
            string opcaocontinuar = Console.ReadLine()!.ToUpper();
            if (opcaocontinuar != "S")
                return false;
            return true;
        }
    }
}
