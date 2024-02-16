using CodeMaster.Core.Entities.LiveClass;

namespace CodeMaster.Core.Entities.WebUser
{
    public partial class WebUserLessonMissionChoose
    {
        public Guid WebUserId { get; set; }

        public Guid AnswerId { get; set; }

        public Guid LiveLessonMissionId { get; set; }

        public Guid QuestionId { get; set; }

        public string AnswerText { get; set; }

        public bool CorrectAnswer { get; set; }

        public Guid? MatchingQuestionId { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual LiveLessonMission LiveLessonMission { get; set; }

        public virtual WebUser WebUser { get; set; }
    }
}
