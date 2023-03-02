package Java;

import java.util.ArrayList;
import java.util.List;

public class Deck {
    private List<Card> cards;
    
    public Deck() {
        cards = new ArrayList<Card>();
        for (int i = 1; i <= 4; i++) {
            String color = "";
            switch (i) {
                case 1:
                    color = "RED";
                    break;
                case 2:
                    color = "YELLOW";
                    break;
                case 3:
                    color = "GREEN";
                    break;
                case 4:
                    color = "BLUE";
                    break;
            }
            cards.add(new Card("0", color));
            for (int k = 1; k <= 9; k++) {
                cards.add(new Card(Integer.toString(k), color));
                cards.add(new Card(Integer.toString(k), color));
            }
            cards.add(new Card("SKIP", color));
            cards.add(new Card("SKIP", color));
            cards.add(new Card("REVERSE", color));
            cards.add(new Card("REVERSE", color));
            cards.add(new Card("DRAW-TWO", color));
            cards.add(new Card("DRAW-TWO", color));
            cards.add(new Card("WILD", color));
            cards.add(new Card("WILD-DRAW-FOUR", color));
        }
    }
    
    public List<Card> getCards() {
        return cards;
    }
}
