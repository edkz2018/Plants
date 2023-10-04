using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Plants;
using Services.Plants.Requests;

namespace Services.Flowers
{
    public interface IPlantService
	{
		Task<long> AddAsync(PlantRequest plantRequest);
		Task<List<Plant>> Get();
		Task DeleteAsync(long id);
		Task<long> EditAsync(long id, PlantRequest plantRequest);


	}
}
