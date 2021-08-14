using BpmApp.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BpmApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PositionController : ControllerBase
    {
        private readonly IPositionRepository _positionRepository;

        public PositionController(IPositionRepository positionRepository) // ← инъекция
        {
            _positionRepository = positionRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = _positionRepository.GetAll().ToList();
            return Ok(result);
        }
    }
}
