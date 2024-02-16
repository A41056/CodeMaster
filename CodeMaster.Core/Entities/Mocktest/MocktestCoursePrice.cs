using CodeMaster.Core.Entities.Course;

namespace CodeMaster.Core.Entities.Mocktest
{
    public partial class MocktestCoursePrice
    {
        public Guid MocktestId { get; set; }

        public Guid CoursePriceId { get; set; }

        public Guid CourseId { get; set; }

        public int? SortOrder { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual CoursePrice CoursePrice { get; set; }

        public virtual Mocktest Mocktest { get; set; }
    }
}
