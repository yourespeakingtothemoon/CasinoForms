using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoForms.Models
{
    internal class CardModel
    {
        public int id;

        public string? suit;

        public int number;

        public int value;

        public CardModel(string suit, int number, int value)
        {
            this.suit = suit;
            this.number = number;
            this.value = value;
        }
        public CardModel(string suit, int number)
        {
            this.suit = suit;
            this.number = number;
        }
        public CardModel()
        {
        }
    }
}
