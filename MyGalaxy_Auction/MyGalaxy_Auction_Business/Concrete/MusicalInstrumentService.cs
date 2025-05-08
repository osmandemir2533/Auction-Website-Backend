using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyGalaxy_Auction_Business.Abstraction;
using MyGalaxy_Auction_Business.Dtos;
using MyGalaxy_Auction_Core.Models;
using MyGalaxy_Auction_Data_Access.Context;
using MyGalaxy_Auction_Data_Access.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Business.Concrete
{
    public class MusicalInstrumentService : IMusicalInstrumentService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ApiResponse _response;

        public MusicalInstrumentService(ApplicationDbContext context, ApiResponse response, IMapper mapper)
        {
            _context = context;
            _response = response;
            _mapper = mapper;
        }

        public async Task<ApiResponse> CreateInstrument(CreateMusicalInstrumentDTO model)
        {
            if (model != null)
            {
                var objDTO = _mapper.Map<MusicalInstrument>(model);
                objDTO.IsActive = true;

                await _context.MusicalInstruments.AddAsync(objDTO);
                if (await _context.SaveChangesAsync() > 0)
                {
                    _response.isSuccess = true;
                    _response.Result = model;
                    _response.StatusCode = System.Net.HttpStatusCode.Created;
                    return _response;
                }
            }

            _response.isSuccess = false;
            _response.ErrorMessages.Add("Bir hata oluştu.");
            return _response;
        }

        public async Task<ApiResponse> GetInstruments()
        {
            var instruments = await _context.MusicalInstruments.Include(x => x.Seller).ToListAsync();
            if (instruments != null)
            {
                _response.isSuccess = true;
                _response.Result = instruments;
                return _response;
            }

            _response.isSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> GetInstrumentById(int instrumentId)
        {
            var result = await _context.MusicalInstruments.Include(x => x.Seller).
                            FirstOrDefaultAsync(x => x.MusicalInstrumentId == instrumentId);

            if (result != null)
            {
                _response.Result = result;
                _response.isSuccess = true;
                return _response;
            }

            _response.isSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> UpdateInstrumentResponse(int instrumentId, UpdateMusicalInstrumentDTO model)
        {
            var result = await _context.MusicalInstruments.FindAsync(instrumentId);
            if (result != null)
            {
                _mapper.Map(model, result);

                if (await _context.SaveChangesAsync() > 0)
                {
                    _response.isSuccess = true;
                    _response.Result = result;
                    return _response;
                }
            }

            _response.isSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> DeleteInstrument(int instrumentId)
        {
            var result = await _context.MusicalInstruments.FindAsync(instrumentId);
            if (result != null)
            {
                _context.MusicalInstruments.Remove(result);
                if (await _context.SaveChangesAsync() > 0)
                {
                    _response.isSuccess = true;
                    return _response;
                }
            }

            _response.isSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> ChangeInstrumentStatus(int instrumentId)
        {
            var result = await _context.MusicalInstruments.FindAsync(instrumentId);
            if (result != null)
            {
                result.IsActive = !result.IsActive;
                await _context.SaveChangesAsync();
                _response.isSuccess = true;
                return _response;
            }

            _response.isSuccess = false;
            return _response;
        }
    }
}
