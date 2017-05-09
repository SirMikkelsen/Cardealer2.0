﻿namespace MVVMStarter.Configuration.App
{
    /// <summary>
    /// Contains application-wide configuration values
    /// (This could be a suitable point for dependency-injection)
    /// </summary>
    public static class AppConfig
    {
        /// <summary>
        /// Application-wide constants
        /// </summary>
        public const string ImageFilePrefix = "..\\..\\..\\Assets\\Domain\\";
        public const string ImageFilePostfix = ".jpg";

        public delegate void SourceDelegate();
        public static SourceDelegate LoadModels = null;
        public static SourceDelegate SaveModels = null;

        /// <summary>
        /// Sets up all models to be included in Load and Save operations
        /// </summary>
        public static void Setup()
        {
            // Add Load and Save methods for new domain classes here
            LoadModels += Models.Domain.Photo.Catalog.Instance.Load;
            SaveModels += Models.Domain.Photo.Catalog.Instance.Save;

            LoadModels += Models.Domain.Pair.Catalog.Instance.Load;
            SaveModels += Models.Domain.Pair.Catalog.Instance.Save;

            LoadModels += Models.Domain.Student.Catalog.Instance.Load;
            SaveModels += Models.Domain.Student.Catalog.Instance.Save;

            LoadModels += Models.Domain.Bil.Catalog.Instance.Load;
            SaveModels += Models.Domain.Bil.Catalog.Instance.Save;

            LoadModels += Models.Domain.Sælger.Catalog.Instance.Load;
            SaveModels += Models.Domain.Sælger.Catalog.Instance.Save;

        }

        /// <summary>
        /// Loads all models from persistent storage.
        /// </summary>
        public static void Load()
        {
            LoadModels?.Invoke();
        }

        /// <summary>
        /// Saves all models to persistent storage.
        /// </summary>
        public static void Save()
        {
            SaveModels?.Invoke();
        }
    }
}
