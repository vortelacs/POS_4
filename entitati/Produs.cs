using System;



namespace entitati
{
    public class Produs : ProdusAbstract
    {

        String producator;

        public Produs(long id, string nume, string codIntern, string producator) : base(id, nume, codIntern)
        {
            this.producator = producator;
        }


        public string Producator { get => producator; set => producator = value; }



        public override string Descriere()
        {
            return "id = " + Id + "\nnume = " + Nume + "\ncod intern = " + CodIntern + "\nproducator = " + Producator + "\n";
        }



        public bool Equal(Produs p)
        {
            if (p == null)
                return false;

            return (this.Id == p.Id) && (this.Nume == p.Nume) && (this.CodIntern == p.CodIntern) && (this.Producator == p.Producator);
        }


    }



}
