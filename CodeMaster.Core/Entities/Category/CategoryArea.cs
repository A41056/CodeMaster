namespace CodeMaster.Core.Entities.Category
{
    public class CategoryArea
    {
        public string AreaCode { get; set; }
        public Guid CategoryId { get; set; }
        public int SortOrder { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }

        public virtual ShowingArea Area { get; set; }
        public virtual Category Category { get; set; }
    }
}
