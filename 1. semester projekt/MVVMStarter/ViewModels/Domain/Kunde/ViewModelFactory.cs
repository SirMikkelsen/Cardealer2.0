using MVVMStarter.ViewModels.Base;
using KundeClass = MVVMStarter.Models.Domain.Kunde.Kunde;

namespace MVVMStarter.ViewModels.Domain.Kunde
{
    public class ViewModelFactory : ViewModelFactoryBase<KundeClass>
    {
        public override DetailsViewModelBase<KundeClass> CreateDetailsViewModel(KundeClass obj)
        {
            return new DetailsViewModel(obj);
        }

        public override ItemViewModelBase<KundeClass> CreateItemViewModel(KundeClass obj)
        {
            return new ItemViewModel(obj);
        }

        public override MasterViewModelBase<KundeClass> CreateMasterViewModel()
        {
            return new MasterViewModel();
        }
    }
}
