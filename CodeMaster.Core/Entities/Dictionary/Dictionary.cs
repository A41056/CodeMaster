namespace CodeMaster.Core.Entities.Dictionary
{
    public partial class Dictionary
    {
        public Guid Id { get; set; }

        public Guid WebUserId { get; set; }

        public Guid? CourseId { get; set; }

        public Guid? UnitId { get; set; }

        public Guid? LessonId { get; set; }

        public Guid? StepId { get; set; }

        public Guid? QuestionnaireId { get; set; }

        public Guid? QuestionId { get; set; }

        public string WordEnglish { get; set; }

        public short? TypeOfWord { get; set; }

        public string WordPhonetic { get; set; }

        public Guid? WordFileId { get; set; }

        public Guid? TextFileId { get; set; }

        public string TextEnglish { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public string FullTextSearch { get; set; }

        public virtual ICollection<DictionaryTranslation> DictionaryTranslations { get; set; } = new List<DictionaryTranslation>();

        public virtual WebUser.WebUser WebUser { get; set; }
    }
}
