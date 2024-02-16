namespace CodeMaster.Core.Entities.Mocktest
{
    public partial class MocktestPart
    {
        public Guid Id { get; set; }

        public Guid MocktestSectionId { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public int SortOrder { get; set; }

        public Guid? IntroAudioFileId { get; set; }

        public int DelayTimeEachQuestion { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual ICollection<MocktestPartQuestionnaire> MocktestPartQuestionnaires { get; set; } = new List<MocktestPartQuestionnaire>();

        public virtual MocktestSection MocktestSection { get; set; }
    }
}
