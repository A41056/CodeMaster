using CodeMaster.Core.Entities.Auth;
using CodeMaster.Core.Entities.WebUser;

namespace CodeMaster.Core.Entities.LiveClass
{
    public partial class LiveLessonDetail
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid LiveClassDetailId { get; set; }

        public Guid TeacherId { get; set; }

        public DateTime LearningDate { get; set; }

        public DateTime LearningEndDate { get; set; }

        public long? ClassinLessonId { get; set; }

        public int NumberLesson { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public string FullTextSearch { get; set; }

        public virtual LiveClassDetail LiveClassDetail { get; set; }

        public virtual ICollection<LiveLessonDetailAdviser> LiveLessonDetailAdvisers { get; set; } = new List<LiveLessonDetailAdviser>();

        public virtual ICollection<LiveLessonMissionQuestionnaire> LiveLessonMissionQuestionnaires { get; set; } = new List<LiveLessonMissionQuestionnaire>();

        public virtual ICollection<LiveLessonMission> LiveLessonMissions { get; set; } = new List<LiveLessonMission>();

        public virtual AdminUser Teacher { get; set; }

        public virtual ICollection<WebUserLessonMissionResult> WebUserLessonMissionResults { get; set; } = new List<WebUserLessonMissionResult>();
    }
}
