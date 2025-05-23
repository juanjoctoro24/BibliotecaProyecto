using BibliotecaProyecto.DAL.Entities;

namespace BibliotecaProyecto.Domain.Interfaces
{
    public interface ICountryService
    {
        // get by id
        // get all
        // create
        // update
        // delete

        Task<IEnumerable<Country>> GetCountriesAsync();//Firma de un metodo

        Task<Country> CreateCountryAsync(Country country);

        Task<Country> GetCountryByIdAsync(Guid id);

        Task<Country> EditCountryAsync(Country country);

        Task<Country> DeleteCountryAsync(Guid id);
        //Collections
        //IList
        //ICollection
        //IEnumerable
        //IQuerable
    }
}
