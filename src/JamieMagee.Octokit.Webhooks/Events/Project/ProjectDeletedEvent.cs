namespace JamieMagee.Octokit.Webhooks.Events.Project
{
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Models;

    [WebhookActionType(ProjectActionValue.Deleted)]
    public sealed record ProjectDeletedEvent : ProjectEvent
    {
        [JsonPropertyName("action")]
        public override string Action => ProjectAction.Deleted;
    }
}