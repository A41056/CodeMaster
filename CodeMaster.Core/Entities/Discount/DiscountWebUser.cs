namespace CodeMaster.Core.Entities.Discount
{
    public partial class DiscountWebUser
    {
        public string DiscountCode { get; set; }

        public Guid WebUserId { get; set; }

        public int? NoUse { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Discount DiscountCodeNavigation { get; set; }

        public virtual WebUser.WebUser WebUser { get; set; }
    }
}
