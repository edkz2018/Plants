using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Plants
{
	public class PlantsWateringPlan : BaseModel
	{
		public long PlantId { get; set; }
		public DateTime LastWateringDate { get; set; }
	}
}
