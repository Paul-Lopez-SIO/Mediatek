namespace Mediatek.model
{
    public class Service
    {
        public int Idservice { get; }
        public string Nom { get; }

        public Service(int idservice, string nom)
        {
            Idservice = idservice;
            Nom = nom;
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
