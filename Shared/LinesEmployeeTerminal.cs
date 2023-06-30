using System.ComponentModel.DataAnnotations;


namespace GestionTelefonos.Shared
{
    public class LinesEmployeeTerminal
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo 'ID Empleado' requerido.")]
        public int IDEmployee { get; set; }
        [Required(ErrorMessage = "Campo 'ID Linea' requerido.")]
        public int IDLine { get; set; }

        [Required(ErrorMessage = "Campo 'ID Terminal' requerido.")]
        public int IDTerminal { get; set; }

    }
}
