using Firma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.BusinessLogic
{
    public class UtargB:DatabaseClass
    {
        #region Constructor
        public UtargB(Faktury2022Entities faktury2022Entities)
            : base(faktury2022Entities)
        {
            
        }
        #endregion
        #region BuiosnesFunctions
        // to jest funkcja ktora zwraca wielkosc utargu w danym okresie dla wybranego towaru
        public decimal? UtargOkresTowar(int idTowaru, DateTime dataOd, DateTime dataDo) {
            return (
                from pozycja in this.FakturyEntities.PozycjaFakturies
                where
                pozycja.IdTowaru == idTowaru &&
                pozycja.Faktura.DataWystawienia >= dataOd &&
                pozycja.Faktura.DataWystawienia <= dataDo &&
                pozycja.CzyAktywny == true
                select
                (
                    pozycja.Cena * pozycja.Ilosc
                )
                ).Sum();
        }
        #endregion
    }
}
