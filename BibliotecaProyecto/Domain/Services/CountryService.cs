using BibliotecaProyecto.DAL;
using BibliotecaProyecto.DAL.Entities;
using BibliotecaProyecto.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaProyecto.Domain.Services
{
    public class CountryService : ICountryService
    {

        private readonly DataBaseContext _context;
        public CountryService (DataBaseContext context)
        {
            _context = context;
        }


        public async Task<Country> CreateCountryAsync(Country country)
        {
           

            try
            {
                country.Id = Guid.NewGuid();
                country.CreatedDate = DateTime.Now;
                _context.Countries.Add(country);
                await _context.SaveChangesAsync();

                return country;
            }
            catch(DbUpdateException dbUpdateException)
            {
                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<Country> DeleteCountryAsync(Guid id)
        {
            var country = await GetCountryByIdAsync(id);

            if (country == null)
            {
                return null;
            }
            _context.Countries.Remove(country);

            return country;
        }

        public async Task<Country> EditCountryAsync(Country country)
        {
            try
            {
                country.ModifiedDate= DateTime.Now;
                _context.Countries.Update(country);
                await _context.SaveChangesAsync();

                return country;
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<IEnumerable<Country>> GetCountriesAsync()
        {
            
            try
            {
                return await _context.Countries.ToListAsync();
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }

        }

        public async Task<Country> GetCountryByIdAsync(Guid id)
        {
            
            try
            {
                var country = await _context.Countries.FirstOrDefaultAsync(c => c.Id == id);
                return country;
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }
    }
}
