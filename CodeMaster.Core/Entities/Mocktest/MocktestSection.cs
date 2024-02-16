namespace CodeMaster.Core.Entities.Mocktest
{
    public partial class MocktestSection
    {
        public Guid Id { get; set; }

        public Guid MocktestId { get; set; }

        public Guid RankingScoreId { get; set; }

        public string Name { get; set; }

        public int SortOrder { get; set; }

        public short Type { get; set; }

        public int NumberOfQuestions { get; set; }

        public int NumberOfTime { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Mocktest Mocktest { get; set; }

        public virtual ICollection<MocktestPart> MocktestParts { get; set; } = new List<MocktestPart>();

        public virtual Score.RankingScore RankingScore { get; set; }
    }
}
