using System;

namespace pooControledeAnimais
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string tipo;

            for (int x = 0; x < 5; x++)
            {
                Console.Write("Informe o nome do" + (x + 1) + "º" + "animal: ");

                nome = Console.ReadLine();

                Console.Write("Informe o tipo do" + (x + 1) + "º" + "animal (Cachorro, Gato ou Peixe): ");

                tipo = Console.ReadLine();

                new Animal(tipo, nome);
            }

            Console.WriteLine("Total de animais");

            Console.WriteLine("Cachorros: " + Animal.cachorro + " \nGatos: " + Animal.gato + " \nPeixes " + Animal.peixe);

            Console.ReadKey();
        }
    }
}
