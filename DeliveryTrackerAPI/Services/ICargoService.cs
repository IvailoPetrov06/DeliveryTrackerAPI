using DeliveryTrackerAPI.Data;

namespace DeliveryTrackerAPI.Services
{
    public interface ICargoService
    {
        public Task<List<Cargo>> GetAll();
        public Task<Cargo> GetById(int id);
        public Task Add(Cargo cargo);
        public Task Update(Cargo cargo);
        public Task Delete(int id);
    }
}
