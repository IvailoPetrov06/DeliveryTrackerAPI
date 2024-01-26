using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DeliveryTrackerAPI.Data;
using AutoMapper;
using DeliveryTrackerAPI.Services;
using DeliveryTrackerAPI.DTOS.Requests;
using DeliveryTrackerAPI.DTOS.Response;

namespace DeliveryTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveriesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDeliveryService _deliveryService;

        public DeliveriesController(IMapper mapper, IDeliveryService deliveryService)
        {
            _mapper = mapper;
            _deliveryService = deliveryService;
        }

        // GET: api/Drivers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeliveryResponseDto>>> GetDeliveries()
        {
            return _mapper.Map<List<DeliveryResponseDto>>(
                await _deliveryService.GetAll()
                );
        }

        // GET: api/Drivers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeliveryResponseDto>> GetDelivery(int id)
        {
            var delivery = await _deliveryService.GetById(id);

            if (delivery == null)
            {
                return NotFound();
            }

            return _mapper.Map<DeliveryResponseDto>(delivery);
        }

        // PUT: api/Drivers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDelivery(int id, DeliveryRequestDto delivery)
        {
            if (id != delivery.Id)
            {
                return BadRequest();
            }

            try
            {
                await _deliveryService.Update(_mapper.Map<Delivery>(delivery));
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        // POST: api/Drivers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DeliveryResponseDto>> PostDriver(DeliveryResponseDto model)
        {
            var delivery = _mapper.Map<Delivery>(model);

            await _deliveryService.Add(delivery);
            return CreatedAtAction("GetDelivery", new { id = delivery.Id }, _mapper.Map<DeliveryResponseDto>(delivery));
        }

        // DELETE: api/Drivers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDelivery(int id)
        {
            _deliveryService.Delete(id);
            return NoContent();
        }
    }
}
