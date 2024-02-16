using CodeMaster.Core.Entities.LiveClass;

namespace CodeMaster.Core.Entities.WebUser
{
    public partial class WebUserLiveTestResult
    {
        public Guid LiveClassDetailTestId { get; set; }

        public Guid WebUserId { get; set; }

        public int TotalQuestion { get; set; }

        public int TotalCorrectAnswer { get; set; }

        public string RankingScore { get; set; }

        public DateTime? SubmittedDate { get; set; }

        public string ComponentsDetails { get; set; }

        public string MocktestMenu { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual LiveClassDetailTest LiveClassDetailTest { get; set; }

        public virtual WebUser WebUser { get; set; }
    }
}
