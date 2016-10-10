// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{

    /// <summary>
    /// Defines values for OperationStatusValues.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OperationStatusValues
    {
        [System.Runtime.Serialization.EnumMember(Value = "Invalid")]
        Invalid,
        [System.Runtime.Serialization.EnumMember(Value = "InProgress")]
        InProgress,
        [System.Runtime.Serialization.EnumMember(Value = "Succeeded")]
        Succeeded,
        [System.Runtime.Serialization.EnumMember(Value = "Failed")]
        Failed,
        [System.Runtime.Serialization.EnumMember(Value = "Canceled")]
        Canceled
    }
}
