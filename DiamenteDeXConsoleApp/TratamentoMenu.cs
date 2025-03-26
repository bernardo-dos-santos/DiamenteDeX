namespace DiamenteDeXConsoleApp
{
    public class TratamentoMenu
    {
        public static string DigitarNumero()
        {
            Console.Write("Digite um número ímpar: ");
            string numerostring = Console.ReadLine()!;
            Console.WriteLine();
            return numerostring;
        }
        public static int TratamentoDeEntrada(string numerostring)
        {
            int numero;
            while (!int.TryParse(numerostring, out numero) || numero % 2 == 0)
            {
                Console.Write("Comando Inválido, ");
                numerostring = DigitarNumero();
                Console.Clear();
            }
            return numero;

        }
        public static bool Continuar()
        {
            Console.WriteLine("Deseja Continuar (s/n)");
            string opcaocontinuar = Console.ReadLine()!.ToUpper();
            if (opcaocontinuar != "S")
                return false;
            return true;
        }
    }
}
