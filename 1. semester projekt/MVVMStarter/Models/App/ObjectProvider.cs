using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMStarter.Models.App
{
    class ObjectProvider
    {
        public static Domain.Bil.Catalog BilCatalog
        {
            get { return Domain.Bil.Catalog.Instance; }
        }

        public static Domain.Kunde.Catalog KundeCatalog
        {
            get { return Domain.Kunde.Catalog.Instance; }
        }

        public static Domain.OpretSalg.Catalog SalgsCatalog
        {
            get { return Domain.OpretSalg.Catalog.Instance; }
        }
    }
}
