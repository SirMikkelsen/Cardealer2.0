using System.Collections.Generic;
using MVVMStarter.ViewModels.App;
using MVVMStarter.ViewModels.Base;
using SælgerClass = MVVMStarter.Models.Domain.Sælger.Sælger;


namespace MVVMStarter.ViewModels.Domain.Sælger
{
    public class MasterDetailsViewModel : MasterDetailsViewModelBase<SælgerClass>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), Models.Domain.Sælger.Catalog.Instance)
        {
            //// Use the below code as a template for setting up default
            //// behavior for your GUI controls

            List<string> fixedProperties = new List<string>();
            // Add names of "fixed" (cannot be changed after creation) properties here
            fixedProperties.Add("ID");

            List<string> nonFixedKeyProperties = new List<string>();
            // Add names of "non-fixed" (can be changed after creation) properties here
            nonFixedKeyProperties.Add("Kommission");
            nonFixedKeyProperties.Add("Navn");
            nonFixedKeyProperties.Add("Email");
            nonFixedKeyProperties.Add("TlfNr");

            StateManager.AddFixedPropertiesDefaultStates(fixedProperties);
            StateManager.AddNonFixedPropertiesDefaultStates(nonFixedKeyProperties);
            StateManager.AddButtonDefaultStates();
        }
    }
}
