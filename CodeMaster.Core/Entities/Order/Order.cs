namespace CodeMaster.Core.Entities.Order
{
    public partial class Order
    {
        public Guid Id { get; set; }

        public Guid WebUserId { get; set; }

        public string WebUserIdentifier { get; set; }

        public string WebUserFullName { get; set; }

        public string WebUserPhoneNumber { get; set; }

        public string WebUserEmail { get; set; }

        public DateTime OrderDate { get; set; }

        public string OrderCode { get; set; }

        public string OrderNote { get; set; }

        public short? Shipping { get; set; }

        public short? PaymentMethod { get; set; }

        public decimal TotalPayment { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal? TotalDiscount { get; set; }

        public string ApplyDiscountCode { get; set; }

        public short? ApplyDiscountMethod { get; set; }

        public decimal? ApplyDiscountPercent { get; set; }

        public decimal? ApplyDiscountPrice { get; set; }

        public DateTime? ApplyDiscountExpiredTime { get; set; }

        public short? ApplyDiscountTypeUse { get; set; }

        public decimal? PriceShipping { get; set; }

        public int TotalProducts { get; set; }

        public bool? IsProvideEnoughAccount { get; set; }

        public short Status { get; set; }

        public long? ReceiptCode { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public bool IsFreeOrder { get; set; }

        public string FullTextSearch { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

        public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new List<PaymentTransaction>();

        public virtual ICollection<StoreCourse> StoreCourses { get; set; } = new List<StoreCourse>();

        public virtual WebUser.WebUser WebUser { get; set; }
    }
}
