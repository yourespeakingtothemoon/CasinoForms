using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoForms.Models
{
    public class PlayerModel
    {
        public int id;

        public string? name;

        public float? money;

        public List<CardModel> hand;

        public List<CardModel>? splitHand;

        public int hand1Value;
        public int hand2Value;

        public PlayerModel()
        {
            hand = new List<CardModel>();
        }
        public PlayerModel(string name, float? money, List<CardModel> hand)
        {
           
            this.name = name;
            this.money = money;
            this.hand = hand;
        }

        public PlayerModel(int id, string name, float? money, List<CardModel> hand)
        {
            this.id = id;
            this.name = name;
            this.money = money;
            this.hand = hand;
        }
    }
}