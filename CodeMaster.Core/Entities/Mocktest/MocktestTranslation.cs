namespace CodeMaster.Core.Entities.Mocktest
{
    public partial class MocktestTranslation
    {
        public string LanguageCode { get; set; }

        public Guid MocktestId { get; set; }

        public string Name { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual LanguageTag Language { get; set; }

        public virtual Mocktest Mocktest { get; set; }
    }
}
