using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome.....: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantas horas você dormiu na noite passada?!");
            int horasDormidas = int.Parse(Console.ReadLine());

            Console.WriteLine("Olá " + nome);

            if (horasDormidas > 8)
            {
                Console.WriteLine("Então você dormiu bem!!");
            }
            else
            {
                Console.WriteLine("Você precisa descansar mais!!!");
            }

            Console.ReadKey();
        }
    }
}
