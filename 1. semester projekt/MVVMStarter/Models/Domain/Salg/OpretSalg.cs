using System;
using System.Runtime.InteropServices.WindowsRuntime;
using MVVMStarter.Configuration.App;
using MVVMStarter.Models.Base;
using MVVMStarter.Validators.App;

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

