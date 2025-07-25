using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyLeasing.Web.Interfaces;
using MyLeasing.Web.Models;

namespace MyLeasing.Web.Data
{
    public class OwnerRepository : GenericRepository<Owner>, IOwnerRepository
    {
        public OwnerRepository(DataContext context) : base(context)
        {
        }

       
    }


    /*
    public class OwnerRepository : IOwnerRepository
    {
        private readonly DataContext _context;

        public OwnerRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Owner>> GetAllAsync()
        {
            return await _context.Owners.ToListAsync();
        }

        public async Task<Owner> GetByIdAsync(int id)
        {
            return await _context.Owners.FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task AddAsync(Owner owner)
        {
            _context.Owners.Add(owner);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Owner owner)
        {
            _context.Owners.Update(owner);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Owner owner)
        {
            _context.Owners.Remove(owner);
            await _context.SaveChangesAsync();
        }
    */
    

}
