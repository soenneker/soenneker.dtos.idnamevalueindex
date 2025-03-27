using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Soenneker.Dtos.IdNameValueIndex;

/// <summary>
/// A minimal Record type with an Id (string), Name (string), Value (string?), and Index (string?) and maximum JSON compatibility
/// </summary>
public record IdNameValueIndex : IdNameValue.IdNameValue
{
    [JsonPropertyName("index")]
    [JsonProperty("index")]
    public string? Index { get; set; }
}