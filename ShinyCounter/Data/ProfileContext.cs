using Microsoft.EntityFrameworkCore;
using ShinyCounter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShinyCounter.Data
{
    public class ProfileContext : DbContext
    {
        public ProfileContext (DbContextOptions<ProfileContext> options) : base(options)
        {

        }

        public DbSet<Profile> Profile { get; set; } // Qualifies a row within the database table as a PROFILE

    }
}
