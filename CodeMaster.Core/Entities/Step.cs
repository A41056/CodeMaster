using CodeMaster.Core.Entities.WebUser;

namespace CodeMaster.Core.Entities
{
    public partial class Step
    {
        public Guid Id { get; set; }

        public Guid LessonId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int? SortOrder { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Lesson Lesson { get; set; }

        public virtual ICollection<StepQuestionnaire> StepQuestionnaires { get; set; } = new List<StepQuestionnaire>();

        public virtual ICollection<WebUserChoose> WebUserChooses { get; set; } = new List<WebUserChoose>();

        public virtual ICollection<WebUserPracticeHistory> WebUserPracticeHistories { get; set; } = new List<WebUserPracticeHistory>();
    }
}
