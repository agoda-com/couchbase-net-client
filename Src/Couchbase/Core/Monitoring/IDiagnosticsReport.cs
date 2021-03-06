using System.Collections.Generic;

namespace Couchbase.Core.Monitoring
{
    public interface IDiagnosticsReport
    {
        /// <summary>
        /// Gets the report identifier.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Gets the Diagnostics Report version.
        /// </summary>
        short Version { get; }

        /// <summary>
        /// Gets the SDK identifier.
        /// </summary>
        string Sdk { get; }

        /// <summary>
        /// Gets the services endpoints.
        /// </summary>
        Dictionary<string, IEnumerable<IEndpointDiagnostics>> Services { get; }
    }
}
