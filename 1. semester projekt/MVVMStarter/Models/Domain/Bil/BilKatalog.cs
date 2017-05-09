using MVVMStarter.Models.Base;
using MVVMStarter.Persistency.Base;


namespace MVVMStarter.Models.Domain.Bil
{
    public class Catalog : CatalogBase<Bil>
    {
        #region Model Singleton implementation
        private static Catalog _instance = null;

        public static Catalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new Catalog();
                return _instance;
            }
        }

        /// <summary>
        /// Use a file-based persistent source
        /// </summary>
        private Catalog() : base(new CollectionBase<Bil>(), new FileSourceBase<Bil>())
        {
        }
        #endregion
    }
}
