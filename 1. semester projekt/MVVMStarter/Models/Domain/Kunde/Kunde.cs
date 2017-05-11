using MVVMStarter.Configuration.App;
using MVVMStarter.Models.Base;
using MVVMStarter.Validators.App;

namespace MVVMStarter.Models.Domain.Kunde
{
    public class Kunde : PersonBase
    {
        private int _kørekortNr;
        private int _kontoNr;
        private int _registreringsNr;

        public int KørekortNr
        {
            get { return _kørekortNr; }
            set { _kørekortNr = value; }
        }

        public int KontoNr
        {
            get { return _kontoNr; }
            set { _kontoNr = value; }
        }
        
        public int RegistreringsNr
        {
            get { return _registreringsNr; }
            set { _registreringsNr = value; }
        }



        public override void SetDefaultValues()
        {
            Navn = "(Navn)";
            Email = "(E-Mail)";
            TlfNr = (12345678);
            _kørekortNr = (1234567890);
            _kontoNr = (132456789);
            _registreringsNr = (1234546789);
        }
    }
}
