using MVVMStarter.Validators.App;
using MVVMStarter.ViewModels.Base;
using BilClass = MVVMStarter.Models.Domain.Bil.Bil;


namespace MVVMStarter.ViewModels.Domain.Bil
{
    public class DetailsViewModel : DetailsViewModelBase<BilClass>
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



            /// lav vidre.
        // Template for non-validated propeBrty
        public string Brand
        {
            get { return DomainObject.Brand; }
            set
            {
                DomainObject.Brand = value;
                OnPropertyChanged();
            }
        }



        public string Model
        {
            get { return DomainObject.Model; }
            set
            {
                DomainObject.Model = value;
                OnPropertyChanged();
                
            }
        }

        public string Type
        {
            get { return DomainObject.Type; }
            set
            {
                DomainObject.Type = value;
                OnPropertyChanged();

            }
        }

        public string Farve
        {
            get { return DomainObject.Farve; }
            set
            {
                DomainObject.Farve = value;
                OnPropertyChanged();

            }
        }

        public int IDnummer
        {
            get { return DomainObject.IDnummer; }
            set
            {
                DomainObject.IDnummer = value;
                OnPropertyChanged();
            }
        }

        public DetailsViewModel(BilClass obj) : base(obj)
        {
        }
    }
}
