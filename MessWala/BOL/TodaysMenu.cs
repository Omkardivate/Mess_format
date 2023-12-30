namespace BOL.MESS.MENU;

public class TodaysMenu
{
    private int messID;
    private string menuName;
    private float price;
    private int qty;
    public TodaysMenu(int messID, string menuName, float price, int qty)
    {
        this.messID = messID;
        this.menuName = menuName;
        this.price = price;
        this.qty = qty;
    }
    // Getter Setter of messID
    public int MessID
    {
        get { return this.messID; }
        set { this.messID = value; }
    }
    // Getter Setter of menuName
    public string MenuName
    {
        get { return this.menuName; }
        set { this.menuName = value; }
    }
    // Getter Setter of price
    public float Price
    {
        get { return this.price; }
        set { this.price = value; }
    }
    // Getter Setter of qty (Quantity / Availibility)
    public int Quantity
    {
        get { return this.qty; }
        set { this.qty = value; }
    }
}