using CodeMaster.Core.Entities.WebUser;

namespace CodeMaster.Core.Entities.LiveClass
{
    public partial class LiveClassDetailTest
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid LiveClassDetailId { get; set; }

        public Guid MocktestId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual LiveClassDetail LiveClassDetail { get; set; }

        public virtual Mocktest.Mocktest Mocktest { get; set; }

        public virtual ICollection<WebUserLiveTestChoose> WebUserLiveTestChooses { get; set; } = new List<WebUserLiveTestChoose>();

        public virtual ICollection<WebUserLiveTestResult> WebUserLiveTestResults { get; set; } = new List<WebUserLiveTestResult>();
    }
}
