using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Data
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            for (int i = 1; i <= 4; i++)
            {
                var colour = "";
                switch (i)
                {
                    case 1:
                        colour = "RED";
                        break;
                    case 2:
                        colour = "YELLOW";
                        break;
                    case 3:
                        colour = "GREEN";
                        break;
                    case 4:
                        colour = "BLUE";
                        break;
                }
                Cards.Add(new Card() { Colour = colour, Action = "0" });
                for (int k = 1; k <= 9; k++)
                {
                    Cards.Add(new Card() { Colour = colour, Action = k.ToString() });
                    Cards.Add(new Card() { Colour = colour, Action = k.ToString() });
                }
                Cards.Add(new Card() { Colour = colour, Action = "SKIP" });
                Cards.Add(new Card() { Colour = colour, Action = "SKIP" });
                Cards.Add(new Card() { Colour = colour, Action = "REVERSE" });
                Cards.Add(new Card() { Colour = colour, Action = "REVERSE" });
                Cards.Add(new Card() { Colour = colour, Action = "DRAW-TWO" });
                Cards.Add(new Card() { Colour = colour, Action = "DRAW-TWO" });
                Cards.Add(new Card() { Colour = colour, Action = "WILD" });
                Cards.Add(new Card() { Colour = colour, Action = "WILD-DRAW-FOUR" });
            }
        } 
        public List<Card> Cards { get; set; }
    }
    public class Card
    {
        public string Colour { get; set; } = "";
        public string Action { get; set; } = "";
    }
}
