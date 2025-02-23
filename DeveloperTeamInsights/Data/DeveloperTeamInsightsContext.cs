using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeveloperTeamInsights.Models;

namespace DeveloperTeamInsights.Data
{
    public class DeveloperTeamInsightsContext : DbContext
    {
        public DeveloperTeamInsightsContext (DbContextOptions<DeveloperTeamInsightsContext> options)
            : base(options)
        {
        }

        public DbSet<DeveloperTeamInsights.Models.Developer> Developers { get; set; } = default!;
    }
}
