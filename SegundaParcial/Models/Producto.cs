using System.ComponentModel.DataAnnotations;

namespace SegundaParcial.Models
{
    public class Producto
    {
        [Required(ErrorMessage = "El número de inventario es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de inventario debe ser un entero positivo")]
        public int Inventario { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        [MaxLength(200, ErrorMessage = "El nombre del producto no puede exceder 200 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El departamento es obligatorio")]
        [RegularExpression("^(Frutas|Verduras|Lácteos)$", ErrorMessage = "El departamento debe ser Frutas, Verduras o Lácteos")]
        public string Departamento { get; set; }
    }
}
