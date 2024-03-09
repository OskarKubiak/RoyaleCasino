using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyaleCasino
{
    public class Deck
    {
        List<Kort> cards = new List<Kort> ();
        enum klør {es= 1, to, tre, fire, fem, seks, syv, otte, ni, ti, bunde, dronning, konge }
        public Deck()
        {
            //Spar
            for (int i = 1; i <= 13; i++)
            {



                if (i <= 10) {
                    cards.Add(new Kort("Spar", i));
                }
                if (i == 11)
                {
                    cards.Add(new Kort("Spar Bunde", i));
                }
                if (i == 12)
                {
                    cards.Add(new Kort("Spar Dronning", i));
                }
                if (i == 13)
                {
                    cards.Add(new Kort("Spar Konge", i));
                }
                
            }
            //Klør
            for (int i = 1; i <= 13; i++)
            {
                cards.Add(new Kort("Klør", i));
            }
            //Hjerter
            for (int i = 1; i <= 13; i++)
            {
                cards.Add(new Kort("Hjerter", i));
            }
            //Ruder
            for (int i = 1; i <= 13; i++)
            {
                cards.Add(new Kort("Ruder", i));
            }
            foreach (Kort s in cards)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(cards.Count);
            Console.ReadKey();
        }
       
    /*
        public override string ToString()
        {
            return $"{cards}";
        }
    */

    }

    //public shuffle()
}
