using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Plants;

public class Plant : BaseModel
{
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; internal set; }
    public double? Price { get; internal set; }
    public string? Soil {  get; internal set; } 
    public string? Description { get; internal set; }
    public int IntervalWatering { get; internal set; }
	public DateTime? LastWateringDay { get; internal set; }


    public Plant(
        string name, 
        double? price, 
        string? soil, 
        string? description, 
        int intervalWatering,
        DateTime? lastWateringDay) 
    {
        Name = name;
        Price = price;
        Soil = soil;
        Description = description;
        IntervalWatering = intervalWatering;
        LastWateringDay = lastWateringDay;
    }

    public Plant Update(Plant plant)
    {
        Name = plant.Name;
		Price = plant.Price;
		Soil = plant.Soil;
		Description = plant.Description;
		IntervalWatering = plant.IntervalWatering;
		LastWateringDay = plant.LastWateringDay;
        return this;
	}

    public Plant Update(DateTime newLastWateringDay)
    {
        LastWateringDay = newLastWateringDay;
        return this;
    }
}
