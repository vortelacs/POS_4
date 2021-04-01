using entitati;
using System;

namespace app1
{
    public class ProduseMgr : ProduseAbstractMgr
    {



        public void ReadProdus()
        {

            Console.WriteLine("Dati id-ul:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati numele:");
            string nume = Console.ReadLine();
            Console.WriteLine("Date codul intern:");
            string cod = Console.ReadLine();
            Console.WriteLine("Dati codul producatorul:");
            string producator = Console.ReadLine();
            Produs next = new Produs(id, nume, cod, producator);

            if (CompareProd(new Produs(id, nume, cod, producator)))
            {
                elemente[nrElemente] = (new Produs(id, nume, cod, producator));
                nrElemente++;
                Console.WriteLine("Produsul a fost adugat!");
            }
            else
            {
                Console.WriteLine("Produsul dat deja exista!");
            }
        }





        bool CompareProd(Produs obj)
        {
            bool ok = true;
            for (int i = 0; i < nrElemente; i++)
            {
                if (elemente[i] is Produs)
                {
                    if (obj.Equal((Produs)elemente[i])) return false;

                }
            }

            return ok;
        }


        public void WriteProduse()
        {

            Console.WriteLine("\n\nProdusele sunt: ");
            for (int i = 0; i < nrElemente; i++)
            {
                if (elemente[i] is Produs)
                {
                    Console.WriteLine(elemente[i].Descriere());
                }
            }

        }



    }
}
