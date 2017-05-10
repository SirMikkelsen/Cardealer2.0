using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMStarter.Models.Base
{
   public class PersonBase : DomainClassBase
    {
        private string _navn;
        private string _email;
        private int _tlfNr;


        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
        public string Email

        {
            get { return _email; }
            set { _email = value; }
        }

        public int  TlfNr
        {
            get { return _tlfNr; }
            set { _tlfNr = value; }
        }



        public override void SetDefaultValues()
        {
            throw new NotImplementedException();
        }
    }
}
