using CodeMaster.Core.Entities.Course;

namespace CodeMaster.Core.Entities.Unit
{
    public partial class Unit
    {
        public Guid Id { get; set; }

        public Guid CourseId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int? SortOrder { get; set; }

        public bool? LearnInOrder { get; set; }

        public int? WeekLearningPlan { get; set; }

        public string TagName { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public Guid? ImageFileId { get; set; }

        public virtual Course.Course Course { get; set; }

        public virtual ICollection<CourseTestUnit> CourseTestUnits { get; set; } = new List<CourseTestUnit>();

        public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();

        public virtual ICollection<UnitTest> UnitTests { get; set; } = new List<UnitTest>();
    }
}
