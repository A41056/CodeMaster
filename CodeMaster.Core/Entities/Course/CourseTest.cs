namespace CodeMaster.Core.Entities.Course
{
    public partial class CourseTest
    {
        public Guid Id { get; set; }

        public Guid CourseId { get; set; }

        public Guid? ImageFileId { get; set; }

        public Guid MocktestId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int? SortOrder { get; set; }

        public string TagName { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Course Course { get; set; }

        public virtual ICollection<CourseTestUnit> CourseTestUnits { get; set; } = new List<CourseTestUnit>();

        public virtual File.File ImageFile { get; set; }

        public virtual Mocktest.Mocktest Mocktest { get; set; }

        public virtual ICollection<WebUser.WebUserCourseTestChoose> WebUserCourseTestChooses { get; set; } = new List<WebUser.WebUserCourseTestChoose>();

        public virtual ICollection<WebUser.WebUserCourseTestResult> WebUserCourseTestResults { get; set; } = new List<WebUser.WebUserCourseTestResult>();
    }
}
