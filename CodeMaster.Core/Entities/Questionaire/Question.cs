using CodeMaster.Core.Entities.WebUser;

namespace CodeMaster.Core.Entities.Questionaire
{
    public partial class Question
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid QuestionnaireId { get; set; }

        public int? SortOrder { get; set; }

        public string Explanation { get; set; }

        public string Note { get; set; }

        public string FakeValues { get; set; }

        public string DisplayTimestamp { get; set; }

        public Guid? ImageFileId { get; set; }

        public string WordEnglish { get; set; }

        public short? TypeOfWord { get; set; }

        public string WordPhonetic { get; set; }

        public Guid? WordFileId { get; set; }

        public Guid? TextFileId { get; set; }

        public string TextEnglish { get; set; }

        public string MatchingJson { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

        public virtual ICollection<QuestionTranslation> QuestionTranslations { get; set; } = new List<QuestionTranslation>();

        public virtual Questionnaire Questionnaire { get; set; }

        public virtual ICollection<WebUserChoose> WebUserChooses { get; set; } = new List<WebUserChoose>();
    }
}
