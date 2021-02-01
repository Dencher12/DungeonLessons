using System;
using System.Collections.Generic;
using System.Text;
using DungeonLessons.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DungeonLessons.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Lesson> Lessons { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}