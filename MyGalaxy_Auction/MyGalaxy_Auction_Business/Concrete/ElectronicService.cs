using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

namespace MyGalaxy_Auction_Business.Services
{
    public class ElectronicService : IElectronicService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private ApiResponse _response;

        public ElectronicService(ApplicationDbContext context, ApiResponse response, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _response = response;
        }

        public async Task<ApiResponse> CreateElectronic(CreateElectronicDTO model)
        {
            if (model != null)
            {
                var electronic = _mapper.Map<Electronic>(model);
                if (electronic != null)
                {
                    _context.Add(electronic);
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
            _response.ErrorMessages.Add("Oops! Something went wrong.");
            return _response;
        }

        public async Task<ApiResponse> GetElectronics()
        {
            var electronics = await _context.Electronics.ToListAsync();
            if (electronics != null)
            {
                _response.Result = electronics;
                _response.isSuccess = true;
                return _response;
            }

            _response.isSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> GetElectronicById(int electronicId)
        {
            var electronic = await _context.Electronics.FirstOrDefaultAsync(e => e.ElectronicId == electronicId);
            if (electronic != null)
            {
                _response.Result = electronic;
                _response.isSuccess = true;
                return _response;
            }

            _response.isSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> UpdateElectronicResponse(int electronicId, UpdateElectronicDTO model)
        {
            var electronic = await _context.Electronics.FindAsync(electronicId);
            if (electronic != null)
            {
                _mapper.Map(model, electronic);
                if (await _context.SaveChangesAsync() > 0)
                {
                    _response.isSuccess = true;
                    _response.Result = electronic;
                    return _response;
                }
            }

            _response.isSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> DeleteElectronic(int electronicId)
        {
            var electronic = await _context.Electronics.FindAsync(electronicId);
            if (electronic != null)
            {
                _context.Electronics.Remove(electronic);
                if (await _context.SaveChangesAsync() > 0)
                {
                    _response.isSuccess = true;
                    return _response;
                }
            }

            _response.isSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> ChangeElectronicStatus(int electronicId)
        {
            var electronic = await _context.Electronics.FindAsync(electronicId);
            if (electronic != null)
            {
                electronic.IsActive = !electronic.IsActive;
                if (await _context.SaveChangesAsync() > 0)
                {
                    _response.isSuccess = true;
                    _response.Result = electronic.IsActive;
                    return _response;
                }
            }

            _response.isSuccess = false;
            return _response;
        }
    }
}
