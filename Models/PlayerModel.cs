using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoForms.Models
{
    internal class PlayerModel
    {
        public int id;

        public string name;

        public int? money;

        public List<CardModel> hand;

        public List<CardModel>? splitHand;

        public int hand1Value;
        public int hand2Value;

        public PlayerModel()
        {

        }
        public PlayerModel(string name, int? money, List<CardModel> hand)
        {
            this.id = id;
            this.name = name;
            this.money = money;
            this.hand = hand;
        }
    }
}