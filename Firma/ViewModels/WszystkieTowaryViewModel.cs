using Firma.Helpers;
using Firma.Models.Entities;
using Firma.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModels
{
    public class WszystkieTowaryViewModel: WszystkieViewModel<Towar> //bo wszystkie zakładki dziedzicza po WorkspaceViewModel
    {
        #region Konstruktor
        public WszystkieTowaryViewModel()
            : base("Towary")
        { }
        #endregion
        #region Helpers
        public override void load() {
            List = new ObservableCollection<Towar>
                (
                    from towar in Faktury2022Entities.Towars
                    where towar.CzyAktywny==true
                    select towar
                );
        }
        #endregion
    }
}
