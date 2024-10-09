using GrandStationAPI.Models;
using GrandStationAPI.DTOs;

namespace GrandStationAPI.Interfaces;

public interface ILogViewAdmin
{
    Task<IEnumerable<LogViewAdmin>> GetLogViewAdminsAsync();
    Task<LogViewAdmin> GetLogViewAdminByIdAsync(int id);
    Task<LogViewAdmin> CreateLogViewAdminAsync(LogViewAdminDto logViewAdminDto);
}