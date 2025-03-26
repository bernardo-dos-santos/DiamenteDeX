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
                string numerostring = TratamentoMenu.DigitarNumero();
                int numero = TratamentoMenu.TratamentoDeEntrada(numerostring);
                DiamanteDeX.ExibirDesenho(numero);
                continuar = TratamentoMenu.Continuar();

            }
        }
        
    }
}
