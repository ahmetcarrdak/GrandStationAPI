namespace GrandStationAPI.Models;

public class EventLog
{
    public int Id { get; set; }
    public required string FileName { get; set; }
    public required string Type { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    // Key values
    public Admin? Admin { get; set; }
}