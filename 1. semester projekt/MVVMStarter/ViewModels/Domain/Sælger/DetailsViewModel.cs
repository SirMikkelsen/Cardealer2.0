using MVVMStarter.Validators.App;
using MVVMStarter.ViewModels.Base;
using SælgerClass = MVVMStarter.Models.Domain.Sælger.Sælger;


namespace MVVMStarter.ViewModels.Domain.Sælger
{
    public class DetailsViewModel : DetailsViewModelBase<SælgerClass>
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
        //public string MyNonValidatedProperty
        //{
        //    get { return DomainObject.MyNonValidatedProperty; }
        //    set
        //    {
        //        DomainObject.MyNonValidatedProperty = value;
        //        OnPropertyChanged();
        //    }
        //}


        //public double Kommission
        //{
        //    get { return _kommission; }
        //    set { _kommission = value; }
        //}

        public int ID
        {
            get { return DomainObject.ID; }
            set
            {
                DomainObject.ID = value;
                OnPropertyChanged();
                
            }
        }

        public double Kommission
        {
            get { return DomainObject.Kommission; }
            set
            {
                DomainObject.Kommission = value;
                OnPropertyChanged();
            }
        }
        public DetailsViewModel(SælgerClass obj) : base(obj)
        {
        }
    }
}
