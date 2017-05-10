using MVVMStarter.Validators.App;
using MVVMStarter.ViewModels.Base;
using KundeClass = MVVMStarter.Models.Domain.Kunde.Kunde;

namespace MVVMStarter.ViewModels.Domain.Kunde
{
    public class DetailsViewModel : DetailsViewModelBase<KundeClass>
    {
        //// Template for validated property (may throw ValidationException) 
        //public string MyValidatedProperty
        //{
        //    get { return DomainObject.MyValidatedProperty; }
        //    set
        //    {
        //        var orgValue = DomainObject.MyValidatedProperty;
        //        try
        //        {
        //            DomainObject.MyValidatedProperty = value;
        //        }
        //        catch (ValidationException e)
        //        {
        //            PresentValidationError(e.Message, () => { MyValidatedProperty = orgValue; });
        //        }
        //        OnPropertyChanged();
        //    }
        //}

        //// Template for non-validated property
        public int KørekortNr
        {
            get { return DomainObject.KørekortNr; }
            set
            {
                DomainObject.KørekortNr = value;
                OnPropertyChanged();
            }
        }

        public int KreditkortNr
        {
            get { return DomainObject.KreditkortNr; }
            set
            {
                DomainObject.KreditkortNr = value;
                OnPropertyChanged();
            }
        }

        public int RegistreringsNr
        {
            get { return DomainObject.RegistreringsNr; }
            set
            {
                DomainObject.RegistreringsNr = value;
                OnPropertyChanged();
            }
        }

        public DetailsViewModel(KundeClass obj) : base(obj)
        {
        }
    }
}
