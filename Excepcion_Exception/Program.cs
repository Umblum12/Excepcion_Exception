using Excepcion_Forma_T_Exception;

namespace Excepcion_Forma_T_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorUno = 0, valorDos = 0, resultado;

            try
            {
                Console.Write("Numero 1: ");
            valorUno = int.Parse(Console.ReadLine());
            Console.Write("Numero 2: ");
            valorDos = int.Parse(Console.ReadLine());
           
                resultado = valorUno / valorDos;
                Console.WriteLine(resultado);
            } catch(Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("Final");
            Console.WriteLine();
        }
    }
}