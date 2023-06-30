using System;
using System.ComponentModel.DataAnnotations;

namespace GestionTelefonos.Shared
{
    public class Company
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo 'Nombre' requerido.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Campo 'Fecha Alta' requerido.")]
        public DateTime? AdmitDate { get; set; }
        public DateTime? DischargeDate { get; set; }
    }
}
