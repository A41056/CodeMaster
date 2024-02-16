namespace CodeMaster.Core.Entities.Notification
{
    public partial class Notification
    {
        public Guid Id { get; set; }

        public short Status { get; set; }

        public DateTime DatetimeTrigger { get; set; }

        public Guid? ImageFileId { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public string FullTextSearch { get; set; }

        public virtual ICollection<NotificationTranslation> NotificationTranslations { get; set; } = new List<NotificationTranslation>();
    }
}
