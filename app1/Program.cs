using System;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("\nIntroduceti numarul de elemente : ");
            int nrElemente = int.Parse(Console.ReadLine());

            ProduseMgr mgrProduse = new ProduseMgr();
            ServiciuMgr mgrServicii = new ServiciuMgr();

            while (true)
            {
                Console.WriteLine("\nPuteti adauga : ");
                Console.WriteLine("1. Adauga produs ");
                Console.WriteLine("2. Adauga Serviciu ");
                Console.WriteLine("9. Iesiti din Program ");
                Console.WriteLine("\n\nAlegeti : ");
                int alegere = int.Parse(Console.ReadLine());


                    if (alegere == 1) mgrProduse.ReadProdus();

                    else if (alegere == 2) mgrServicii.ReadServiciu();

                    else if (alegere == 9) break;

                    else Console.WriteLine("Alegere invalida");



            }
            mgrProduse.Write2Console();



            Console.ReadKey();
        }

    }
}
