﻿using MVVMStarter.Models.Base;
using MVVMStarter.Persistency.Base;

namespace MVVMStarter.Models.Domain.Kunde
{
    public class Catalog : CatalogBase<Kunde>
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
        private Catalog() : base(new CollectionBase<Kunde>(), new FileSourceBase<Kunde>())
        {
        }
        #endregion
    }
}