﻿using System.Collections.Generic;
using MVVMStarter.Models.App;
using MVVMStarter.ViewModels.App;
using MVVMStarter.ViewModels.Base;
using OpretSalgClass = MVVMStarter.Models.Domain.OpretSalg.OpretSalg;

/// <summary>
/// TEMPLATE: You must 
/// 1) Create a file called MasterDetailsViewModel.cs in your domain folder (under ViewModel/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
namespace MVVMStarter.ViewModels.Domain.OpretSalg
{
    public class MasterDetailsViewModel : MasterDetailsViewModelBase<OpretSalgClass>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), ObjectProvider.SalgsCatalog)
        {
            //// Use the below code as a template for setting up default
            //// behavior for your GUI controls

            List<string> fixedProperties = new List<string>();
            // Add names of "fixed" (cannot be changed after creation) properties here
            fixedProperties.Add("Bil");
            fixedProperties.Add("Kunde");

            //List<string> nonFixedKeyProperties = new List<string>();
            //// Add names of "non-fixed" (can be changed after creation) properties here
            nonFixedKeyProperties.Add("dato");
            nonFixedKeyProperties.Add("pris");

            StateManager.AddFixedPropertiesDefaultStates(fixedProperties);
            StateManager.AddNonFixedPropertiesDefaultStates(nonFixedKeyProperties);
            StateManager.AddButtonDefaultStates();
        }
    }
}
