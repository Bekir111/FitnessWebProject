﻿using FitnessApp.Data;
using FitnessApp.Services.Data.Interfaces;
using FitnessApp.Web.ViewModels.Product;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp.Services.Data
{
    public class ProductService : IProductService
    {
        private readonly FitnessAppDbContext dbContext;

        public ProductService(FitnessAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ICollection<ProductAllViewModel>> GetAllProducts()
        {
            return await this.dbContext.Products
                .Select(p => new ProductAllViewModel()
                {
                    Id = p.Id.ToString(),
                    Name = p.Name,
                    IsAvailable = p.IsAvailable,
                    PictureUrl = p.PictureUrl,
                    Price = p.Price
                })
                .ToArrayAsync();
        }
    }
}