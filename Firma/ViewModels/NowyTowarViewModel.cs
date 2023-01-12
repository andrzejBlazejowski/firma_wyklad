using Firma.Helpers;
using Firma.Models.Entities;
using Firma.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModels
{
    public class NowyTowarViewModel:JedenViewModel<Towar>
    {
        #region Konstruktor
        public NowyTowarViewModel()
            : base("Towar")
        {
            Item = new Towar();
        }
        #endregion
        #region Properties
        public string Kod {
            get 
            {
                return Item.Kod;
            }
            set 
            {
                if (value != Item.Kod) { 
                    Item.Kod = value;
                    base.OnPropertyChanged(() => Kod);
                }
            }
        }
        public string Nazwa
        {
            get
            {
                return Item.Nazwa;
            }
            set
            {
                if (value != Item.Nazwa)
                {
                    Item.Nazwa = value;
                    base.OnPropertyChanged(() => Nazwa);
                }
            }
        }
        public decimal ? StawkaVatSprzedazy
        {
            get
            {
                return Item.StawkaVatSprzedazy;
            }
            set
            {
                if (value != Item.StawkaVatSprzedazy)
                {
                    Item.StawkaVatSprzedazy = value;
                    base.OnPropertyChanged(() => StawkaVatSprzedazy);
                }
            }
        }

        public decimal? StawkaVatZakupu
        {
            get
            {
                return Item.StawkaVatZakupu;
            }
            set
            {
                if (value != Item.StawkaVatZakupu)
                {
                    Item.StawkaVatZakupu = value;
                    base.OnPropertyChanged(() => StawkaVatZakupu);
                }
            }
        }


        public decimal? Cena
        {
            get
            {
                return Item.Cena;
            }
            set
            {
                if (value != Item.Cena)
                {
                    Item.Cena = value;
                    base.OnPropertyChanged(() => Cena);
                }
            }
        }
        public decimal? Marza
        {
            get
            {
                return Item.Marza;
            }
            set
            {
                if (value != Item.Marza)
                {
                    Item.Marza = value;
                    base.OnPropertyChanged(() => Marza);
                }
            }
        }
        #endregion
        #region Save
        public override void Save()
        {
            Item.CzyAktywny = true;
            DB.Towars.AddObject(Item);
            DB.SaveChanges();
        }
        #endregion
    }
}
