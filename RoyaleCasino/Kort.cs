using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyaleCasino
{
    public class Kort
    {
        private string _suit { get; set; }
        private int _value { get; set; }

        public Kort(string suit, int value)
        {
            _suit = suit;
            _value = value;
        }
        public override string ToString()
        {
            return $"{_suit} {_value}";    
            }

    }
}
