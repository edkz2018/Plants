using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Dtos.Plants;
using Models.Plants;
using Services.Plants.Requests;

namespace Services.Flowers
{
    public interface IPlantService
	{
		Task<long> AddAsync(PlantRequest plantRequest);
		Task<PlantDto> GetAsync(long id);
		Task<List<PlantDto>> ListAsync(PlantListRequest plantListRequest);
		Task DeleteAsync(long id);
		Task<PlantDto> EditAsync(EditPlantRequest editPlantRequest);


	}
}
