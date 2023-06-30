using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTelefonos.Shared.Contracts.Forms
{
    public class SimSearcherForm
    {
        public int? IDLine { get; set; }
        public string NSerie { get; set; }
        public string Type { get; set; }
        public int? Number { get; set; }
        public string PIN { get; set; }
        public string PUK { get; set; }
    }
}
