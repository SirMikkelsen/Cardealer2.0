using System;
using System.Runtime.InteropServices.WindowsRuntime;
using MVVMStarter.Configuration.App;
using MVVMStarter.Models.Base;
using MVVMStarter.Validators.App;

/// <summary>
/// TEMPLATE: You must 
/// 1) Create a file called _REPLACEME_.cs in your domain folder (under Model/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
/// </summary>
namespace MVVMStarter.Models.Domain.OpretSalg
{
    public class OpretSalg : DomainClassBase
    {

        private int _bilkey;
        private int _kundekey;

        private DateTimeOffset _salgsdato;
        private int _slutpris;

        public void Salg()
        {
            SetDefaultValues();
        }

        public int BilKey
        {
            get { return _bilkey; }
            set { _bilkey = value; }
        
        }
        public int KundeKey
        {
            get { return _kundekey; }
            set { _kundekey = value; }

        }

        public DateTimeOffset SalgsDato
        {
            get { return _salgsdato; }
            set { _salgsdato = value; }

        }

        public int SlutPris
        {
            get { return _slutpris; }
            set { _slutpris = value; }

        }

        public override void SetDefaultValues()
        {
            _bilkey = NullKey;
            _kundekey = NullKey;

            _salgsdato = DateTimeOffset.Now;
            _slutpris = 0;
        }
    }
}

