using DeliveryTrackerAPI.Data;

namespace DeliveryTrackerAPI.Services
{
    public interface IDeliveryService
    {
        public Task<List<Delivery>> GetAll();
        public Task<Delivery> GetById(int id);
        public Task Add(Delivery delivery);
        public Task Update(Delivery delivery);
        public Task Delete(int id);
    }
}
