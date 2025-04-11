using MyGalaxy_Auction_Business.Dtos;
using MyGalaxy_Auction_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Business.Abstraction
{
    public interface IElectronicService
    {
        Task<ApiResponse> CreateElectronic(CreateElectronicDTO model);
        Task<ApiResponse> GetElectronics();
        Task<ApiResponse> UpdateElectronicResponse(int electronicId, UpdateElectronicDTO model);
        Task<ApiResponse> DeleteElectronic(int electronicId);
        Task<ApiResponse> GetElectronicById(int electronicId);
        Task<ApiResponse> ChangeElectronicStatus(int electronicId);
    }
}
