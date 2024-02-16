using CodeMaster.Core.Entities.Course;

namespace CodeMaster.Core.Entities.Order
{
    public partial class OrderDetail
    {
        public Guid OrderId { get; set; }

        public Guid CourseId { get; set; }

        public Guid CoursePriceId { get; set; }

        public int Quantity { get; set; }

        public bool IsDraft { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Course.Course Course { get; set; }

        public virtual CoursePrice CoursePrice { get; set; }

        public virtual Order Order { get; set; }
    }
}
