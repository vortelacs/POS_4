using System;

namespace entitati
{
    public abstract class ProdusAbstract
    {
        long id;
        String nume;
        String codIntern;

        public ProdusAbstract(long id, string nume, string codIntern)
        {
            this.id = id;
            this.nume = nume;
            this.codIntern = codIntern;
        }

        public long Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public string CodIntern { get => codIntern; set => codIntern = value; }


        public abstract string Descriere();

    }
}
