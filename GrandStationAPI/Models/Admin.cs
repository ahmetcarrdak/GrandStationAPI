using System.ComponentModel.DataAnnotations;

namespace GrandStationAPI.Models;

public class Admin
{
    public int Id { get; set; }
    public required string PhotoSource { get; set; }
    public required string Name { get; set; }
    [EmailAddress] public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public required string Role { get; set; }
    public bool IsActivated { get; set; } = false;
    public bool IsDeleted { get; set; } = false;
    public int LastUpdatedProfileId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}