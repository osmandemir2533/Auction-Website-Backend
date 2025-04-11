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
    public class DressService : IDressService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private ApiResponse _response;

        public DressService(ApplicationDbContext context, ApiResponse response, IMapper mapper)
        {
            _context = context;
            _response = response;
            _mapper = mapper;
        }

        public async Task<ApiResponse> CreateDress(CreateDressDTO model)
        {
            if (model != null)
            {
                var dressEntity = _mapper.Map<Dress>(model);
                if (dressEntity != null)
                {
                    await _context.Dresses.AddAsync(dressEntity);
                    if (await _context.SaveChangesAsync() > 0)
                    {
                        _response.isSuccess = true;
                        _response.Result = model;
                        _response.StatusCode = System.Net.HttpStatusCode.Created;
                        return _response;
                    }
                }
            }
            _response.isSuccess = false;
            _response.ErrorMessages.Add("Oops! Something went wrong");
            return _response;
        }

        public async Task<ApiResponse> GetDresses()
        {
            var dresses = await _context.Dresses.Include(x => x.Seller).ToListAsync();
            if (dresses != null)
            {
                _response.isSuccess = true;
                _response.Result = dresses;
                return _response;
            }
            _response.isSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> GetDressById(int dressId)
        {
            var dress = await _context.Dresses.Include(x => x.Seller).FirstOrDefaultAsync(x => x.DressId == dressId);
            if (dress != null)
            {
                _response.isSuccess = true;
                _response.Result = dress;
                return _response;
            }
            _response.isSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> UpdateDressResponse(int dressId, UpdateDressDTO model)
        {
            var dress = await _context.Dresses.FindAsync(dressId);
            if (dress != null)
            {
                _mapper.Map(model, dress);
                if (await _context.SaveChangesAsync() > 0)
                {
                    _response.isSuccess = true;
                    _response.Result = dress;
                    return _response;
                }
            }
            _response.isSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> DeleteDress(int dressId)
        {
            var dress = await _context.Dresses.FindAsync(dressId);
            if (dress != null)
            {
                _context.Dresses.Remove(dress);
                if (await _context.SaveChangesAsync() > 0)
                {
                    _response.isSuccess = true;
                    return _response;
                }
            }
            _response.isSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> ChangeDressStatus(int dressId)
        {
            var dress = await _context.Dresses.FindAsync(dressId);
            if (dress != null)
            {
                dress.IsActive = !dress.IsActive;
                if (await _context.SaveChangesAsync() > 0)
                {
                    _response.isSuccess = true;
                    return _response;
                }
            }
            _response.isSuccess = false;
            return _response;
        }
    }
}
