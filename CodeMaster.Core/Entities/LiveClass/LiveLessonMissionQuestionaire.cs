namespace CodeMaster.Core.Entities.LiveClass
{
    public partial class LiveLessonMissionQuestionnaire
    {
        public Guid LiveLessonMissionId { get; set; }

        public Guid QuestionnaireId { get; set; }

        public Guid LiveLessonDetailId { get; set; }

        public int? SortOrder { get; set; }

        public short QuestionnaireType { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual LiveLessonDetail LiveLessonDetail { get; set; }

        public virtual LiveLessonMission LiveLessonMission { get; set; }
    }
}
