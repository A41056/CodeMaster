using CodeMaster.Core.Entities.Auth;

namespace CodeMaster.Core.Entities.LiveClass
{
    public partial class LiveLessonDetailAdviser
    {
        public Guid LiveLessonDetailId { get; set; }

        public Guid AdminUserId { get; set; }

        public string LessonLinkUrl { get; set; }

        public virtual AdminUser AdminUser { get; set; }

        public virtual LiveLessonDetail LiveLessonDetail { get; set; }
    }
}
