using CodeMaster.Core.Entities.Mocktest;

namespace CodeMaster.Core.Entities.Score
{
    public partial class RankingScore
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public int MinScore { get; set; }

        public int MaxScore { get; set; }

        public int NumberOfQuestions { get; set; }

        public int NumScoreRange { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public string FullTextSearch { get; set; }

        public virtual ICollection<MocktestSection> MocktestSections { get; set; } = new List<MocktestSection>();

        public virtual ICollection<ScoreComment> ScoreComments { get; set; } = new List<ScoreComment>();

        public virtual ICollection<ScoreDetail> ScoreDetails { get; set; } = new List<ScoreDetail>();
    }
}
