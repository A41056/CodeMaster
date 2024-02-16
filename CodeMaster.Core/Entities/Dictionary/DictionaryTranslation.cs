namespace CodeMaster.Core.Entities.Dictionary
{
    public partial class DictionaryTranslation
    {
        public string LanguageCode { get; set; }

        public Guid DictionaryId { get; set; }

        public string WordTranslation { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Dictionary Dictionary { get; set; }

        public virtual LanguageTag Language { get; set; }
    }
}
