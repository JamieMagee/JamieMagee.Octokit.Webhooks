﻿namespace Octokit.Webhooks;

[PublicAPI]
public abstract record WebhookEvent
{
    [JsonPropertyName("action")]
    public virtual string? Action { get; init; }

    [JsonPropertyName("repository")]
    public Repository? Repository { get; init; }

    [JsonPropertyName("installation")]
    public InstallationLite? Installation { get; init; }

    [JsonPropertyName("organization")]
    public Organization? Organization { get; init; }

    [JsonPropertyName("sender")]
    public User? Sender { get; init; }

    /// <summary>
    /// Gets any additional properties that were not mapped to a strongly-typed property on the event.
    /// </summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; init; }
}
