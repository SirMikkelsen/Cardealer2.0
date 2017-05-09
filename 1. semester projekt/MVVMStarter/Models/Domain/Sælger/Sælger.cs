using MVVMStarter.Configuration.App;
using MVVMStarter.Models.Base;
using MVVMStarter.Validators.App;


namespace MVVMStarter.Models.Domain.Sælger
{
    public class Sælger : DomainClassBase
    {

        private int _id;
        private double _kommission;


        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }


        public double Kommission
        {
            get { return _kommission; }
            set { _kommission = value; }
        }


        public override void SetDefaultValues()
        {
            // Set default values for properties here
        }
    }
}

