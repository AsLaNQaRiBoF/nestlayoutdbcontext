﻿using Microsoft.EntityFrameworkCore;
using NestApp.Models;

namespace NestApp.DAL
{
	public class AppDbContext:DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option)
        {
            
        }
		public DbSet<Slider> Sliders { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductImage> ProductImages { get; set; }
	}
}
