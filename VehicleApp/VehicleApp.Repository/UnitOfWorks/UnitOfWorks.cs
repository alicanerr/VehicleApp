using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core.UnitOfWorks;

namespace VehicleApp.Repository.UnitOfWorks
{
    public class UnitOfWorks :IGenericUnitOfWork
    {
        private readonly AppDbContexts.AppDbContext _context;

        public UnitOfWorks(AppDbContexts.AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
