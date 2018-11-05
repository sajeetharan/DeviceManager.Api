﻿namespace DeviceManager.Api.Helpers
{
    /// <summary>
    /// All hardcoded strings can be read as properties in the application
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Name of the connection string
        /// </summary>
        public const string DefaultConnection = nameof(DefaultConnection);

        /// <summary>
        /// Connection string section
        /// </summary>
        public const string ConnectionStrings = nameof(ConnectionStrings);

        /// <summary>
        /// Name of the settings section
        /// </summary>
        public const string AppSettings = nameof(AppSettings);

        /// <summary>
        /// 
        /// </summary>
        public const string Database = nameof(Database);

        /// <summary>
        /// 
        /// </summary>
        public const string TenantId = "tenantid";

        /// <summary>
        /// Parameter location
        /// </summary>
        public const string Header = "header";
        
        /// <summary>
        /// Name of the device database tenant 1
        /// </summary>
        public const string DeviceDb = nameof(DeviceDb);

        /// <summary>
        /// Name of the device database tenant 2
        /// </summary>
        public const string DeviceDbTenant2 = "DeviceDb-ten2";

        /// <summary>
        /// Guid of the first tenant
        /// </summary>
        public const string Tenant1Guid = "b0ed668d-7ef2-4a23-a333-94ad278f45d7";

        /// <summary>
        /// Guid of the first tenant
        /// </summary>
        public const string Tenant2Guid = "e7e73238-662f-4da2-b3a5-89f4abb87969";

        /// <summary>
        /// Name of the logging section in the config files
        /// </summary>
        public const string Logging = nameof(Logging);

        /// <summary>
        /// 
        /// </summary>
        public const string Hello = nameof(Hello);

        /// <summary>
        /// Name of the ui culture property in the header
        /// </summary>
        public const string UiCulture = "ui-culture";

        /// <summary>
        /// Name of the culture property in the header
        /// </summary>
        public const string Culture = "culture";

        /// <summary>
        /// Name of the culture property in the header
        /// </summary>
        public const string Query = "query";

        /// <summary>
        /// Name of the culture property in the header
        /// </summary>
        public const string EnglishCulture = "en-US";

        /// <summary>
        /// Name of the culture property in the header
        /// </summary>
        public const string StringInText = "string";
    }
}
