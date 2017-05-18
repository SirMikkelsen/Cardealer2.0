using MVVMStarter.ViewModels.Base;
using BilClass = MVVMStarter.Models.Domain.Bil.Bil;


namespace MVVMStarter.ViewModels.Domain.Bil
{
    public class ItemViewModel : ItemViewModelBase<BilClass>
    {
        // Override any of the below properties, if you wish to
        // replace the default implementation with your own
        // (the below examples contain the default implementation)
        //
        public override string Description
        {
            get { return DomainObject.StelNr.ToString(); }
        }

        //public override int FontSize
        //{
        //    get { return 18; }
        //}

        //public override string ImageSource
        //{
        //    get { return String.Empty; }
        //}

        //public override int ImageSize
        //{
        //    get { return 80; }
        //}

        //public override bool ImageIsVisible
        //{
        //    get { return true; }
        //}

        public ItemViewModel(BilClass obj) : base(obj)
        {
        }
    }
}
