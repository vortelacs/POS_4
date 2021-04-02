using entitati;
using System;
using System.Collections;

namespace app1
{
    public abstract class ProduseAbstractMgr
    {

        protected static ArrayList elemente = new ArrayList();
        //protected static int nrElemente = 0;




        public static void Write2Console()
        {
            foreach (ProdusAbstract item in elemente)
            {
                Console.WriteLine(item.Descriere());
            }
        }

        public void Sort()
        {
            elemente.Sort(new ProdusAbstractComparer()); ;
        }

    }


}