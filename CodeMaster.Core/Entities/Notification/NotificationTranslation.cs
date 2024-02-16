namespace CodeMaster.Core.Entities.Notification
{
    public partial class NotificationTranslation
    {
        public string LanguageCode { get; set; }

        public Guid NotificationId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string LinkUrl { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual LanguageTag Language { get; set; }

        public virtual Notification Notification { get; set; }
    }
}
