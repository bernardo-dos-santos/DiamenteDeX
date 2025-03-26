namespace DiamenteDeXConsoleApp
{
    public class DiamanteDeX
    {
        public static void ExibirDesenho(int numero)
        {
            int espacos = numero / 2;
            int quantosX = 1;
            for (int i = 0; i <= numero; i++)
            {
                Console.Write("         ");
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
    }
}
