using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
