using CodeMaster.Core.Entities.Questionaire;

namespace CodeMaster.Core.Entities
{
    public partial class StepQuestionnaire
    {
        public Guid StepId { get; set; }

        public Guid QuestionnaireId { get; set; }

        public Guid CourseId { get; set; }

        public int? SortOrder { get; set; }

        public Guid LessonId { get; set; }

        public Guid UnitId { get; set; }

        public short QuestionnaireType { get; set; }

        public virtual Questionnaire Questionnaire { get; set; }

        public virtual Step Step { get; set; }
    }
}
