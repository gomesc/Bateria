using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transferencia
{
    public class ModeloBateria
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Vbn { get; set; }
        public string KT { get; set; }
        public string Tb0 { get; set; }
        public string C10 { get; set; }
        public string C20 { get; set; }
        public string C100 { get; set; }
        public string VbFloat { get; set; }
        public string VbEq { get; set; }

    }
    public class ModeloBateriaColecao : List<ModeloBateria>
    {

        public ModeloBateriaColecao ConsultarModelosBateriaPorNome(string p)
        {
            throw new NotImplementedException();
        }
    }
 
}
