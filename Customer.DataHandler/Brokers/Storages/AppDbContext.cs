//=================================
// Copyright (c) Customer LLC.
// Powering True Leadership
//===============================

using Customer.DataHandler.Models.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.DataHandler.Brokers.Storages
{
    internal class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppDbContext() =>
           this.Database.EnsureCreated();

        public async Task<User> InsertUserAsync(User user)
        {
            await this.Users.AddAsync(user);
            await this.SaveChangesAsync();

            return user;
        }

        public async Task<User> SelectClientByIdAsync(Guid userId) =>
            await this.Users.FindAsync(userId);

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=..\\..\\..\\Customers.db";
            optionsBuilder.UseSqlite(connectionString);
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}
