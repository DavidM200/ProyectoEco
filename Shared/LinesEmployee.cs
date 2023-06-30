using System;
using System.ComponentModel.DataAnnotations;

namespace GestionTelefonos.Shared
{
    public class LinesEmployee
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo 'ID Linea' requerido.")]
        public int IDLine { get; set; }
        [Required(ErrorMessage = "Campo 'ID Empleado' requerido.")]
        public int IDEmployee { get; set; }
        [Required(ErrorMessage = "Campo 'Fecha Inicio' requerido.")]
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
    }
}
