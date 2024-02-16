namespace CodeMaster.Core.Entities.LiveClass
{
    public partial class LiveClassType
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public short StudentNumber { get; set; }

        public short TotalLesson { get; set; }

        public short TimeLesson { get; set; }

        public short Status { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual ICollection<LiveClassDetail> LiveClassDetails { get; set; } = new List<LiveClassDetail>();
    }
}
