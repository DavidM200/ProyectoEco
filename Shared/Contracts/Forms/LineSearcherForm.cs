using System;
using System.Collections.Generic;

namespace GestionTelefonos.Shared.Contracts.Forms
{
    public class LineSearcherForm
    {
        #nullable enable
        public List<int>? CompanyIds { get; set; }
        public DateTime? AdmitDateInicio { get; set; }
        public DateTime? AdmitDateFin { get; set; }
        public DateTime? DischargeDateInicio { get; set; }
        public DateTime? DischargeDateFin { get; set; }
        public int? IDRate { get; set; }
        
        public string? Observations { get; set; }
        public int? PhoneNumber { get; set; }
    }
}
