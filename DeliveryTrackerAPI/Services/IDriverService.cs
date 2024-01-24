using DeliveryTrackerAPI.Data;

namespace DeliveryTrackerAPI.Services
{
    public interface IDriverService
    {
        public Task<List<Driver>> GetAll();
        public Task<Driver> GetById(int id);
        public Task Add(Driver driver);
        public Task Update(Driver driver);
        public Task Delete(int id);
    }
}
