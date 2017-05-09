using MVVMStarter.Configuration.App;
using MVVMStarter.Models.Base;
using MVVMStarter.Validators.App;


namespace MVVMStarter.Models.Domain.Bil
{
    public class Bil : DomainClassBase
    {

        private string _brand;
        private string _model;
        private string _type;
        private string _farve;
        private int _idNummer;



        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }


        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }


      
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }


        public string Farve
        {
            get { return _farve; }
            set { _farve = value; }
        }




        public int IDnummer
        {
            get { return _idNummer; }
            set { _idNummer = value; }
            
        }



        public override void SetDefaultValues()
        {
            _brand = "BMW";
            _model = "M3";
            _type = "Person bil";
            _farve = "Sort";
            _idNummer = 88273273;
        }
    }
}

