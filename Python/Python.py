class Deck:
    def __init__(self):
        self.cards = []
        for i in range(1, 5):
            color = ""
            if i == 1:
                color = "RED"
            elif i == 2:
                color = "YELLOW"
            elif i == 3:
                color = "GREEN"
            elif i == 4:
                color = "BLUE"
            self.cards.append(Card("0", color))
            for k in range(1, 10):
                self.cards.append(Card(str(k), color))
                self.cards.append(Card(str(k), color))
            self.cards.append(Card("SKIP", color))
            self.cards.append(Card("SKIP", color))
            self.cards.append(Card("REVERSE", color))
            self.cards.append(Card("REVERSE", color))
            self.cards.append(Card("DRAW-TWO", color))
            self.cards.append(Card("DRAW-TWO", color))
            self.cards.append(Card("WILD", color))
            self.cards.append(Card("WILD-DRAW-FOUR", color))

class Card:
    def __init__(self, action, color):
        self.action = action
        self.color = color

# Example usage of Deck class:
my_deck = Deck()
print([card.action + "-" + card.color for card in my_deck.cards])
