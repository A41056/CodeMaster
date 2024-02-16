namespace CodeMaster.Core.Entities.Course
{
    public partial class CourseTimeOnTask
    {
        public Guid CourseId { get; set; }

        public Guid WebUserId { get; set; }

        public long TimeDuration { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }
    }
}
