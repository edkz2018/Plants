using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Dtos.Plants;
using Models.Plants;
using Services.Flowers;
using Services.Plants.Requests;

namespace Flowers.Controllers
{
    [ApiController]
	[Route("plant")]
	public class PlantsController : Controller
	{
		private readonly IPlantService _plantServices;

		public PlantsController(IPlantService plantServices)
		{
			_plantServices = plantServices;
		}

		[HttpGet("get")]
		public async Task<PlantDto> GetAsync([FromQuery] long id)
		{
			return await _plantServices.GetAsync(id);
			
		}

		[HttpGet("list")]
		public async Task<List<PlantDto>> ListAsync([FromQuery] PlantListRequest plantListRequest)
		{
			return await _plantServices.ListAsync(plantListRequest);
		}

		[HttpPost("add")]
		public async Task<long> AddAsync([FromBody]PlantRequest plantRequest)
		{
			return await _plantServices.AddAsync(plantRequest);
		}

		[HttpDelete]
		public async Task DeleteAsync(long id)
		{
			 await _plantServices.DeleteAsync(id);
		}

		[HttpPut("id")]
		public async Task<PlantDto> EditAsync(EditPlantRequest editPlantRequest)
		{
			return await _plantServices.EditAsync(editPlantRequest);
		}

	}
}
