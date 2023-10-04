using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Plants;
using Services.Flowers;
using Services.Plants.Requests;

namespace Flowers.Controllers
{
    [ApiController]
	[Route("flower")]
	public class PlantrsController : Controller
	{
		private readonly IPlantService _plantServices;

		public PlantrsController(IPlantService plantServices)
		{
			_plantServices = plantServices;
		}

		[HttpGet("get")]
		public async Task<List<Plant>> Get()
		{
			var flower = await _plantServices.Get();
			return flower;
		}

		[HttpPost("addAsync")]
		public async Task<long> AddAsync(PlantRequest plantRequest)
		{
			return await _plantServices.AddAsync(plantRequest);
		}

		[HttpDelete]
		public async Task DeleteAsync(long id)
		{
			 await _plantServices.DeleteAsync(id);
		}

		[HttpPut("id")]
		public async Task<long> EditAsync(long id, PlantRequest plantRequest)
		{
			return await _plantServices.EditAsync(id, plantRequest);
		}

	}
}
