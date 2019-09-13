using Nogueira.NogueiraBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogueira.NogueiraDTO
{
    public class PizzaDTO : NotifyPropertyChanged
    {
        private int id_Pizza;
        public int Id_Pizza { get => id_Pizza; set { id_Pizza = value; RaisePropertyChanged(); } }
        public string Nome_Sabor { get => nome_Sabor; set { nome_Sabor = value; RaisePropertyChanged(); } }
        public double Preco { get => preco; set { preco = value; RaisePropertyChanged(); } }

        private string nome_Sabor;
        private double preco;
    }
}
