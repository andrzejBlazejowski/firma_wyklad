using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class FakturaForAllView
    {
        #region Properties
        public int IdFaktury { get; set; }
        public string Numer { get; set; }
        public DateTime DataWystawienia { get; set; }
        public string KontrachentNazwa { get; set; }
        public string KontrachentNIP { get; set; }
        public string KontrachentAdres { get; set; }
        #endregion

        public DateTime TerminPlatnosci { get; set; }

    }
}
