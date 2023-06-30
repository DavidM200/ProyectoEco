using System;


namespace GestionTelefonos.Shared.Contracts.Forms
{
    public class TerminalSearcherForm
    {
        public string Name { get; set; }
        public string Imei { get; set; }
        public DateTime? BuyDateInicio { get; set; }
        public DateTime? BuyDateFin { get; set; }
        public int? IdPayMethod { get; set; }
        public bool? Paid { get; set; }
        public int? IdTerminalState { get; set; }
        public string Observations { get; set; }
        public decimal? FeeAmount { get; set; }
        public int? NumberOfFees { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
