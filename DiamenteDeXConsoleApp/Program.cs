namespace DiamenteDeXConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Digite um número ímpar: ");
                int numero = int.Parse(Console.ReadLine()!);
                Console.WriteLine();
                while (numero % 2 == 0)
                {
                    Console.Write("Comando Inválido, Digite Novamente: ");
                    numero = int.Parse(Console.ReadLine()!);
                    Console.WriteLine();
                }

                int espacos = numero / 2;
                int quantosX = 1;
                for (int i = 0; i <= numero; i++)
                {
                    for (int e = 0; e <= espacos; e++ )
                    {
                        Console.Write(" ");
                    }
                    for (int x = 1; x <= quantosX; x++)
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine();
                    if(i < numero / 2)
                    {
                        espacos--;
                        quantosX += 2;
                    } else
                    {
                        espacos++;
                        quantosX -= 2;                    
                    }
                }







                Console.WriteLine("Deseja Continuar (s/n)");
                string continuar = Console.ReadLine()!.ToUpper();
                if (continuar != "S")
                    break;
            }
            
        }
    }
}
