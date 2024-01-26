using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DeliveryTrackerAPI.Data;
using AutoMapper;
using DeliveryTrackerAPI.Data;
using DeliveryTrackerAPI.DTOS.Response;
using DeliveryTrackerAPI.DTOS.Requests;
using DeliveryTrackerAPI.Services;

namespace DeliveryTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDriverService _driverService;

        public DriversController(IMapper mapper, IDriverService driverService)
        {
            _mapper = mapper;
            _driverService = driverService;
        }

        // GET: api/Drivers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DriverResponseDto>>> GetDrivers()
        {
            return _mapper.Map<List<DriverResponseDto>>(
                await _driverService.GetAll()
                );
        }

        // GET: api/Drivers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DriverResponseDto>> GetDriver(int id)
        {
            var driver = await _driverService.GetById(id);

            if (driver == null)
            {
                return NotFound();
            }

            return _mapper.Map<DriverResponseDto>(driver);
        }

        // PUT: api/Drivers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDriver(int id, DriverRequestDto driver)
        {
            if (id != driver.Id)
            {
                return BadRequest();
            }

            try
            {
                await _driverService.Update(_mapper.Map<Driver>(driver));
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
        public async Task<ActionResult<DriverResponseDto>> PostDriver(DriverResponseDto model)
        {
            var driver = _mapper.Map<Driver>(model);

            await _driverService.Add(driver);
            return CreatedAtAction("GetDriver", new { id = driver.Id }, _mapper.Map<DriverResponseDto>(driver));
        }

        // DELETE: api/Drivers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDriver(int id)
        {
            _driverService.Delete(id);
            return NoContent();
        }
    }
}
