using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionTelefonos.Shared.Contracts.Forms
{
    public class RateSearcherForm
    {
        #nullable enable
        public string? Name { get; set; }
        public List<int>? CompanyIds { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Discount { get; set; }
        public decimal? MonthlyNetAmount { get; set; }
        public string? OperacionAmount { get; set; }
        public  string? OperacionDiscount { get; set; }
        public string? OperacionMonthlyNetAmount { get; set; }
    }
}
