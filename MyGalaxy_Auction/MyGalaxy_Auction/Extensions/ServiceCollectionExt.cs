using MyGalaxy_Auction.Hubs.ConnectionManagement;
using MyGalaxy_Auction_Business.Abstraction;
using MyGalaxy_Auction_Business.Concrete;
using MyGalaxy_Auction_Business.Services;
using MyGalaxy_Auction_Core.MailHelper;
using MyGalaxy_Auction_Core.Models;

namespace MyGalaxy_Auction.Extensions
{
    public static class ServiceCollectionExt
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services,IConfiguration configuration)
        {
            #region services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IVehicleService, VehicleService>();
            services.AddScoped<IBidService, BidService>();
            services.AddScoped<IPaymentHistoryService, PaymentHistoryService>();
            services.AddScoped<IConnectionManager, ConnectionManager>();
            services.AddScoped<IMailService, MailService>();
            services.AddScoped<IElectronicService,ElectronicService>();
            services.AddScoped<IDressService, DressService>();
            services.AddScoped<IEstateService, EstateService>();
            services.AddScoped<IMusicalInstrumentService, MusicalInstrumentService>();

            services.AddScoped(typeof(ApiResponse));
            #endregion
            return services;
        }

    }
}
