namespace CodeMaster.Core.Entities.Unit
{
    public partial class UnitTest
    {
        public Guid Id { get; set; }

        public Guid UnitId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public long TestTime { get; set; }

        public int? SortOrder { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Unit Unit { get; set; }

        public virtual ICollection<UnitTestQuestionnaire> UnitTestQuestionnaires { get; set; } = new List<UnitTestQuestionnaire>();

        public virtual ICollection<WebUser.WebUserUnitTestChoose> WebUserUnitTestChooses { get; set; } = new List<WebUser.WebUserUnitTestChoose>();

        public virtual ICollection<WebUser.WebUserUnitTestResult> WebUserUnitTestResults { get; set; } = new List<WebUser.WebUserUnitTestResult>();
    }
}
