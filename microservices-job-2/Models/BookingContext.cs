using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace microservices_job_2.Models
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions<BookingContext> options)
        : base(options)
        {
        }

        public DbSet<Booking> Bookings { get; set; } = null!;
    }
}
