using MVVMStarter.ViewModels.Base;
using BilClass = MVVMStarter.Models.Domain.Bil.Bil;


namespace MVVMStarter.ViewModels.Domain.Bil
{
    public class ViewModelFactory : ViewModelFactoryBase<BilClass>
    {
        public override DetailsViewModelBase<BilClass> CreateDetailsViewModel(BilClass obj)
        {
            return new DetailsViewModel(obj);
        }

        public override ItemViewModelBase<BilClass> CreateItemViewModel(BilClass obj)
        {
            return new ItemViewModel(obj);
        }

        public override MasterViewModelBase<BilClass> CreateMasterViewModel()
        {
            return new MasterViewModel();
        }
    }
}
