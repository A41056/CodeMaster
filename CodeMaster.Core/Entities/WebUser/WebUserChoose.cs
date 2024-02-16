using CodeMaster.Core.Entities.Questionaire;

namespace CodeMaster.Core.Entities.WebUser
{
    public partial class WebUserChoose
    {
        public Guid WebUserId { get; set; }

        public Guid QuestionId { get; set; }

        public Guid? MatchingQuestionId { get; set; }

        public Guid AnswerId { get; set; }

        public Guid StepId { get; set; }

        public string AnswerText { get; set; }

        public bool CorrectAnswer { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public Guid LessonId { get; set; }

        public Guid UnitId { get; set; }

        public Guid CourseId { get; set; }

        public virtual Answer Answer { get; set; }

        public virtual Question Question { get; set; }

        public virtual Step Step { get; set; }

        public virtual WebUser WebUser { get; set; }
    }
}
