using MyGalaxy_Auction_Business.Dtos;
using MyGalaxy_Auction_Core.Models;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Business.Abstraction
{
    public interface IDressService
    {
        Task<ApiResponse> CreateDress(CreateDressDTO model);
        Task<ApiResponse> GetDresses();
        Task<ApiResponse> GetDressById(int dressId);
        Task<ApiResponse> UpdateDressResponse(int dressId, UpdateDressDTO model);
        Task<ApiResponse> DeleteDress(int dressId);
        Task<ApiResponse> ChangeDressStatus(int dressId);
    }
}
