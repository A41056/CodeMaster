using CodeMaster.Core.Entities.Category;

namespace CodeMaster.Core.Entities
{
    public class ShowingArea
    {
        public string Code { get; set; }
        public string AreaName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<CategoryArea> CategoryAreas { get; set; } = new List<CategoryArea>();

    }
}
