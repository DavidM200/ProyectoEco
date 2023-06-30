using System.ComponentModel.DataAnnotations;

namespace GestionTelefonos.Shared
{
    public class Rate
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo 'Nombre' requerido.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Campo 'Compañia' requerido.")]
        public int IDCompany { get; set; }
        [Required(ErrorMessage = "Campo 'Precio' requerido.")]
        public decimal? Amount { get; set; }
        [Required(ErrorMessage = "Campo 'Descuento' requerido.")]
        public decimal? Discount { get; set; }
        [Required(ErrorMessage = "Campo 'Precio Mensual' requerido.")]
        public decimal? MonthlyNetAmount { get; set; }
    }
}
