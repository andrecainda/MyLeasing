using MyLeasing.Web.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeasing.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            // Garante que a BD existe
            _context.Database.EnsureCreated();

            // Verifica se já existem Owners
            if (_context.Owners.Any())
            {
                return; // Já existem dados, nada a fazer
            }

            for (int i = 1; i <= 10; i++)
            {
                _context.Owners.Add(new Owner
                {
                    Document = $"1000{i}",
                    FirstName = $"First {i}",
                    LastName = $"Last {i}",
                    FixedPhone = $"222-000{i}",
                    CellPhone = $"933-000{i}",
                    Address = $"Street {i}, City"
                });
            }

            await _context.SaveChangesAsync();
        }

    }
}
