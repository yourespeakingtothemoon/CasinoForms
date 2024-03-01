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



    }
}