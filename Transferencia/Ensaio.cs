using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transferencia
{
    public class Ensaio
    {
        public int IdEnsaio { get; set; }
        public string NomeEnsaio { get; set; }
        public string Descricao { get; set; }
        public string TStart { get; set; }
        public string TStop { get; set; }
        public string TRun { get; set; }
        public string Ib { get; set; }
        public string KVb { get; set; }
        public string Tbref { get; set; }

    }

    public class EnsaioColecao : List<Ensaio>
    {

    }
}
