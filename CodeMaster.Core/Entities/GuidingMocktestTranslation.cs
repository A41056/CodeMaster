namespace CodeMaster.Core.Entities
{
    public partial class GuidingMocktestTranslation
    {
        public string LanguageCode { get; set; }

        public Guid GuidingMocktestId { get; set; }

        public Guid? DesktopImageId { get; set; }

        public Guid? MobileImageId { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public virtual GuidingMocktest GuidingMocktest { get; set; }

        public virtual LanguageTag Language { get; set; }
    }
}
