using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
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
        private int _stelNr;
        private double _pris;

        List< string>  type = new List<string>();

        public void  AddType ()
        {
            type.Add("Sport");
            type.Add("Coupe");
            type.Add("Sedan");
        }

        


            
          
        

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




        public int StelNr
        {
            get { return _stelNr; }
            set { _stelNr = value; }
            
        }

        public double Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }



        public override void SetDefaultValues()
        {
            _brand = "BMW";
            _model = "M3";
            _type = "Person bil";
            _farve = "Sort";
            _stelNr = 88273273;
        }
    }
}

