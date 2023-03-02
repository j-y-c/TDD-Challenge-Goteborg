'use strict';

//to run app.js, use the terminal command
//      >
//      > node app.js
//      >
class Deck {
    constructor() {
        this.cards = [];
        for (let i = 1; i <= 4; i++) {
            let color = "";
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
            this.cards.push(new Card("0", color));
            for (let k = 1; k <= 9; k++) {
                this.cards.push(new Card(k.toString(), color));
                this.cards.push(new Card(k.toString(), color));
            }
            this.cards.push(new Card("SKIP", color));
            this.cards.push(new Card("SKIP", color));
            this.cards.push(new Card("REVERSE", color));
            this.cards.push(new Card("REVERSE", color));
            this.cards.push(new Card("DRAW-TWO", color));
            this.cards.push(new Card("DRAW-TWO", color));
            this.cards.push(new Card("WILD", color));
            this.cards.push(new Card("WILD-DRAW-FOUR", color));
        }
    }
}

class Card {
    constructor(action, color) {
        this.action = action;
        this.color = color;
    }
}

// Example usage of Deck class:
const myDeck = new Deck();
console.log(myDeck.cards);
