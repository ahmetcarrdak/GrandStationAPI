using GrandStationAPI.DTOs;
using GrandStationAPI.Models;

namespace GrandStationAPI.Interfaces;

public interface IRocket
{
    Task<IEnumerable<Rocket>> GetALllAsync();
    Task<Rocket> GetByIdAsync(int id);
    Task<Rocket> CreateAsync(RocketDto rocketDto);
    Task<string> UpdateAsync(int id, RocketDto rocketDto);
    Task<string> ToggleActivateAsync(int id);
    Task<string> ToggleDeleteAsync(int id);
    Task<string> UpdateLastUpdatedProfileAsync(int id);
}