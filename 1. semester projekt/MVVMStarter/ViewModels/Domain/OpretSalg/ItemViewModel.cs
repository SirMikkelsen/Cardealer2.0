using System.Dynamic;
using MVVMStarter.Models.App;
using MVVMStarter.ViewModels.Base;
using OretSalgClass = MVVMStarter.Models.Domain.OpretSalg.OpretSalg;
using BilClass = MVVMStarter.Models.Domain.Bil.Bil;
using KundeClass = MVVMStarter.Models.Domain.Kunde.Kunde;

namespace MVVMStarter.ViewModels.Domain.OpretSalg
{
    public class ItemViewModel : ItemViewModelBase<OretSalgClass>
    {
        // Override any of the below properties, if you wish to
        // replace the default implementation with your own
        // (the below examples contain the default implementation)
        //
        public override string Description
        {
            get { return GetKunde().Navn + " " + GetBil().Brand + " " + GetBil().Model; }
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

        private BilClass GetBil()
        {
            return ObjectProvider.BilCatalog.Read(DomainObject.BilKey);
        }
        private KundeClass GetKunde()
        {
            return ObjectProvider.KundeCatalog.Read(DomainObject.KundeKey);
        }


        public ItemViewModel(OretSalgClass obj) : base(obj)
        {
        }
    }
}
