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
namespace MVVMStarter.Models.Domain.Kunde
{
    public class Kunde : DomainClassBase
    {
        private int _kørekortNr;
        private int _kreditkortNr;
        private int _registreringsNr;

        public int KørekortNr
        {
            get { return _kørekortNr; }
            set { _kørekortNr = value; }
        }

        public int KreditkortNr
        {
            get { return _kreditkortNr; }
            set { _kreditkortNr = value; }
        }
        
        public int RegistreringsNr
        {
            get { return _registreringsNr; }
            set { _registreringsNr = value; }
        }



        public override void SetDefaultValues()
        {
            _kørekortNr = (1234567890);
            _kreditkortNr = (132456789);
            _registreringsNr = (1234546789);
        }
    }
}
