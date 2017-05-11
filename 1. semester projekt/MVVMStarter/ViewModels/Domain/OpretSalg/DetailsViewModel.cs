using System;
using System.Collections.ObjectModel;
using Windows.Storage.Pickers.Provider;
using MVVMStarter.Validators.App;
using MVVMStarter.ViewModels.Base;
using OpretSalgClass = MVVMStarter.Models.Domain.OpretSalg.OpretSalg;

/// <summary>
/// TEMPLATE: You must 
/// 1) Create a file called DetailsViewModel.cs in your domain folder (under ViewModel/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
/// </summary>
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

        public int Slutpris
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
            get{return GetBilItemViewModel(DomainObject.BilKey);}
            set
            {
                if (value != null)
                {
                    DomainObject.BilKey = value.DomainObject.Key;
                }
            }
                
            
        }

        public DetailsViewModel(OpretSalgClass obj) : base(obj)
        {
        }
    }
}
