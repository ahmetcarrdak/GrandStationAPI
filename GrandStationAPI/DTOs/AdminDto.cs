namespace GrandStationAPI.DTOs;

public class AdminDto
{
    public required string PhotoSource { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public required string Role { get; set; }
    public required bool IsActivated { get; set; }
    public required bool IsDeleted { get; set; }
    public int LastUpdatedProfile { get; set; }
}