using System;
using System.Runtime.InteropServices.WindowsRuntime;
using MVVMStarter.Configuration.App;
using MVVMStarter.Models.App;
using MVVMStarter.Models.Base;
using MVVMStarter.Validators.App;

namespace MVVMStarter.Models.Domain.OpretSalg
{
    public class OpretSalg : DomainClassBase
    {

        private int _bilkey;
        private int _kundekey;
        private int _sælgerkey;
        private DateTimeOffset _salgsdato;


        public int SælgerKey
        {
            get { return _sælgerkey; }
            set { _sælgerkey = value; }
        }

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

        public double SlutPris
        {
            get
            {
                Bil.Bil solgtBil = ObjectProvider.BilCatalog.Read(_bilkey);

                if (solgtBil != null)
                {
                    return solgtBil.Pris;
                }
                else
                {
                    return 0;
                }
            }
           

        }

        public override void SetDefaultValues()
        {
            _bilkey = NullKey;
            _kundekey = NullKey;

            _salgsdato = DateTimeOffset.Now;
        }
    }
}

