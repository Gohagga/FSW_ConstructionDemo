using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces.A1HR.Construction;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleConstructionController : ControllerBase
    {
        private readonly IConstructionService _constructionService;

        public ExampleConstructionController(IConstructionService constructionService)
        {
            this._constructionService = constructionService;
        }

        [Route("trail-exists/{id}")]
        [HttpGet]
        public async Task<ActionResult<bool>> TrailExists(string id)
        {
            // var trailResult = await Task.Run(() => _constructionService.GetTrailById(id));
            var trailResult = await _constructionService.GetTrailByIdAsync(id);

            return CreatedAtAction(nameof(TrailExists), new { result = trailResult != null });
        }
    }
}