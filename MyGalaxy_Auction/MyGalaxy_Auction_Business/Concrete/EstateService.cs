using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyGalaxy_Auction_Business.Abstraction;
using MyGalaxy_Auction_Business.Dtos;
using MyGalaxy_Auction_Core.Models;
using MyGalaxy_Auction_Data_Access.Context;
using MyGalaxy_Auction_Data_Access.Domain;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Business.Concrete
{
    public class EstateService : IEstateService
    {
        private readonly ApplicationDbContext _context;
        private readonly ApiResponse _response;
        private readonly IMapper _mapper;

        public EstateService(ApplicationDbContext context, ApiResponse response, IMapper mapper)
        {
            _context = context;
            _response = response;
            _mapper = mapper;
        }

        public async Task<ApiResponse> CreateEstate(CreateEstateDTO model)
        {
            var estate = _mapper.Map<Estate>(model);
            await _context.Estates.AddAsync(estate);
            if (await _context.SaveChangesAsync() > 0)
            {
                _response.isSuccess = true;
                _response.Result = model;
                _response.StatusCode = System.Net.HttpStatusCode.Created;
                return _response;
            }

            _response.isSuccess = false;
            _response.ErrorMessages.Add("An error occurred while creating the estate.");
            return _response;
        }

        public async Task<ApiResponse> GetEstates()
        {
            var estates = await _context.Estates.Include(e => e.Seller).ToListAsync();
            _response.isSuccess = true;
            _response.Result = estates;
            return _response;
        }

        public async Task<ApiResponse> GetEstateById(int estateId)
        {
            var estate = await _context.Estates
                .Include(e => e.Seller)
                .Include(e => e.Bids)
                .FirstOrDefaultAsync(e => e.EstateId == estateId);

            if (estate == null)
            {
                _response.isSuccess = false;
                return _response;
            }

            _response.isSuccess = true;
            _response.Result = estate;
            return _response;
        }

        public async Task<ApiResponse> UpdateEstateResponse(int estateId, UpdateEstateDTO model)
        {
            var estate = await _context.Estates.FindAsync(estateId);
            if (estate == null)
            {
                _response.isSuccess = false;
                return _response;
            }

            _mapper.Map(model, estate);
            if (await _context.SaveChangesAsync() > 0)
            {
                _response.isSuccess = true;
                _response.Result = estate;
                return _response;
            }

            _response.isSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> DeleteEstate(int estateId)
        {
            var estate = await _context.Estates.FindAsync(estateId);
            if (estate == null)
            {
                _response.isSuccess = false;
                return _response;
            }

            _context.Estates.Remove(estate);
            if (await _context.SaveChangesAsync() > 0)
            {
                _response.isSuccess = true;
                return _response;
            }

            _response.isSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> ChangeEstateStatus(int estateId)
        {
            var estate = await _context.Estates.FindAsync(estateId);
            if (estate == null)
            {
                _response.isSuccess = false;
                return _response;
            }

            estate.IsActive = false;
            await _context.SaveChangesAsync();
            _response.isSuccess = true;
            return _response;
        }
    }
}
