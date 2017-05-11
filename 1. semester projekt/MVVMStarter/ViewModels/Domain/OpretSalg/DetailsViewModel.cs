using System;
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

        public DateTimeOffset Dato
        {
            get { return DomainObject.SalgsDato; }
            set
            {
                DomainObject.SalgsDato = value;
                OnPropertyChanged();
            }
        }

        public int SlutPris
        {
            get { return DomainObject.SlutPris; }
            set
            {
                DomainObject.SlutPris = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Bil.ItemViewModel> CollectionBil
        {
            get { return _observableCollectionBil; }
        }

        public ObservableCollection<Kunde.ItemViewModel> CollectionKunde
        {
            get { return _observableCollectionKunde; }
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

            foreach (var bil in ObjectProvider.BilCatalog.All)
            {
                _observableCollectionBil.Add(new Bil.ItemViewModel(bil));
            }

            foreach (var kunde in ObjectProvider.KundeCatalog.All)
            {
                _observableCollectionKunde.Add(new Kunde.ItemViewModel(kunde));
            }
        }
    }
}
