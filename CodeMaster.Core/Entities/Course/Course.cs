using CodeMaster.Core.Entities.Auth;

namespace CodeMaster.Core.Entities.Course
{
    public partial class Course
    {
        public Guid Id { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? AuthorId { get; set; }
        public short Status { get; set; }
        public string NameNonAscii { get; set; }
        public string Code { get; set; }
        public string UserGuideLink { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public bool? LearnInOrder { get; set; }
        public bool? IsFreeLearningUnit1Lession1 { get; set; }
        public bool? IsHot { get; set; }
        public string Tags { get; set; }
        public short ProductType { get; set; }
        public bool? IsMockTestType { get; set; }
        public Guid? BgImageFileId { get; set; }
        public string FullTextSearch { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }

        public virtual Category.Category Category { get; set; }

        public virtual AdminUser Author { get; set; }

        public virtual ICollection<CourseDetail> CourseDetails { get; set; } = new List<CourseDetail>();

        public virtual ICollection<CoursePrice> CoursePrices { get; set; } = new List<CoursePrice>();

        public virtual ICollection<CourseTeacher> CourseTeachers { get; set; } = new List<CourseTeacher>();

        public virtual ICollection<CourseTest> CourseTests { get; set; } = new List<CourseTest>();

        public virtual ICollection<CourseTranslation> CourseTranslations { get; set; } = new List<CourseTranslation>();

        public virtual ICollection<File.File> Files { get; set; } = new List<File.File>();

        public virtual ICollection<Order.OrderDetail> OrderDetails { get; set; } = new List<Order.OrderDetail>();

        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

        public virtual ICollection<Unit.UnitTestQuestionnaire> UnitTestQuestionnaires { get; set; } = new List<Unit.UnitTestQuestionnaire>();

        public virtual ICollection<Unit.Unit> Units { get; set; } = new List<Unit.Unit>();

        public virtual ICollection<WebUser.WebUserCourseLearningPlan> WebUserCourseLearningPlans { get; set; } = new List<WebUser.WebUserCourseLearningPlan>();

        public virtual ICollection<WebUser.WebUserUnitTestResult> WebUserUnitTestResults { get; set; } = new List<WebUser.WebUserUnitTestResult>();
    }
}
