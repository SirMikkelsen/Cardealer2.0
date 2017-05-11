 using System.Collections.Generic;
using MVVMStarter.ViewModels.App;
using MVVMStarter.ViewModels.Base;
using BilClass = MVVMStarter.Models.Domain.Bil.Bil;


namespace MVVMStarter.ViewModels.Domain.Bil
{
    public class MasterDetailsViewModel : MasterDetailsViewModelBase<BilClass>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), Models.Domain.Bil.Catalog.Instance)
        {
            //// Use the below code as a template for setting up default
            //// behavior for your GUI controls

            List<string> fixedProperties = new List<string>();

            List<string> nonFixedKeyProperties = new List<string>();
            // Add names of "non-fixed" (can be changed after creation) properties here
            nonFixedKeyProperties.Add(nameof(BilClass.Brand));
            nonFixedKeyProperties.Add(nameof(BilClass.Farve));
            nonFixedKeyProperties.Add(nameof(BilClass.StelNr));
            nonFixedKeyProperties.Add(nameof(BilClass.Model));
            nonFixedKeyProperties.Add(nameof(BilClass.Type));
            nonFixedKeyProperties.Add(nameof(BilClass.Pris));


            StateManager.AddFixedPropertiesDefaultStates(fixedProperties);
            StateManager.AddNonFixedPropertiesDefaultStates(nonFixedKeyProperties);
            StateManager.AddButtonDefaultStates();
        }
    }
}
