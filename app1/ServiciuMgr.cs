using entitati;
using System;

namespace app1
{
    class ServiciuMgr : ProduseAbstractMgr
    {



        public void ReadServiciu()
        {
            Console.WriteLine("Dati id-ul:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati numele:");
            string nume = Console.ReadLine();
            Console.WriteLine("Date codul intern:");
            string cod = Console.ReadLine();

            if (CompareServ(new Serviciu(id, nume, cod)))
            {
                elemente.Add(new Serviciu(id, nume, cod));
                //nrElemente++;
                Console.WriteLine("Serviciul a fost adugat!");
            }
            else
            {
                Console.WriteLine("Serviciul dat deja exista!");

            }
        }


        bool CompareServ(Serviciu obj)
        {
            bool ok = true;
            for (int i = 0; i < elemente.Count; i++)
            {

                if (elemente[i] is Serviciu)
                {
                    if (obj.Equal((Serviciu)elemente[i])) return false;
                }
            }

            return ok;
        }

        public void WriteServicii()
        {

            Console.WriteLine("\n\nServiciile sunt: ");

                foreach (ProdusAbstract item in elemente)
                {
                    if(item is Serviciu)item.Descriere();
                }

        }
    }
}
