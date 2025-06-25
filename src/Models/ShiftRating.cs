public class ShiftRating
{
    public int ShiftId { get; set; }
    public Shift Shift { get; set; }

    public int FacilityId { get; set; }
    public Facility Facility { get; set; }

    public int WorkerId { get; set; }
    public Worker Worker { get; set; }

    public int Score { get; set; }
}
