namespace BOL.MESS;

public class MessPlans
{
    private int messID;
    private float monthly;
    private float perPlate;
    public MessPlans(int messID, float monthly, float perPlate)
    {
        this.messID = messID;
        this.monthly = monthly;
        this.perPlate = perPlate;
    }
    // Getter Setter of messID
    public int MessID
    {
        get { return this.messID; }
        set { this.messID = value; }
    }
    // Getter Setter of monthly (Monthly Plan)
    public float MonthlyPlan
    {
        get { return this.monthly; }
        set { this.monthly = value; }
    }
    // Getter Setter of perPlate (Per-plate Plan)
    public float PerPlatePlan
    {
        get { return this.perPlate; }
        set { this.perPlate = value; }
    }
}