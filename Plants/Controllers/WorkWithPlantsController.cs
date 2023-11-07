
using Microsoft.AspNetCore.Mvc;
using Models.Dtos.Plants;
using Services.Plants;
using Services.Plants.Requests;

namespace Plants.Controllers;

[Route("work-with-plants")]
[ApiController]
public class WorkWithPlantsController : ControllerBase
{
	private readonly IWorkWithPlantService _workWithPlantsService;

	public WorkWithPlantsController(IWorkWithPlantService workWithPlantService)
	{
		_workWithPlantsService = workWithPlantService;
	}

	[HttpPut("update-watering-date")]
	public async Task<PlantDto> TimeToWaterThePlantAsync(PlantWateringRequest plantWateringRequest)
	{
		return await _workWithPlantsService.TimeToWaterThePlantAsync(plantWateringRequest);
	}

	[HttpGet("next-watering-date")]
	public async Task<DateTime> NextWateringDateAsync(long id)
	{
		return await _workWithPlantsService.NextWateringDateAsync(id);
	}
}
