﻿using FoodDelivery.DAL.Entity;
using FoodDelivery.DAL;
using FoodDelivery.Models.ViewModel.DTOs;
using FoodDelivery.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace FoodDelivery.Service.Implementations
{
    public class ReviewService:IReviewService
    {
        public readonly DataContext _db;
        public ReviewService(DataContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Review>> GetListAsync()
        {
            try
            {
                var review = await _db.Reviews.AsNoTracking().ToListAsync();
                return review;
            }
            catch (Exception ex)
            {
                throw new Exception("error when getting an review list ", ex);
            }
        }
        public async Task<Review> GetByIdAsync(int id)
        {
            try
            {
                var review = await _db.Reviews.FirstOrDefaultAsync(x => x.Id == id);
                if (review == null)
                    throw new Exception("no review found");
                return review;
            }
            catch (Exception ex)
            {
                throw new Exception("review search error ", ex);
            }
        }
        public async Task<bool> CreateAsync(ReviewDto reviewDto)
        {
            try
            {
                Review review = new Review();
                review.CreationDate = review.CreationDate;
                review.UserId = review.UserId;
                review.CustomerRating = review.CustomerRating;
                review.Description = review.Description;
                _db.Reviews.Add(review);
                return await SaveAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("error when creating an review ", ex);
            }
        }
        public async Task<bool> UpdateAsync(Review review)
        {
            try
            {
                _db.Update(review);
                return await SaveAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("error when changing an review ", ex);
            }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var review = await _db.Reviews.FirstOrDefaultAsync(c => c.Id == id);
                if (review == null)
                    throw new Exception("no vendor review");
                _db.Reviews.Remove(review);
                return await SaveAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("error when deleting an review ", ex);
            }
        }
        public async Task<bool> SaveAsync()
        {
            try
            {
                var saved = await _db.SaveChangesAsync();
                return saved > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw new Exception("save error ", ex);
            }
        }
    }
}
