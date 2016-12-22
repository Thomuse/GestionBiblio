using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TarifModel
    {
        public int IdTarif { get; set; }
        public decimal _PrixInscription { get; set; }
        public decimal _PrixEmprunt { get; set; }
        public decimal _PrixRetard { get; set; }
        public decimal _PrixAcademique { get; set; }
    }
}
