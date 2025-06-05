namespace Mediatek.model
{
    public class Absence
    {
        public int IdPersonnel { get; }

        public DateTime DateDebut { get; set; }

        public DateTime DateFin { get; set; }

        public int IdMotif { get; set; }
        public string Motif { get; set; }

        /// <summary>
        /// Constructeur de la classe Absence.
        /// </summary>
        /// <param name="idPersonnel">Identifiant du personnel</param>
        /// <param name="dateDebut">Date de début</param>
        /// <param name="dateFin">Date de fin</param>
        /// <param name="idMotif">Identifiant du motif</param>
        /// /// <param name="Motif">Identifiant du motif</param>
        public Absence(int idPersonnel, DateTime dateDebut, DateTime dateFin, int idMotif, string motif)
        {
            IdPersonnel = idPersonnel;
            DateDebut = dateDebut;
            DateFin = dateFin;
            IdMotif = idMotif;
            Motif = motif;
        }
    }
}
