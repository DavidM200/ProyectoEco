using System;
using System.ComponentModel.DataAnnotations;


namespace GestionTelefonos.Shared
{
    public class Terminal
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo 'Nombre' requerido.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Campo 'IMEI' requerido.")]
        public string Imei { get; set; }
        [Required(ErrorMessage = "Campo 'Fecha' requerido.")]
        public DateTime? BuyDate { get; set; }
        [Required(ErrorMessage = "Campo 'Metodo Pago' requerido.")]
        public int IdPayMethod { get; set; }
        [Required(ErrorMessage = "Campo 'Pagado' requerido.")]
        public bool Paid { get; set; }
        [Required(ErrorMessage = "Campo 'Estado' requerido.")]
        public int IdTerminalState { get; set; }
        public string Observations { get; set; }
        [Required(ErrorMessage = "Campo 'Precio' requerido.")]
        public decimal FeeAmount { get; set; }
        [Required(ErrorMessage = "Campo 'Cantidad' requerido.")]
        public int NumberOfFees { get; set; }
        [Required(ErrorMessage = "Campo 'Total' requerido.")]
        public decimal TotalAmount { get; set; }
    }
}
