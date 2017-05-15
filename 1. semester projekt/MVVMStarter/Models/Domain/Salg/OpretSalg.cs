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
        private double _kommisionPrMåned;
        private double _salgPrMåned;
        private double _kommission;

        public double KommissionPrMåned
        {
            get { return _kommisionPrMåned; }
            set { _kommisionPrMåned = value; }
        }

        public double SalgPrMåned
        {
            get { return _salgPrMåned; }
            set { _salgPrMåned = value; }
        }

        public double Kommission
        {
            get { return _kommission; }
            set { _kommission = value; }
        }

        private DateTimeOffset _salgsdato;
        private int _slutpris;


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

        public double KommissionBeregning()
        {
            if (SalgPrMåned >= 100000)
            {
                KommissionPrMåned = SalgPrMåned * 1.05;
            }
            else
            {
                if ((SalgPrMåned < 100000) && (SalgPrMåned <= 200000))
                {
                    KommissionPrMåned = SalgPrMåned * 1.07;
                }
                else
                {
                    if (SalgPrMåned > 200000)
                    {
                        Kommission = SalgPrMåned * 1.10;
                    }
                }
            }
            return 0;
        }
    }
}

