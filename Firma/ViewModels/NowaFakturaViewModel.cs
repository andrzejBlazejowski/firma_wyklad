using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using Firma.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModels
{
    public class NowaFakturaViewModel : JedenViewModel<Faktura> //bo wszystkie zakładki dziedzicza po workspaceVM
    {
        #region fields
        public string Numer
        {
            get
            {
                return Item.Numer;
            }
            set
            {
                if(Item.Numer != value)
                {
                    Item.Numer = value;
                    base.OnPropertyChanged(()=> Numer);
                }
            }
        }

        public DateTime? DataWystawienia
        {
            get
            {
                return Item.DataWystawienia;
            }
            set
            {
                if (Item.DataWystawienia != value)
                {
                    Item.DataWystawienia = value;
                    base.OnPropertyChanged(() => DataWystawienia);
                }
            }
        }
        public int? IdKontrachenta
        {
            get
            {
                return Item.IdKnotrachenta;
            }
            set
            {
                if (Item.IdKnotrachenta != value)
                {
                    Item.IdKnotrachenta = value;
                    base.OnPropertyChanged(() => IdKontrachenta);
                }
            }
        }
        // tworzenie pop, który będzie obslugiwał comboboxa.
        public IQueryable<KeyAndValue> KontrachenciComboBoxItems
        {
            get
            {
                return
                (
                    from kontrachent in DB.Kontrachencis
                    select
                        new KeyAndValue
                        {
                            Value = kontrachent.Nazwa + " - " + kontrachent.NIP,
                            Key = kontrachent.IdKontrachenta 
                        }
                ).ToList().AsQueryable();
            }
        }
        public DateTime? TerminPlatnosci
        {
            get
            {
                return Item.TerminPlatnosci;
            }
            set
            {
                if (Item.TerminPlatnosci != value)
                {
                    Item.TerminPlatnosci = value;
                    base.OnPropertyChanged(() => TerminPlatnosci);
                }
            }
        }
        public int? IdSposobuPlatnosci
        {
            get
            {
                return Item.IdSposobuPlatnosci;
            }
            set
            {
                if (Item.IdSposobuPlatnosci != value)
                {
                    Item.IdSposobuPlatnosci = value;
                    base.OnPropertyChanged(() => IdSposobuPlatnosci);
                }
            }
        }
        // tworzenie pop, który będzie obslugiwał comboboxa.
        public IQueryable<KeyAndValue> SposobyPlatnosciComboBoxItems
        {
            get
            {
                return
                (
                    from SposubPlatnosci in DB.SposubPlatnoscis
                    select
                        new KeyAndValue
                        {
                            Value = SposubPlatnosci.Nazwa,
                            Key = SposubPlatnosci.IdSposobuPlatnosci,
                        }
                ).ToList().AsQueryable();
            }
        }
        #endregion

        #region Konstruktor
        public NowaFakturaViewModel()
            : base("Towar")
        {
            Item = new Faktura();
        }
        #endregion
        #region Save
        public override void Save()
        {
            Item.CzyAktywna = true;
            Item.CzyZatwierdzone = true;
            DB.Fakturas.AddObject(Item);
            DB.SaveChanges();

        }
        #endregion
    }
}
