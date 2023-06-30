using System;
using System.ComponentModel.DataAnnotations;

namespace GestionTelefonos.Shared.Contracts.Forms
{
    public class CompanySearcherForm
    {
        public string Name { get; set; }
        public DateTime? AdmitDateInicio { get; set; }
        public DateTime? AdmitDateFin { get; set; }
        public DateTime? DischargeDateInicio { get; set; }
        public DateTime? DischargeDateFin { get; set; }
    }
}
