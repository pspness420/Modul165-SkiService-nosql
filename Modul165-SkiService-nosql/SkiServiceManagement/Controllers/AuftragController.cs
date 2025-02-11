using Microsoft.AspNetCore.Mvc;
using SkiServiceManagement.Data.Repositories;
using SkiServiceManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace SkiServiceManagement.Controllers
{
    [ApiController]
    [Route("api/serviceaufträge")]
    public class AuftragController : ControllerBase
    {
        private readonly ServiceauftragRepository _repository;

        public AuftragController(ServiceauftragRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Serviceauftrag>>> GetAll()
        {
            return Ok(await _repository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Serviceauftrag>> GetById(string id)
        {
            var serviceauftrag = await _repository.GetByIdAsync(id);
            if (serviceauftrag == null) return NotFound();
            return Ok(serviceauftrag);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Serviceauftrag serviceauftrag)
        {
            await _repository.CreateAsync(serviceauftrag);
            return CreatedAtAction(nameof(GetById), new { id = serviceauftrag.Id }, serviceauftrag);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Serviceauftrag serviceauftrag)
        {
            await _repository.UpdateAsync(id, serviceauftrag);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
