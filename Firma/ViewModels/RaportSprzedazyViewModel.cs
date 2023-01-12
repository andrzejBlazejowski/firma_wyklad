using Firma.Helpers;
using Firma.Models.BusinessLogic;
using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;

namespace Firma.ViewModels
{
    internal class RaportSprzedazyViewModel: WorkspaceViewModel
    {

        private DateTime _dataOd;
        public DateTime DataOd 
        {
            get { return _dataOd; }
            set {
                if (value != _dataOd)
                {
                    _dataOd = value;
                    OnPropertyChanged(() => DataOd);
                }
            }
        }

        private DateTime _dataDo;
        public DateTime DataDo
        {
            get { return _dataDo; }
            set
            {
                if (value != _dataDo)
                {
                    _dataDo = value;
                    OnPropertyChanged(() => DataDo);
                }
            }
        }
        private int _IdTowaru;
        public int IdTowaru
        {
            get { return _IdTowaru; }
            set
            {
                if (value != _IdTowaru)
                {
                    _IdTowaru = value;
                    OnPropertyChanged(() => IdTowaru);
                }
            }
        }
        private decimal? _Utarg;
        public decimal? Utarg
        {
            get { return _Utarg; }
            set
            {
                if (value != _Utarg)
                {
                    _Utarg = value;
                    OnPropertyChanged(() => Utarg);
                }
            }
        }

        #region commands

        private BaseCommand _ObliczCommand;
        public ICommand ObliczCommand 
        {
            get
            {
                if (_ObliczCommand == null)
                {
                    _ObliczCommand = new BaseCommand(() => obliczUtargClick());
                }
                return _ObliczCommand;
            }
        }

        public IQueryable<KeyAndValue> TowaryComboBoxItems
        { 
            get
            {
                return new TowarB(fakturyEntities).GetAktywneTowary();
            }
        }

        public Faktury2022Entities fakturyEntities { get; set; }
        private void obliczUtargClick() 
        {
            Utarg = new UtargB(fakturyEntities).UtargOkresTowar(_IdTowaru, _dataOd, _dataDo);
        }

        #endregion



        #region Konstruktor
        public RaportSprzedazyViewModel()
        {
            base.DisplayName = "raport sprzedazy";
            fakturyEntities = new Faktury2022Entities();
            DataDo = DateTime.Now;
            DataOd = DateTime.Now;
            IdTowaru = 1;
            Utarg = 0;

        }
        #endregion
    }
}
