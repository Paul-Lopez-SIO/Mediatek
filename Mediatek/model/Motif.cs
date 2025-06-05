namespace Mediatek.model
{
    public class Motif
    {
        public int Idmotif { get; }
        public string Libelle { get; }

        public Motif(int idmotif, string libelle)
        {
            Idmotif = idmotif;
            Libelle = libelle;
        }

        public override string ToString()
        {
            return Libelle;
        }
    }
}
