using static System.Environment;

namespace Azure.Storage.Connection.GetConnectionString
{
    /// <summary>Function returns the AZURE_STORAGE_CONNECTION_STRING environment variable value</summary>
    public static class ConnectionStringGetter
    {
        /// <summary>Name of the environment variable containing the Azure Storage connection string</summary>
        private const string EnvironmentVariableName = "AZURE_STORAGE_CONNECTION_STRING";

        /// <summary>Returns the AZURE_STORAGE_CONNECTION_STRING environment variable value</summary>
        public static string ConnectionString() => GetEnvironmentVariable(EnvironmentVariableName);
    }
}
