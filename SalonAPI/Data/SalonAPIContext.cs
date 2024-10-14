using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalonAPI.Models.Entities;

namespace SalonAPI.Data
{
    public class SalonAPIContext : DbContext
    {
        public SalonAPIContext (DbContextOptions<SalonAPIContext> options)
            : base(options)
        {
        }


        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
