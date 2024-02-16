namespace CodeMaster.Core.Entities.Course
{
    public partial class CourseTestUnit
    {
        public Guid CourseTestId { get; set; }

        public Guid UnitId { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual CourseTest CourseTest { get; set; }

        public virtual Unit.Unit Unit { get; set; }
    }
}
