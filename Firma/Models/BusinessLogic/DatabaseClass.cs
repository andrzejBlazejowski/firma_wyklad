using Firma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.BusinessLogic
{
    // to jest klasa z której będą dziedziczyć wszystkie klasy logiki biznesowej, ktore uzywaja bazy danych 
    public class DatabaseClass
    {
        #region entities
        public Faktury2022Entities FakturyEntities { get; set; }
        #endregion

        #region constructor
        public DatabaseClass(Faktury2022Entities fakturyEntities)
        {
            this.FakturyEntities = fakturyEntities;
        }

        #endregion
    }
}
