using MVVMStarter.ViewModels.Base;
using SælgerClass = MVVMStarter.Models.Domain.Sælger.Sælger;


namespace MVVMStarter.ViewModels.Domain.Sælger
{
    public class ViewModelFactory : ViewModelFactoryBase<SælgerClass>
    {
        public override DetailsViewModelBase<SælgerClass> CreateDetailsViewModel(SælgerClass obj)
        {
            return new DetailsViewModel(obj);
        }

        public override ItemViewModelBase<SælgerClass> CreateItemViewModel(SælgerClass obj)
        {
            return new ItemViewModel(obj);
        }

        public override MasterViewModelBase<SælgerClass> CreateMasterViewModel()
        {
            return new MasterViewModel();
        }
    }
}
