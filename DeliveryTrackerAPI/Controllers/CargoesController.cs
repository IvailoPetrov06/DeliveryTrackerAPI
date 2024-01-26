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
using DeliveryTrackerAPI.DTOS.Response;
using DeliveryTrackerAPI.DTOS.Requests;

namespace DeliveryTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICargoService _cargoservice;

        public CargoesController(IMapper mapper, ICargoService cargoservice)
        {
            _mapper = mapper;
            _cargoservice = cargoservice;
        }

        // GET: api/Cargoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CargoResponseDto>>> GetCargos()
        {

            return _mapper.Map<List<CargoResponseDto>>(
                await _cargoservice.GetAll()
                );
        }

        // GET: api/Cargoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CargoResponseDto>> GetCargo(int id)
        {
            var cargo = await _cargoservice.GetById(id);

            if (cargo == null)
            {
                return NotFound();
            }

            return _mapper.Map<CargoResponseDto>(cargo);
        }

        // PUT: api/Cargoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCargo(int id, CargoRequestDto cargo)
        {
            if (id != cargo.Id)
            {
                return BadRequest();
            }

            try
            {
                await _cargoservice.Update(_mapper.Map<Cargo>(cargo));
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        // POST: api/Cargoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cargo>> PostCargo(Cargo model)
        {
            var cargo = _mapper.Map<Cargo>(model);

            await _cargoservice.Add(cargo);
            return CreatedAtAction("GetCargo", new { id = cargo.Id }, _mapper.Map<DriverResponseDto>(cargo));
        }

        // DELETE: api/Cargoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCargo(int id)
        {
            _cargoservice.Delete(id);
            return NoContent();
        }
    }
}
