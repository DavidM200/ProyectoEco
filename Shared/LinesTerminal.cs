using System;
using System.ComponentModel.DataAnnotations;

namespace GestionTelefonos.Shared
{
    public class LinesTerminal
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo 'ID Linea' requerido.")]
        public int IDLine { get; set; }
        [Required(ErrorMessage = "Campo 'ID Terminal' requerido.")]
        public int IDTerminal { get; set; }
        [Required(ErrorMessage = "Campo 'Fecha Inicio' requerido.")]
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }

    }
}
