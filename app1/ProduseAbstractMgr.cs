using entitati;
using System;

namespace app1
{
    public abstract class ProduseAbstractMgr
    {

        protected static ProdusAbstract[] elemente = new ProdusAbstract[100];
        protected static int nrElemente = 0;




        public void Write2Console()
        {
            for (int i = 0; i < nrElemente; i++)
            {

                Console.WriteLine(elemente[i].Descriere());
            }
        }

    }


}