namespace CodeMaster.Core.Entities.Score
{
    public partial class ScoreDetail
    {
        public Guid Id { get; set; }

        public Guid RankingScoreId { get; set; }

        public int ExactScore { get; set; }

        public int NumberOfCorrectQuestions { get; set; }

        public int FromScore { get; set; }

        public int ToScore { get; set; }

        public int SortOrder { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual RankingScore RankingScore { get; set; }
    }
}
