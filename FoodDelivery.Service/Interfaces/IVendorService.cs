﻿using FoodDelivery.DAL.Entity;
using FoodDelivery.Models.ViewModel.DTOs;

namespace FoodDelivery.Service.Interfaces
{
    public interface IVendorService
    {
        Task<IEnumerable<Vendor>> GetListAsync();
        Task<Vendor> GetByIdAsync(int id);
        Task<bool> CreateAsync(VendorDto model);
        Task<bool> UpdateAsync(Vendor model);
        Task<bool> DeleteAsync(int id);
        //Task<double> GetСustomerRatingAsync(int id);
        //Task<IEnumerable<Vendor>> SortingByDeliveryTimeAsync();
        //Task<IEnumerable<Vendor>> SortingByRatingAsync();
    }
}
