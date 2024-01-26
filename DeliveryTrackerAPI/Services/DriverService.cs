using AutoMapper;
using DeliveryTrackerAPI.Data;
using DeliveryTrackerAPI.Repositories;

namespace DeliveryTrackerAPI.Services
{
    public class DriverService : IDriverService
    {
        private readonly ICrudRepository<Driver> _repository;
        private readonly AppDbContext _context;
        public DriverService(ICrudRepository<Driver> repository, AppDbContext context)
        {
            _repository = repository;
            _context = context;
        }
        public Task Add(Driver driver)
        {
            return _repository.AddAsync(driver);
        }

        public Task Delete(int id)
        {
            return _repository.DeleteAsync(id);
        }

        public Task<List<Driver>> GetAll()
        {
            return _repository.GetAllAsync();
        }

        public Task<Driver> GetById(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task Update(Driver driver)
        {
            return _repository.UpdateAsync(driver);
        }
    }
}
