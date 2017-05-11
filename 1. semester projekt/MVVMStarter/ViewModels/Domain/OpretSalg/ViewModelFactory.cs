using MVVMStarter.ViewModels.Base;
using OpretSalgClass = MVVMStarter.Models.Domain.OpretSalg.OpretSalg;

namespace MVVMStarter.ViewModels.Domain.OpretSalg
{
    public class ViewModelFactory : ViewModelFactoryBase<OpretSalgClass>
    {
        public override DetailsViewModelBase<OpretSalgClass> CreateDetailsViewModel(OpretSalgClass obj)
        {
            return new DetailsViewModel(obj);
        }

        public override ItemViewModelBase<OpretSalgClass> CreateItemViewModel(OpretSalgClass obj)
        {
            return new ItemViewModel(obj);
        }

        public override MasterViewModelBase<OpretSalgClass> CreateMasterViewModel()
        {
            return new MasterViewModel();
        }
    }
}
