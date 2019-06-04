using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogueira.NogueiraDTO
{
    public class VendaDTO
    {
        public string VendaId { get; set; }
        public string ClienteId { get; set; }
        public string ValorTotal { get; set; }
        public DateTime DtVenda { get; set; }

    }
}
