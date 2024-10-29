namespace Mobius.Models.GameLibrary.Jobs;

public class UserTag
{
    [JsonPropertyName("tagid")]
    public int TagId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
