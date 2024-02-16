namespace CodeMaster.Core.Entities
{
    public partial class Lesson
    {
        public Guid Id { get; set; }

        public Guid UnitId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int? SortOrder { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual ICollection<Step> Steps { get; set; } = new List<Step>();

        public virtual Unit.Unit Unit { get; set; }
    }
}
