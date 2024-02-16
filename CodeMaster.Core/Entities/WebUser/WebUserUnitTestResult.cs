using CodeMaster.Core.Entities.Unit;

namespace CodeMaster.Core.Entities.WebUser
{
    public partial class WebUserUnitTestResult
    {
        public Guid UnitTestId { get; set; }

        public Guid WebUserId { get; set; }

        public Guid CourseId { get; set; }

        public int TotalQuestion { get; set; }

        public int TotalCorrectAnswer { get; set; }

        public DateTime? SubmittedDate { get; set; }

        public string QuestionnaireIds { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Course.Course Course { get; set; }

        public virtual UnitTest UnitTest { get; set; }

        public virtual WebUser WebUser { get; set; }
    }
}
