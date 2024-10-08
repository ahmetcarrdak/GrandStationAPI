namespace GrandStationAPI.Models;

public class Satellite
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Type { get; set; }
    public required string Task { get; set; }
    public int LastUpdatedProfileId { get; set; }
    public bool IsActivited { get; set; } = false;
    public bool IsDeleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // Key values
    public Admin? Admin { get; set; }
}