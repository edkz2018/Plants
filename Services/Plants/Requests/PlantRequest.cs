using Models.Plants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Plants.Requests;

public class PlantRequest
{
	public long Id { get; set; }
	public string Name { get; init; }
	public double? Price { get; init; } = 0;
	public string? Soil { get; init; } = string.Empty;
	public string? Description { get; init; } = string.Empty;
	public int WateringIntervalDay {  get; init; }
	public DateTime? LastWateringDay { get; init; }

	public Plant CreatePlant() 
	{ 
		return new Plant(
			Name,
			Price,
			Soil,
			Description,
			WateringIntervalDay,
			LastWateringDay
			);
	}
	

	public Plant EditPlant()
	{
		return new Plant(
			Name,
			Price,
			Soil,
			Description,
			WateringIntervalDay,
			LastWateringDay
			);
	}

}
