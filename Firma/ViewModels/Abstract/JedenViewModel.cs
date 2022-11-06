using Firma.Helpers;
using Firma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModels.Abstract
{
    public abstract class JedenViewModel<T>:WorkspaceViewModel
    {

        #region Fields
        public Faktury2022Entities DB { get; set; }
        //private Towar towar;
        public T Item { get; set; }
        #endregion
        #region Konstruktor
        public JedenViewModel(string displayName)
        {
            base.DisplayName = displayName;//tu ustawiamy nazwę zakładki
            DB = new Faktury2022Entities();
        }
        #endregion
        #region Command
        private BaseCommand _SaveAndCloseCommand;
        public ICommand saveAndCloseCommand
        {
            get
            {
                if (_SaveAndCloseCommand == null)
                {
                    _SaveAndCloseCommand = new BaseCommand(() => saveAndClose());
                }
                return _SaveAndCloseCommand;
            }
        }
        #endregion
        #region Save
        public abstract void Save();
        private void saveAndClose()
        {
            Save();
            base.OnRequestClose();
        }
        #endregion
    }
}
    

