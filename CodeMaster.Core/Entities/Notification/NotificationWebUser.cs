namespace CodeMaster.Core.Entities.Notification
{
    public partial class NotificationWebUser
    {
        public Guid NotificationId { get; set; }

        public Guid WebUserId { get; set; }

        public bool IsRead { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }
    }
}
