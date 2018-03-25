// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

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
