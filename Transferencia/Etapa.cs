using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transferencia
{
    public class Etapa
    {
        public int IdEtapa { get; set; }
        public string Tipo { get; set; }
        public string Vb { get; set; }
        public string Qb { get; set; }
        public string kVb { get; set; }
        public string NextQ { get; set; }
        public string NextV { get; set; }
        public string NextT { get; set; }
        public string NextI { get; set; }
    }

    public class EtapaColecao : List<Etapa>
    {

    }
}
