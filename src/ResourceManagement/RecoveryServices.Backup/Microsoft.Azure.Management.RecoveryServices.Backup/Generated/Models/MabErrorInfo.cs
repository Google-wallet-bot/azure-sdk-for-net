// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// MAB workload-specific error information.
    /// </summary>
    public partial class MabErrorInfo
    {
        /// <summary>
        /// Initializes a new instance of the MabErrorInfo class.
        /// </summary>
        public MabErrorInfo() { }

        /// <summary>
        /// Initializes a new instance of the MabErrorInfo class.
        /// </summary>
        /// <param name="errorString">Localized error string.</param>
        /// <param name="recommendations">List of localized
        /// recommendations.</param>
        public MabErrorInfo(string errorString = default(string), System.Collections.Generic.IList<string> recommendations = default(System.Collections.Generic.IList<string>))
        {
            ErrorString = errorString;
            Recommendations = recommendations;
        }

        /// <summary>
        /// Gets or sets localized error string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "errorString")]
        public string ErrorString { get; set; }

        /// <summary>
        /// Gets or sets list of localized recommendations.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recommendations")]
        public System.Collections.Generic.IList<string> Recommendations { get; set; }

    }
}
