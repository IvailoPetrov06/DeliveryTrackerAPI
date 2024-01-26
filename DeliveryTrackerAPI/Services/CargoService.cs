using DeliveryTrackerAPI.Data;
using DeliveryTrackerAPI.Repositories;

namespace DeliveryTrackerAPI.Services
{
    public class CargoService : ICargoService
    {
        private readonly ICrudRepository<Cargo> _repository;
        private readonly AppDbContext _context;
        public CargoService(ICrudRepository<Cargo> repository, AppDbContext context)
        {
            _repository = repository;
            _context = context;
        }
        public Task Add(Cargo cargo)
        {
            return _repository.AddAsync(cargo);
        }

        public Task Delete(int id)
        {
            return _repository.DeleteAsync(id);
        }

        public Task<List<Cargo>> GetAll()
        {
            return _repository.GetAllAsync();
        }

        public Task<Cargo> GetById(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task Update(Cargo cargo)
        {
            return _repository.UpdateAsync(cargo);
        }
    }
}
