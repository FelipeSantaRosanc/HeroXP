using System;

namespace HeroXP
{
   class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Por favor, digite o nome do herói: ");
            string name = Console.ReadLine();


            Console.WriteLine("Por favor, digite a XP do heroi: ");
            int xP = int.Parse(Console.ReadLine());

            // ferro
            if (xP < 1000)
            { 
                Console.WriteLine($"O Herói de nome {name} está no nível de Ferro");
            }
            //bronze
            else if (xP >= 1001 && xP <= 2000)
            {
                Console.WriteLine($"O Herói de nome {name} está no nível de bronze");
            }
            //prata
            else if (xP >= 2001 && xP <= 6000)
            {
                Console.WriteLine($"O Herói de nome {name} está no nível de prata");
            }
            //ouro
            else if (xP >= 6001 && xP <= 7000)
            {
                Console.WriteLine($"O Herói de nome {name} está no nível de ouro");
            }
            //platina
            else if (xP >= 7001 && xP <= 8000)
            {
                Console.WriteLine($"O Herói de nome {name} está no nível de platina");
            }
            //ascendente
            else if (xP >= 8001 && xP <= 9000)
            {
                Console.WriteLine($"O Herói de nome {name} está no nível de ascendente");
            }
            //imortal
            else if (xP >= 9001 && xP <= 10000)
            {
                Console.WriteLine($"O Herói de nome {name} está no nível de imortal");
            }
            //radiante
            else if (xP >= 10001)
            {
                Console.WriteLine($"O Herói de nome {name} está no nível de radiante");
            }


        }
    }
}