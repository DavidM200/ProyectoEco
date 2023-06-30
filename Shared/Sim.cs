using System.ComponentModel.DataAnnotations;

namespace GestionTelefonos.Shared
{
    public class Sim
    {
        
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo 'ID Linea' requerido.")]
        public int IDLine { get; set; }
        [Required(ErrorMessage = "Campo 'Numero de serie' requerido.")]
        public string NSerie { get; set; }
        [Required(ErrorMessage = "Campo 'Tipo SIM' requerido.")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Campo 'Numero de telefono' requerido.")]
        public int? Number { get; set; }
        [Required(ErrorMessage = "Campo 'PIN' requerido.")]
        public string PIN { get; set; }
        [Required(ErrorMessage = "Campo 'PUK' requerido.")]
        public string PUK { get; set; }
    }
}
