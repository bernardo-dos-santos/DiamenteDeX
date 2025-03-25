namespace DiamenteDeXConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Digite um número ímpar");
                int numero = int.Parse(Console.ReadLine()!);

                while (numero % 2 == 0)
                {
                    Console.WriteLine("Comando Inválido, Digite Novamente");
                    numero = int.Parse(Console.ReadLine()!);
                }

                Console.WriteLine("Deseja Continuar (s/n)");
                string continuar = Console.ReadLine()!.ToUpper();
                if (continuar != "S")
                    break;
            }
            
        }
    }
}
