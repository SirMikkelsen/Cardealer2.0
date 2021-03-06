﻿using MVVMStarter.Validators.App;
using MVVMStarter.ViewModels.Base;
using KundeClass = MVVMStarter.Models.Domain.Kunde.Kunde;

namespace MVVMStarter.ViewModels.Domain.Kunde
{
    public class DetailsViewModel : DetailsViewModelBase<KundeClass>
    {
        //// Template for validated property (may throw ValidationException) 
        //public string MyValidatedProperty
        //{
        //    get { return DomainObject.MyValidatedProperty; }
        //    set
        //    {
        //        var orgValue = DomainObject.MyValidatedProperty;
        //        try
        //        {
        //            DomainObject.MyValidatedProperty = value;
        //        }
        //        catch (ValidationException e)
        //        {
        //            PresentValidationError(e.Message, () => { MyValidatedProperty = orgValue; });
        //        }
        //        OnPropertyChanged();
        //    }
        //}

        //// Template for non-validated property
        public int KørekortNr
        {
            get { return DomainObject.KørekortNr; }
            set
            {
                DomainObject.KørekortNr = value;
                OnPropertyChanged();
            }
        }

        public int KontoNr
        {
            get { return DomainObject.KontoNr; }
            set
            {
                DomainObject.KontoNr = value;
                OnPropertyChanged();
            }
        }

        public int RegistreringsNr
        {
            get { return DomainObject.RegistreringsNr; }
            set
            {
                DomainObject.RegistreringsNr = value;
                OnPropertyChanged();
            }
        }

        public string Navn
        {
            get { return DomainObject.Navn; }
            set
            {
                DomainObject.Navn = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return DomainObject.Email; }
            set
            {
                DomainObject.Email = value;
                OnPropertyChanged();
            }
        }

        public int TlfNr
        {
            get { return DomainObject.TlfNr; }
            set
            {
                DomainObject.TlfNr = value;
                OnPropertyChanged();
            }
        }

        public DetailsViewModel(KundeClass obj) : base(obj)
        {
        }
    }
}
