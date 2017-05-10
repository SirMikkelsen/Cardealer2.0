using MVVMStarter.ViewModels.Base;
using KundeClass = MVVMStarter.Models.Domain.Kunde.Kunde;

namespace MVVMStarter.ViewModels.Domain.Kunde
{
    public class ItemViewModel : ItemViewModelBase<KundeClass>
    {
        //Override any of the below properties, if you wish to
        //replace the default implementation with your own
        //(the below examples contain the default implementation)


        public override string Description
        {
            get { return DomainObject.Email.ToString(); }
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

        public ItemViewModel(KundeClass obj) : base(obj)
        {
        }
    }
}