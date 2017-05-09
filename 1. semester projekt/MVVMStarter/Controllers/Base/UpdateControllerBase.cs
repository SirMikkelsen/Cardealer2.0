﻿using MVVMStarter.Models.Base;
using MVVMStarter.ViewModels.App;
using MVVMStarter.ViewModels.Base;

namespace MVVMStarter.Controllers.Base
{
    /// <summary>
    /// Generic handler for Update event.
    /// </summary>
    /// <typeparam name="TDomainClass"></typeparam>
    public class UpdateControllerBase<TDomainClass> : ControllerBase<TDomainClass>
        where TDomainClass : DomainClassBase, new()
    {
        public UpdateControllerBase(MasterDetailsViewModelBase<TDomainClass> masterDetailsViewModel, 
                                    CatalogBase<TDomainClass> catalog) 
            : base(masterDetailsViewModel, catalog)
        {
        }

        public override void Execute()
        {
            TDomainClass obj = (TDomainClass)MasterDetailsViewModel.DetailsViewModel.DomainObject.Clone();

            Catalog.Delete(obj.Key);
            Catalog.Insert(obj);
            MasterDetailsViewModel.AfterModelUpdate(obj);
        }

        public override bool CanExecute()
        {
            return (MasterDetailsViewModel.ItemViewModelSelected != null &&
                    MasterDetailsViewModel.ViewState == ViewControlState.ViewState.Update);
        }
    }
}
