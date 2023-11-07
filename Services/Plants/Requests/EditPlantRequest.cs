using Models;
using Models.Plants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Plants.Requests;

public class EditPlantRequest
{
	public int Id { get; init; }
	public string Name { get; init; }
	public double? Price { get; internal set; }
	public string? Soil { get; internal set; }
	public string? Description { get; internal set; }
	public int IntervalWatering { get; internal set; }
	public DateTime LastWateringDay { get; internal set; }

	public Plant EditPlant()
	{
		return new Plant(
			Name,
			Price,
			Soil,
			Description,
			IntervalWatering,
			LastWateringDay
			);
	}


}
