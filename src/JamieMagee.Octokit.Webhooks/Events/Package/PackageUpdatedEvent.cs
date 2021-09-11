namespace JamieMagee.Octokit.Webhooks.Events.Package
{
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Models;

    public sealed record PackageUpdatedEvent : PackageEvent
    {
        [JsonPropertyName("action")]
        public override string Action => PackageAction.Updated;
    }
}
