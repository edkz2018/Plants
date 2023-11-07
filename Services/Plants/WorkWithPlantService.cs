using DataBase.Context;
using Microsoft.EntityFrameworkCore;
using Models.Dtos.Plants;
using Services.Plants.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Plants;

public class WorkWithPlantService : IWorkWithPlantService
{
	private readonly DateBaseContext _context;
	public WorkWithPlantService(DateBaseContext context)
	{
		_context = context;
	}

	public async Task<PlantDto> TimeToWaterThePlantAsync(PlantWateringRequest plantWateringRequest)
	{
		var plant = await _context.Plants.FirstOrDefaultAsync(p => p.Id == plantWateringRequest.Id);
		if (plant == null)
		{
			throw new Exception("Plant not found!");
		}
		plant.Update(DateTime.Now);
		_context.SaveChanges();
		return new PlantDto(plant);
	}

	public async Task<DateTime> NextWateringDateAsync(long id)
	{

		var plant = await _context.Plants.FirstOrDefaultAsync(p => p.Id == id);
		if (plant == null)
		{
			throw new Exception("Plant not found!");
		}
		DateTime lwd = plant.LastWateringDay ?? DateTime.Now;
		if(plant.LastWateringDay != null)
		{

			return lwd.AddDays(plant.IntervalWatering);
		}
		else
		{
			plant.Update(DateTime.Now.AddDays(-plant.IntervalWatering));
			_context.SaveChanges();
			return lwd;
		}
	}

}
