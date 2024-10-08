using GrandStationAPI.DTOs;
using GrandStationAPI.Models;

namespace GrandStationAPI.Interfaces;

public interface IAdmin
{
    Task<IEnumerable<Admin>> GetAllAdmin();
    Task<Admin> GetAdminById(int id);
    Task<Admin> CreateAdmin(AdminDto adminDto);
    Task<string> UpdateAdmin(int id, AdminDto adminDto);
    Task<string> DeleteAdmin(int id);
    Task<string> ToggleActivateAdmin(int id);
    Task<string> ToggleDeleteAdmin(int id);
    Task<string> UpdateLastUpdatedProfile(int id);
}