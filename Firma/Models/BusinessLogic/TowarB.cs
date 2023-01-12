using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.BusinessLogic
{
    public class TowarB : DatabaseClass
    {
        #region constructor
        public TowarB(Faktury2022Entities faktury2022Entities)
            : base(faktury2022Entities)
        {
            Faktury2022Entities = faktury2022Entities;
        }

        public Faktury2022Entities Faktury2022Entities { get; }

        #endregion
        #region buisness functions
        // poniższa fn zwraca wszystkie towary aktywne z bazy danych ich nazwe i id 
        public IQueryable<KeyAndValue> GetAktywneTowary() {
            return (
                    from Towar in Faktury2022Entities.Towars
                    where Towar.CzyAktywny == true
                    select new KeyAndValue { 
                        Key = Towar.IdTowaru,
                        Value = Towar.Nazwa
                    }
                ).ToList().AsQueryable();
        }
        #endregion
    }
}
