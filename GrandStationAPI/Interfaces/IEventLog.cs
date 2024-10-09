using GrandStationAPI.DTOs;
using GrandStationAPI.Models;

namespace GrandStationAPI.Interfaces;

public interface IEventLog
{
    Task<IEnumerable<EventLog>> GetAllEventLogsAsync();
    Task<EventLog> GetEventLogByIdAsync(int id);
    Task<EventLog> CreateEventLogAsync(EventLogDto eventLogCreateDto);
    Task<string> UpdateEventLogAsync(int id, EventLogDto eventLogUpdateDto);
    Task<string> DeleteEventLogAsync(int id);
}