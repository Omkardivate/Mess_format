namespace BOL.USER;

public class User
{
    private int userID;
    private string email;
    private string pass;
    private string name;
    private string mobNo;
    public User(int userID, string email, string pass, string name, string mobNo)
    {
        this.userID = userID;
        this.email = email;
        this.pass = pass;
        this.name = name;
        this.mobNo = mobNo;
    }
    // Getter Setter of userID
    public int UserID
    {
        get { return this.userID; }
        set { this.userID = value; }
    }
    // Getter Setter of email (Email-ID)
    public string EmailID
    {
        get { return this.email; }
        set { this.email = value; }
    }
    // Getter Setter of pass (Password)
    public string Password
    {
        get { return this.pass; }
        set { this.pass = value; }
    }
    // Getter Setter of Name
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    // Getter Setter of mobNo (Mobile No.)
    public string MobileNo
    {
        get { return this.mobNo; }
        set { this.mobNo = value; }
    }
}
