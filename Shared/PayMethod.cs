using System.ComponentModel.DataAnnotations;

namespace GestionTelefonos.Shared
{
    public class PayMethod
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo 'Nombre' requerido.")]
        public string Name { get; set; }
    }
}
