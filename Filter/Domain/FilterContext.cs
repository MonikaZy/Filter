using System;
using Microsoft.EntityFrameworkCore;
using Filter.Domain.Models;

namespace Filter.Domain
{
    public class FilterContext : DbContext
    {
        public FilterContext()
        {

        }

        public FilterContext(DbContextOptions<FilterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FilterItem> FilterItems { get; set; }
    }
}
