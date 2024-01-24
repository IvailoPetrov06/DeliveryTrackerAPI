using AutoMapper;
using DeliveryTrackerAPI.Data;
using DeliveryTrackerAPI.Repositories;

namespace DeliveryTrackerAPI.Services
{
    public class DriverService : IDriverService
    {
        private readonly IDriverRepository<Driver> _repository;
        private readonly AppDbContext _context;
        public DriverService(IDriverRepository<Driver> repository, AppDbContext context)
        {
            _repository = repository;
            _context = context;
        }
        public Task Add(Driver department)
        {
            return _repository.AddAsync(department);
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

        public Task Update(Driver department)
        {
            return _repository.UpdateAsync(department);
        }
    }
}
