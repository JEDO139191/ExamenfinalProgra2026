using System.ComponentModel.DataAnnotations;

namespace ProductosAPI.Modelo;

public class Producto
{
    [Key]
    public int Id { get; set; }

    public string Nombre { get; set; } = string.Empty;

    public decimal Precio { get; set; }

    public int Stock { get; set; }
}