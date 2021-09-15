﻿namespace JamieMagee.Octokit.Webhooks.Events
{
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Converter;
    using JetBrains.Annotations;

    // TODO: Undocumented event

    [PublicAPI]
    [WebhookEventType(WebhookEventType.DeploymentReview)]
    [JsonConverter(typeof(WebhookConverter<DeploymentReviewEvent>))]
    public abstract record DeploymentReviewEvent : WebhookEvent;
}
