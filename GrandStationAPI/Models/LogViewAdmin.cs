namespace GrandStationAPI.Models;

public class LogViewAdmin
{
    public int Id { get; set; }
    public int LogId { get; set; }
    public int AdminId { get; set; }

    // Key Values 
    public Admin? Admin { get; set; }
    public EventLog? EventLog { get; set; }
}