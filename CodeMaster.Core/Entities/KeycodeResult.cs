using CodeMaster.Core.Entities.Mocktest;

namespace CodeMaster.Core.Entities
{
    public partial class KeycodeResult
    {
        public string Keycode { get; set; }

        public int TotalCorrectAnswer { get; set; }

        public int TotalQuestion { get; set; }

        public string RankingScore { get; set; }

        public string ComponentsDetails { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual MocktestKeyCode KeycodeNavigation { get; set; }
    }
}
