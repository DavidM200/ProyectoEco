using System;
using System.ComponentModel.DataAnnotations;

namespace GestionTelefonos.Shared
{
    public class Line
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo 'Compañia' requerido.")]
        public int IDCompany { get; set; }
        [Required(ErrorMessage = "Campo 'Fecha Alta' requerido.")]
        public DateTime? AdmitDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        [Required(ErrorMessage = "Campo 'Tarifa' requerido.")]
        public int IDRate { get; set; }

        //[Required(ErrorMessage = "Campo 'Observación' requerido.")]
        //[StringLength(maximumLength: 30, ErrorMessage = "Demasiados caracteres")]
        public string Observations { get; set; }
        [Required(ErrorMessage = "Campo 'Numero Telefono' requerido.")]
        public int PhoneNumber { get; set; }



    }
}