using MyGalaxy_Auction_Business.Dtos;
using MyGalaxy_Auction_Core.Models;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Business.Abstraction
{
    public interface IEstateService
    {
        Task<ApiResponse> CreateEstate(CreateEstateDTO model);
        Task<ApiResponse> GetEstates();
        Task<ApiResponse> GetEstateById(int estateId);
        Task<ApiResponse> UpdateEstateResponse(int estateId, UpdateEstateDTO model);
        Task<ApiResponse> DeleteEstate(int estateId);
        Task<ApiResponse> ChangeEstateStatus(int estateId);
    }
}
