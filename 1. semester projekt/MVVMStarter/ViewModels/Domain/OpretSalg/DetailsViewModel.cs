using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.Storage.Pickers.Provider;
using MVVMStarter.Models.App;
using MVVMStarter.Validators.App;
using MVVMStarter.ViewModels.Base;
using OpretSalgClass = MVVMStarter.Models.Domain.OpretSalg.OpretSalg;

namespace MVVMStarter.ViewModels.Domain.OpretSalg
{
    public class DetailsViewModel : DetailsViewModelBase<OpretSalgClass>
    {
        private ObservableCollection<Bil.ItemViewModel> _observableCollectionBil;
        private ObservableCollection<Kunde.ItemViewModel> _observableCollectionKunde;
        private ObservableCollection<Sælger.ItemViewModel> _observableCollectionSælger;

        public DateTimeOffset Dato
        {
            get { return DomainObject.SalgsDato; }
            set
            {
                DomainObject.SalgsDato = value;
                OnPropertyChanged();
            }
        }

        public double Pris
        {
            get { return DomainObject.Pris; }
        }


        public bool BilVask
        {
            get { return DomainObject.BilVask; }
        }

        public ObservableCollection<Bil.ItemViewModel> CollectionBil
        {
            get { return _observableCollectionBil; }
        }

        public ObservableCollection<Kunde.ItemViewModel> CollectionKunde
        {
            get { return _observableCollectionKunde; }
        }
        public ObservableCollection<Sælger.ItemViewModel> CollectionSælger
        {
            get { return _observableCollectionSælger; }
        }

        public Bil.ItemViewModel SelectedBil
        {
            get { return GetBilItemViewModel(DomainObject.BilKey); }
            set
            {
                if (value != null)
                {
                    DomainObject.BilKey = value.DomainObject.Key;
                }
            }
        }
        public Sælger.ItemViewModel SelectedSælger
        {
            get { return GetSælgerItemViewModel(DomainObject.SælgerKey); }
            set
            {
                if (value != null)
                {
                    DomainObject.SælgerKey = value.DomainObject.Key;
                }
            }
        }

        public Kunde.ItemViewModel SelectedKunde
        {
            get { return GetKundeItemViewModel(DomainObject.KundeKey); }
            set
            {
                if (value != null)
                {
                    DomainObject.KundeKey = value.DomainObject.Key;
                }
            }
        }

        private Bil.ItemViewModel GetBilItemViewModel(int Key)
        {
            foreach (var bilItemViewModel in _observableCollectionBil)
            {
                if (bilItemViewModel.DomainObject.Key == Key)
                {
                    return bilItemViewModel;
                }
            }
            return null;
        }

        private Sælger.ItemViewModel GetSælgerItemViewModel(int Key)
        {
            foreach (var SælgerItemViewModel in _observableCollectionSælger)
            {
                if (SælgerItemViewModel.DomainObject.Key == Key)
                {
                    return SælgerItemViewModel;
                }
            }
            return null;
        }

        private Kunde.ItemViewModel GetKundeItemViewModel(int Key)
        {
            foreach (var kundeItemViewModel in _observableCollectionKunde)
            {
                if (kundeItemViewModel.DomainObject.Key == Key)
                {
                    return kundeItemViewModel;
                }
            }
            return null;
        }


        public DetailsViewModel(OpretSalgClass obj) : base(obj)
        {
            _observableCollectionBil = new ObservableCollection<Bil.ItemViewModel>();
            _observableCollectionKunde = new ObservableCollection<Kunde.ItemViewModel>();
            _observableCollectionSælger = new ObservableCollection<Sælger.ItemViewModel>();

            foreach (var bil in FrieBiler())
            {
                _observableCollectionBil.Add(new Bil.ItemViewModel(bil));
            }
            foreach (var sælger in ObjectProvider.SælgerCatalog.All)
            {
                _observableCollectionSælger.Add(new Sælger.ItemViewModel(sælger));
            }

            foreach (var kunde in ObjectProvider.KundeCatalog.All)
            {
                _observableCollectionKunde.Add(new Kunde.ItemViewModel(kunde));
            }
        }

        List<Models.Domain.Bil.Bil> FrieBiler()
        {
            List<Models.Domain.Bil.Bil> biler = new List<Models.Domain.Bil.Bil>();

            foreach (var bil in ObjectProvider.BilCatalog.All)
            {
                if (!BilErSolgt(bil))
                {
                    biler.Add(bil);
                }
            }

            return biler;
        }

        bool BilErSolgt(Models.Domain.Bil.Bil enBil)
        {
            foreach (var salg in ObjectProvider.SalgsCatalog.All)
            {
                if (salg.BilKey == enBil.Key)
                {
                    return true;
                }
            }

            return false;
        }

        public int FakturaNr
        {
            get { return DomainObject.FakturaNr; }
        }
    }
}
