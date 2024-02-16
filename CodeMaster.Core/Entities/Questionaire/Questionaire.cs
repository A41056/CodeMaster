using CodeMaster.Core.Entities.Mocktest;

namespace CodeMaster.Core.Entities.Questionaire
{
    public partial class Questionnaire
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public short Type { get; set; }

        public Guid? QuestionnaireGroupId { get; set; }

        public string QuestionnaireGroupName { get; set; }

        public string TitleLeftSection { get; set; }

        public Guid? VideoFileId { get; set; }

        public Guid? SubtitleFileId { get; set; }

        public Guid? SlideFileId { get; set; }

        public string IntroContent { get; set; }

        public bool IsActive { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public string Identifier { get; set; }

        public string FullTextSearch { get; set; }

        public virtual ICollection<LeftSection> LeftSections { get; set; } = new List<LeftSection>();

        public virtual ICollection<MocktestPartQuestionnaire> MocktestPartQuestionnaires { get; set; } = new List<MocktestPartQuestionnaire>();

        public virtual QuestionnaireGroup QuestionnaireGroup { get; set; }

        public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

        public virtual ICollection<StepQuestionnaire> StepQuestionnaires { get; set; } = new List<StepQuestionnaire>();

        public virtual ICollection<Unit.UnitTestQuestionnaire> UnitTestQuestionnaires { get; set; } = new List<Unit.UnitTestQuestionnaire>();

        public virtual ICollection<WebUser.WebUserPracticeHistory> WebUserPracticeHistories { get; set; } = new List<WebUser.WebUserPracticeHistory>();
    }
}
