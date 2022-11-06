using Firma.Helpers;
using Firma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModels.Abstract
{
    public abstract class WszystkieViewModel<T> :WorkspaceViewModel
{
        #region Fields
        private readonly Faktury2022Entities faktury2022Entities;
        public Faktury2022Entities Faktury2022Entities
        {
            get { return faktury2022Entities; }
        }
        private BaseCommand _LoadCommand;
        public ICommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                {
                    _LoadCommand = new BaseCommand(() => load());
                }
                return _LoadCommand;
            }
        }
        private ObservableCollection<T> _List;
        public ObservableCollection<T> List
        {
            get
            {
                if (_List == null)
                {
                    load();
                }
                return _List;
            }
            set
            {
                _List = value;
                OnPropertyChanged(() => List);
            }
        }
        #endregion
        #region Konstruktor
        public WszystkieViewModel( string displayName)
        {
            base.DisplayName = displayName;//tu ustawiamy nazwę zakładki
            this.faktury2022Entities = new Faktury2022Entities();
        }
        #endregion
        #region helpers
        public abstract void load();
        #endregion
    }
}
