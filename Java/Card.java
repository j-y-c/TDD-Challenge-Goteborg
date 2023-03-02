package Java;

public class Card {
    private String color;
    private String action;
    
    public Card(String action, String color) {
        this.action = action;
        this.color = color;
    }
    
    public String getColor() {
        return color;
    }
    
    public String getAction() {
        return action;
    }
}