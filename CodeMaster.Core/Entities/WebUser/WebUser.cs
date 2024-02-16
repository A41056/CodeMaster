using CodeMaster.Core.Entities.Discount;

namespace CodeMaster.Core.Entities.WebUser
{
    public partial class WebUser
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Gender { get; set; }

        public DateTime? Birthday { get; set; }

        public bool IsActive { get; set; }

        public string CurrentAddress { get; set; }

        public string JobName { get; set; }

        public string FacebookId { get; set; }

        public string GoogleId { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public string FullTextSearch { get; set; }

        public bool? Deleted { get; set; }

        public bool EmailVerified { get; set; }

        public short AccessFailedCount { get; set; }

        public short RegisterType { get; set; }

        public string Identifier { get; set; }

        public long? ClassinUserId { get; set; }

        public virtual ICollection<Dictionary.Dictionary> Dictionaries { get; set; } = new List<Dictionary.Dictionary>();

        public virtual ICollection<DiscountWebUser> DiscountWebUsers { get; set; } = new List<DiscountWebUser>();

        public virtual ICollection<Order.Order> Orders { get; set; } = new List<Order.Order>();

        public virtual ICollection<ReceiveInvoice> ReceiveInvoices { get; set; } = new List<ReceiveInvoice>();

        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

        public virtual ICollection<VerificationCode> VerificationCodes { get; set; } = new List<VerificationCode>();

        public virtual ICollection<WebUserChoose> WebUserChooses { get; set; } = new List<WebUserChoose>();

        public virtual ICollection<WebUserCourseLearningPlan> WebUserCourseLearningPlans { get; set; } = new List<WebUserCourseLearningPlan>();

        public virtual ICollection<WebUserCourseTestChoose> WebUserCourseTestChooses { get; set; } = new List<WebUserCourseTestChoose>();

        public virtual ICollection<WebUserCourseTestResult> WebUserCourseTestResults { get; set; } = new List<WebUserCourseTestResult>();

        public virtual ICollection<WebUserLessonMissionChoose> WebUserLessonMissionChooses { get; set; } = new List<WebUserLessonMissionChoose>();

        public virtual ICollection<WebUserLessonMissionResult> WebUserLessonMissionResults { get; set; } = new List<WebUserLessonMissionResult>();

        public virtual ICollection<WebUserLiveTestChoose> WebUserLiveTestChooses { get; set; } = new List<WebUserLiveTestChoose>();

        public virtual ICollection<WebUserLiveTestResult> WebUserLiveTestResults { get; set; } = new List<WebUserLiveTestResult>();

        public virtual ICollection<WebUserPracticeHistory> WebUserPracticeHistories { get; set; } = new List<WebUserPracticeHistory>();

        public virtual ICollection<WebUserUnitTestChoose> WebUserUnitTestChooses { get; set; } = new List<WebUserUnitTestChoose>();

        public virtual ICollection<WebUserUnitTestResult> WebUserUnitTestResults { get; set; } = new List<WebUserUnitTestResult>();
    }
}
