namespace CodeMaster.Core.Entities.Questionaire
{
    public partial class QuestionTranslation
    {
        public string LanguageCode { get; set; }

        public Guid QuestionId { get; set; }

        public string WordTranslation { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual LanguageTag Language { get; set; }

        public virtual Question Question { get; set; }
    }
}
