using MyGalaxy_Auction_Business.Dtos;
using MyGalaxy_Auction_Core.Models;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Business.Abstraction
{
    public interface IMusicalInstrumentService
    {
        Task<ApiResponse> CreateInstrument(CreateMusicalInstrumentDTO model);
        Task<ApiResponse> GetInstruments();
        Task<ApiResponse> GetInstrumentById(int instrumentId);
        Task<ApiResponse> UpdateInstrumentResponse(int instrumentId, UpdateMusicalInstrumentDTO model);
        Task<ApiResponse> DeleteInstrument(int instrumentId);
        Task<ApiResponse> ChangeInstrumentStatus(int instrumentId);
    }
}
