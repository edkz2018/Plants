using Microsoft.EntityFrameworkCore;
using Models.Plants;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.Plants;

public class PlantDto
{
	public long Id { get; internal set; }
	public string Name { get; internal set; }
	public double? Price { get; internal set; }
	public string? Soil { get; internal set; }
	public string? Description { get; internal set; }
	public int IntervalWatering { get; internal set; }
	public DateTime? LastWateringDay { get; internal set; }

	public PlantDto(Plant plant)
	{
		Id= plant.Id;
		Name = plant.Name;
		Price = plant.Price;
		Soil = plant.Soil;
		Description = plant.Description;
		IntervalWatering = plant.IntervalWatering;
		LastWateringDay = plant.LastWateringDay;
	}


}
