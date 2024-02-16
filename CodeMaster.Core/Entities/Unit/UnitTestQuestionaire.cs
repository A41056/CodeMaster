using CodeMaster.Core.Entities.Questionaire;

namespace CodeMaster.Core.Entities.Unit
{
    public partial class UnitTestQuestionnaire
    {
        public Guid UnitTestId { get; set; }

        public Guid QuestionnaireId { get; set; }

        public Guid CourseId { get; set; }

        public int? SortOrder { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public short QuestionnaireType { get; set; }

        public virtual Course.Course Course { get; set; }

        public virtual Questionnaire Questionnaire { get; set; }

        public virtual UnitTest UnitTest { get; set; }
    }
}
