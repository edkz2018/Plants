using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    internal Plant() { }

    public Plant(
        string name, 
        double? price, 
        string? soil, 
        string? description, 
        int intervalWatering) 
    {
        Name = name;
        Price = price;
        Soil = soil;
        Description = description;
        IntervalWatering = intervalWatering;
    }
}
