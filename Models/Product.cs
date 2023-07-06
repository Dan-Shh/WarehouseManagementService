using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Swashbuckle.AspNetCore.Annotations;

namespace WarehouseManagementService.Models;

public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [SwaggerSchema(ReadOnly = true)]
    public long Id {get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public int quantity { get; set; }

    public string? Notes { get; set; }
}