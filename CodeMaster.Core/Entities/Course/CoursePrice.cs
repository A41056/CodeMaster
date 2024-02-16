namespace CodeMaster.Core.Entities.Course
{
    public class CoursePrice
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public int? NumberOfMonth { get; set; }
        public decimal Price { get; set; }
        public decimal? SalePrice { get; set; }
        public DateTime? SaleValidFrom { get; set; }
        public DateTime? SaleValidTo { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public Guid? ImageFileId { get; set; }
        public Guid? ExamToolCategoryId { get; set; }
        public Guid? ClassTypeId { get; set; }
        public bool Deleted { get; set; }
        public virtual Course Course { get; set; }
        public virtual ICollection<CoursePriceTranslation> CoursePriceTranslations { get; set; } = new List<CoursePriceTranslation>();

        public virtual ICollection<Mocktest.MocktestCoursePrice> MocktestCoursePrices { get; set; } = new List<Mocktest.MocktestCoursePrice>();

        public virtual ICollection<Order.OrderDetail> OrderDetails { get; set; } = new List<Order.OrderDetail>();
    }
}
