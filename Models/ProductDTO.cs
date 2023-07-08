using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Swashbuckle.AspNetCore.Annotations;

namespace WarehouseManagementService.Models;

public class ProductDTO
{
    public ProductDTO(Product p){
        Id = p.Id;
        Name = p.Name;
        Quantity = p.Quantity;
    }

    [SwaggerSchema(ReadOnly = true)]
    public long Id {get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public int Quantity { get; set; }

}