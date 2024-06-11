using _080_CSharp_CQRS_MediatorR.Models;
using Microsoft.EntityFrameworkCore;

namespace _080_CSharp_CQRS_MediatorR.Data
{
    public class _080_CSharp_CQRS_MediatorRDBContext: DbContext
    {
        public _080_CSharp_CQRS_MediatorRDBContext(DbContextOptions<_080_CSharp_CQRS_MediatorRDBContext> options) : base(options)
        {
            
        }

        public DbSet<Player> Players { get; set; }
    }
}
