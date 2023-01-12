using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using Firma.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    public class WszystkieFakturyViewModel: WszystkieViewModel<FakturaForAllView>
    {
        #region Konstruktor
        public WszystkieFakturyViewModel()
            :base("Faktury")
        {
        }
        #endregion
        #region Helpers
        public override void load()
        {
            List = new ObservableCollection<FakturaForAllView>
                (
                    from faktura in Faktury2022Entities.Fakturas
                    where faktura.CzyAktywna == true
                    select new FakturaForAllView 
                    {
                        IdFaktury=faktura.IdFaktury,
                        Numer=faktura.Numer,
                        DataWystawienia=faktura.DataWystawienia,
                        KontrachentNazwa=faktura.Kontrachenci.Nazwa,
                        KontrachentNIP=faktura.Kontrachenci.NIP,
                        KontrachentAdres=
                            faktura.Kontrachenci.Adre.KodPocztowy+" "+ 
                            faktura.Kontrachenci.Adre.Miejscowosc+" "+ 
                            faktura.Kontrachenci.Adre.Ulica+ " "+ 
                            faktura.Kontrachenci.Adre.NrDomu,
                        TerminPlatnosci=faktura.TerminPlatnosci,
                        SposobPlatnosciNazwa=faktura.SposubPlatnosci.Nazwa,
                    }
                );
        }
        #endregion
    }
}
