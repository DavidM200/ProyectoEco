using System.ComponentModel.DataAnnotations;

namespace GestionTelefonos.Shared
{
    public class PhoneIncidence
    {

        public int ID { get; set; }
        [Required(ErrorMessage = "Campo 'ID Terminal' requerido.")]
        public int IDTerminal { get; set; }
        [Required(ErrorMessage = "Campo 'ID Empleado' requerido.")]
        public int IDEmployee { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
