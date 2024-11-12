using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Soenneker.Dtos.IdNameValueIndex;

/// <summary>
/// A minimal Record type with an Id (string), Name (string), Value (string?), and Index (string?) and maximum JSON compatibility
/// </summary>
[DataContract]
public record IdNameValueIndex : IdNameValue.IdNameValue
{
    [DataMember(Name = "index")]
    [JsonPropertyName("index")]
    [JsonProperty("index")]
    public string? Index { get; set; }
}