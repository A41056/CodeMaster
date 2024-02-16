namespace CodeMaster.Core.Entities.LiveClass
{
    public partial class LiveLessonDetailAttendance
    {
        public Guid LiveLessonDetailId { get; set; }

        public Guid LiveClassBookingId { get; set; }

        public Guid WebUserId { get; set; }

        public string LessonLinkUrl { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }
    }
}
