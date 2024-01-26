using DeliveryTrackerAPI.Data;
using DeliveryTrackerAPI.Repositories;

namespace DeliveryTrackerAPI.Services
{
    public class DeliveryService : IDeliveryService
    {
        private readonly ICrudRepository<Delivery> _repository;
        private readonly AppDbContext _context;
        public DeliveryService(ICrudRepository<Delivery> repository, AppDbContext context)
        {
            _repository = repository;
            _context = context;
        }
        public Task Add(Delivery delivery)
        {
            return _repository.AddAsync(delivery);
        }

        public Task Delete(int id)
        {
            return _repository.DeleteAsync(id);
        }

        public Task<List<Delivery>> GetAll()
        {
            return _repository.GetAllAsync();
        }

        public Task<Delivery> GetById(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task Update(Delivery delivery)
        {
            return _repository.UpdateAsync(delivery);
        }
    }
}
