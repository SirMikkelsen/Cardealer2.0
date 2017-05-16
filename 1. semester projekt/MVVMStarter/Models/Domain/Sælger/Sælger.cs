using System.Threading;
using MVVMStarter.Configuration.App;
using MVVMStarter.Models.App;
using MVVMStarter.Models.Base;
using MVVMStarter.Validators.App;


namespace MVVMStarter.Models.Domain.Sælger
{
    public class Sælger : PersonBase
    {

        private int _id;
        private double _kommission;
        private int _sælgerKey;


        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public int SælgerKey
        {
            get { return _sælgerKey; }
        }


        public double Kommission
        {
            get
            {
                double totalKommision = 0;
                foreach (var salg in ObjectProvider.SalgsCatalog.All)
                {
                    if (salg.SælgerKey == Key)
                    {
                        if (salg.SlutPris <= 100000)
                        {
                            totalKommision += salg.SlutPris * 0.05;
                        }
                        else if ((salg.SlutPris > 100000) && (salg.SlutPris <= 200000))
                        {
                            totalKommision += salg.SlutPris * 0.07;
                        }
                        else
                        {
                            totalKommision += salg.SlutPris * 0.10;
                        }

                    }
                    
                }

                return totalKommision;

        }

    }


    public override void SetDefaultValues()
        {
            Navn = "(Navn)";
            Email = "(Email)";
            TlfNr = (12345678);
            // Set default values for properties here
        }
    }
}

