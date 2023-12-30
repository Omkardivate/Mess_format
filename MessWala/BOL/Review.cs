namespace BOL.MESS;

public class Review
{
    private int userID;
    private int messID;
    private int rating;
    private string review;
    public Review(int userID, int messID, int rating, string review)
    {
        this.userID = userID;
        this.messID = messID;
        this.rating = rating;
        this.review = review;
    }
    // Getter Setter of userID
    public int UserID
    {
        get { return this.userID; }
        set { this.userID = value; }
    }
    // Getter Setter of messID
    public int MessID
    {
        get { return this.messID; }
        set { this.messID = value; }
    }
    // Getter Setter of rating
    public int Rating
    {
        get { return this.rating; }
        set { this.rating = value; }
    }
    // Getter Setter of review
    public string Reviews
    {
        get { return this.review; }
        set { this.review = value; }
    }
}
