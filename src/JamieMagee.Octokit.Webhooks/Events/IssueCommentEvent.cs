﻿namespace JamieMagee.Octokit.Webhooks.Events
{
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Converter;
    using JamieMagee.Octokit.Webhooks.Models;
    using JetBrains.Annotations;

    [PublicAPI]
    [WebhookEventType(WebhookEventType.IssueComment)]
    [JsonConverter(typeof(WebhookConverter<IssueCommentEvent>))]
    public abstract record IssueCommentEvent : WebhookEvent
    {
        [JsonPropertyName("issue")]
        public Issue Issue { get; init; }

        [JsonPropertyName("comment")]
        public Models.IssueComment Comment { get; init; }
    }
}
