namespace CodeMaster.Core.Entities.News
{
    public partial class NewsTranslation
    {
        public string LanguageCode { get; set; }

        public Guid NewsId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public virtual LanguageTag Language { get; set; }

        public virtual News News { get; set; }
    }
}
