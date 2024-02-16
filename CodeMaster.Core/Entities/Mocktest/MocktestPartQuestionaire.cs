using CodeMaster.Core.Entities.Questionaire;

namespace CodeMaster.Core.Entities.Mocktest
{
    public partial class MocktestPartQuestionnaire
    {
        public Guid MocktestPartId { get; set; }

        public Guid QuestionnaireId { get; set; }

        public Guid MocktestId { get; set; }

        public int SortOrder { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual MocktestPart MocktestPart { get; set; }

        public virtual Questionnaire Questionnaire { get; set; }
    }
}
