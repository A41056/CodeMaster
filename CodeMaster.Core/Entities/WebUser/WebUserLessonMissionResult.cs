using CodeMaster.Core.Entities.LiveClass;

namespace CodeMaster.Core.Entities.WebUser
{
    public partial class WebUserLessonMissionResult
    {
        public Guid LiveLessonMissionId { get; set; }

        public Guid WebUserId { get; set; }

        public Guid LiveLessonDetailId { get; set; }

        public int TotalQuestion { get; set; }

        public int TotalCorrectAnswer { get; set; }

        public DateTime? SubmittedDate { get; set; }

        public string QuestionnaireIds { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public int CorrectPercentage { get; set; }

        public virtual LiveLessonDetail LiveLessonDetail { get; set; }

        public virtual LiveLessonMission LiveLessonMission { get; set; }

        public virtual WebUser WebUser { get; set; }
    }
}
