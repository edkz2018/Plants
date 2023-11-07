using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Plants
{
	public class PlantsReplantingPlan : BaseModel
	{
		public long PlantId { get; set; }
		public DateTime LastReplantingDate { get; set; }
	}
}
