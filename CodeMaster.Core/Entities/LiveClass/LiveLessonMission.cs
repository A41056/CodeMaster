using CodeMaster.Core.Entities.WebUser;

namespace CodeMaster.Core.Entities.LiveClass
{
    public partial class LiveLessonMission
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid LiveLessonDetailId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool? IsPreMission { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual LiveLessonDetail LiveLessonDetail { get; set; }

        public virtual ICollection<LiveLessonMissionQuestionnaire> LiveLessonMissionQuestionnaires { get; set; } = new List<LiveLessonMissionQuestionnaire>();

        public virtual ICollection<WebUserLessonMissionChoose> WebUserLessonMissionChooses { get; set; } = new List<WebUserLessonMissionChoose>();

        public virtual ICollection<WebUserLessonMissionResult> WebUserLessonMissionResults { get; set; } = new List<WebUserLessonMissionResult>();
    }
}
