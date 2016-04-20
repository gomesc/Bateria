using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transferencia
{
    public class Bateria
    {
        public int Id { get; set; }
        public int IdModelo { get; set; }
        public string NomeBateria { get; set; }
        public string Serie { get; set; }
        public string Fabricacao { get; set; }
        public string Lote { get; set; }
    }

    public class BateriaColecao : List<Bateria>
    {

    }
}
