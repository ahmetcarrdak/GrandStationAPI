using GrandStationAPI.DTOs;
using GrandStationAPI.Models;

namespace GrandStationAPI.Interfaces;

public interface ISatellite
{
    Task<IEnumerable<Satellite>> GetAllAsync();
    Task<Satellite> GetByIdAsync(int id);
    Task<Satellite> CreateAsync(Satellite satellite);
    Task<string> UpdateAsync(int id, SatelliteDto satelliteDto);
    Task<string> ToggleActivateAsync(int id);
    Task<string> ToggleDeleteAsync(int id);
    Task<string> UpdateLastUpdatedProfileAsync(int id);
}