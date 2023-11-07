using Models.Dtos.Plants;
using Services.Plants.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Plants;

public interface IWorkWithPlantService
{
	Task<PlantDto> TimeToWaterThePlantAsync(PlantWateringRequest plantWateringRequest);
	Task<DateTime> NextWateringDateAsync(long id);
}
