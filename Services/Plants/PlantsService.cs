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
using Models.Dtos.Plants;

namespace Services.Flowers
{
    public class PlantsService : IPlantService
	{
		private readonly DateBaseContext _context;
		public PlantsService(DateBaseContext context)
		{
			_context = context;
		}
		
		public async Task<PlantDto> GetAsync(long id)
		{
			var plant = await _context.Plants.FirstOrDefaultAsync(x => x.Id == id);
			return new PlantDto(plant);
		}

		public async Task<List<PlantDto>> ListAsync(PlantListRequest plantListRequest)
		{
			var plants = _context.Plants;
			if(plantListRequest.Price != null)
			{
				plants.Where(p => p.Price == plantListRequest.Price).OrderBy(p => p.Price);
			}
			if(plantListRequest.Name != null)
			{
				plants.Where(n => n.Name == plantListRequest.Name).OrderBy(n => n.Name);
			}

			return new List<PlantDto>(plants.Select(p => new PlantDto(p))).ToList();
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

		public async Task<PlantDto> EditAsync(EditPlantRequest editPlantRequest)
		{
			var plant = editPlantRequest.EditPlant();
			plant = await _context.Plants.FirstOrDefaultAsync(x => x.Id == editPlantRequest.Id);
			if (plant != null)
				plant.Update(editPlantRequest.EditPlant());
			await _context.SaveChangesAsync();
			return new PlantDto(plant);
		}


	}
}
