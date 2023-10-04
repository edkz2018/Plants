using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using DataBase.Context;
using Models.Plants;
using Microsoft.EntityFrameworkCore;
using Services.Plants.Requests;

namespace Services.Flowers
{
    public class PlantsService : IPlantService
	{
		private readonly DateBaseContext _context;
		public PlantsService(DateBaseContext context)
		{
			_context = context;
		}
		
		public async Task<List<Plant>> Get()
		{
			var plants = _context.Plants.ToList();
            foreach (var item in plants)
            {
				var plant = new PlantRequest
				{
					Name = item.Name,
					Price = item.Price,
					Soil = item.Soil,
					Description = item.Description,
					WateringIntervalDay = item.IntervalWatering
				};
				plants.Add(plant.GetPlant());
            }
			await _context.SaveChangesAsync();
            return plants;
		}

		public async Task<long> AddAsync(PlantRequest plantRequest)
		{
			var plant = plantRequest.CreatePlant();
			await _context.Plants.AddAsync(plant);
			await _context.SaveChangesAsync();
			return plant.Id;
		}

		public async Task DeleteAsync(long id)
		{
			Plant? plant = await _context.Plants.FirstOrDefaultAsync(x => x.Id == id);
			if (plant != null)
			_context.Remove(plant);
			await _context.SaveChangesAsync();
		}

		public async Task<long> EditAsync(long id, PlantRequest plantRequest)
		{
			var plant = plantRequest.EditPlant();
			plant = await _context.Plants.FirstOrDefaultAsync(x => x.Id == id);
			if (plant != null)
			_context.Update(plant);
			await _context.SaveChangesAsync();
			return plant.Id;
		}


	}
}
