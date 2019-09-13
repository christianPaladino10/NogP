using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogueira.NogueiraDTO
{
    public class FrmPizzaContext : NotifyPropertyChanged
    {

        public List<PizzaDTO> ListaPizzas { get; set; }
    }
}
