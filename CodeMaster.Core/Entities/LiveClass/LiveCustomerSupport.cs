namespace CodeMaster.Core.Entities.LiveClass
{
    public partial class LiveCustomerSupport
    {
        public Guid Id { get; set; }

        public Guid? WebUserId { get; set; }

        public Guid CourseId { get; set; }

        public Guid CoursePriceId { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public string FullTextSearch { get; set; }
    }
}
