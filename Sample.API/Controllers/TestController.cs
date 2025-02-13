using Microsoft.AspNetCore.Mvc;
using Sample.Contracts.Data.Repositories;
using System.Threading.Tasks;

namespace Sample.API.Controllers
{
    /// <summary>
    /// Controller for testing CRUD operations functionality for SampleController
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ISampleRepository _sampleRepository;

        public TestController(ISampleRepository sampleRepository)
        {
            _sampleRepository = sampleRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetSamples()
        {
            // Implement GetSamples test function
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSample()
        {
            // Implement CreateSample test function
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSample(int id)
        {
            // Implement UpdateSample test function
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSample(int id)
        {
            // Implement DeleteSample test function
            return Ok();
        }
    }
}