using Models.Plants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Plants;

namespace Services.Plants.Requests
{
	public class PlantListRequest
	{
		public string? Name { get; init; } = string.Empty;
		public double? Price { get; init; } = 0;

	}
}
