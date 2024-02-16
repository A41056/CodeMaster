namespace CodeMaster.Core.Entities.WebUser
{
    public partial class WebUserCourseLearningPlan
    {
        public Guid CourseId { get; set; }

        public Guid WebUserId { get; set; }

        public DateTime StartDate { get; set; }

        public short DaysPerWeek { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Course.Course Course { get; set; }

        public virtual WebUser WebUser { get; set; }
    }
}
