using System;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Dati numarul de elemente : ");
            //int nrElemente = int.Parse(Console.ReadLine());

            ProduseMgr mgrProduse = new ProduseMgr();
            ServiciuMgr mgrServicii = new ServiciuMgr();
            int alegere;

            while (true)
            {
                Console.WriteLine("\nPuteti adauga : ");
                Console.WriteLine("1. Adauga produs ");
                Console.WriteLine("2. Adauga Serviciu ");
                Console.WriteLine("3. Vizualizati elementele ");
                Console.WriteLine("4. Sortati elementele ");
                Console.WriteLine("9. Iesiti din Program ");
                Console.Write("\n\nAlegeti : ");
                

                try
                {
                    alegere = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Alegere invalida");
                    continue;
                }


                if (alegere == 1) mgrProduse.ReadProdus();

                    else if (alegere == 2) mgrServicii.ReadServiciu();

                    else if (alegere == 3) ProduseAbstractMgr.Write2Console();

                    else if (alegere == 4) mgrServicii.Sort();

                    else if (alegere == 9) break;

                    else Console.WriteLine("Alegere invalida");



            }
            ProduseAbstractMgr.Write2Console();



            Console.ReadKey();
        }

    }
}
