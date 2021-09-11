namespace JamieMagee.Octokit.Webhooks.Events.Label
{
    public sealed class LabelAction : WebhookEventAction
    {
        public static readonly LabelAction Created = new(LabelActionValue.Created);

        public static readonly LabelAction Deleted = new(LabelActionValue.Deleted);

        public static readonly LabelAction Edited = new(LabelActionValue.Edited);

        private LabelAction(string value)
            : base(value)
        {
        }
    }
}
