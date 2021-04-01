namespace entitati
{
    public class Serviciu : ProdusAbstract
    {
        public Serviciu(long id, string nume, string codIntern) : base(id, nume, codIntern)
        {

        }

        public bool Equal(Serviciu p)
        {
            if (p == null)
                return false;

            return this.Id == p.Id && this.Nume == p.Nume && this.CodIntern == p.CodIntern;
        }

        public override string Descriere()
        {
            return "id = " + Id + "\nnume = " + Nume + "\ncod intern = " + CodIntern + "\n";
        }

    }
}
