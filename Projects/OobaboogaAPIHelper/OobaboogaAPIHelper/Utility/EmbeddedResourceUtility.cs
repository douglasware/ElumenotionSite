using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace Utilty
{
    /// <summary>
    /// An abstract base class that provides methods for deserializing an object from an embedded resource
    /// </summary>
    public class EmbeddedResourceUtility
    {
        /// <summary>
        /// Deserializes an object of type T from an embedded resource with the given name.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize.</typeparam>
        /// <param name="resourceName">The name of the embedded resource containing the JSON data.</param>
        /// <returns>An instance of type T deserialized from the embedded resource.</returns>
        /// <exception cref="System.InvalidOperationException">Thrown when the resourceName is not found.</exception>
        /// <exception cref="System.Text.Json.JsonException">Thrown when deserialization fails.</exception>
        public static T GetObjectFromResource<T>(string resourceName)
        {
            Trace.TraceInformation($"GetObjectFromResource called with resourceName '{resourceName}'.");

            // Search for the resource in all loaded assemblies
            string json = null;
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                if (!assembly.IsDynamic)
                {
                    using (var resourceStream = assembly.GetManifestResourceStream(resourceName))
                    {
                        if (resourceStream != null)
                        {
                            using (StreamReader reader = new StreamReader(resourceStream))
                            {
                                json = reader.ReadToEnd();
                                Trace.TraceInformation($"JSON data successfully read from resourceName '{resourceName}'.");
                            }
                        }
                    }
                }
            }

            if (json == null)
            {
                Trace.TraceError($"ResourceName '{resourceName}' not found.");
                throw new InvalidOperationException($"ResourceName '{resourceName}' not found.");
            }

            try
            {
                T obj = JsonSerializer.Deserialize<T>(json);
                Trace.TraceInformation($"GetObjectFromResource successfully deserialized object of type '{typeof(T)}' from resourceName '{resourceName}'.");
                return obj;
            }
            catch (Exception ex)
            {
                // Log the error
                Trace.TraceError($"Deserialization failed for resourceName '{resourceName}'. Exception: {ex.ToString()}");
                throw;
            }
        }

        /// <summary>
        /// Reads a string embedded resource with the given name.
        /// </summary>
        /// <param name="resourceName">The name of the embedded resource containing the JSON data.</param>
        /// <returns>An string from the embedded resource.</returns>
        /// <exception cref="System.InvalidOperationException">Thrown when the resourceName is not found.</exception>
        public static string GetStringFromResource(string resourceName)
        {
            Trace.TraceInformation($"GetStringFromResource called with resourceName '{resourceName}'.");

            // Search for the resource in all loaded assemblies
            string result = null;
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                if (!assembly.IsDynamic)
                {
                    using (var resourceStream = assembly.GetManifestResourceStream(resourceName))
                    {
                        if (resourceStream != null)
                        {
                            using (StreamReader reader = new StreamReader(resourceStream))
                            {
                                result = reader.ReadToEnd();
                                Trace.TraceInformation($"JSON data successfully read from resourceName '{resourceName}'.");
                            }
                        }
                    }
                }
            }

            if (result == null)
            {
                Trace.TraceError($"ResourceName '{resourceName}' not found.");
                throw new InvalidOperationException($"ResourceName '{resourceName}' not found.");
            }

            return result;
        }
    }
}
