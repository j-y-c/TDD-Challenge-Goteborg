package Java;

import java.util.List;

class App{
    public static void main(String[] args){
        // Example usage Deck class:
        Deck myDeck = new Deck();
        List<Card> cards = myDeck.getCards();
        for (Card card : cards) {
            System.out.println(card.getAction() + "-" + card.getColor());
        }
    }
}
