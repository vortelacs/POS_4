using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class ProdusAbstractComparer : IComparer
    {

        // Calls CaseInsensitiveComparer.Compare with the parameters reversed.
        int IComparer.Compare(Object x, Object y)
        {
            ProdusAbstract a  = (ProdusAbstract) x;
            ProdusAbstract b  = (ProdusAbstract) y;

            if (a.Id > b.Id) return 1;
            else return 0;
        }
    }
}
