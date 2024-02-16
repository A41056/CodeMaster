namespace CodeMaster.Core.Entities.Discount
{
    public partial class Discount
    {
        public string Code { get; set; }

        public short Status { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime ValidTo { get; set; }

        public short ScopeApply { get; set; }

        public short Type { get; set; }

        public decimal Price { get; set; }

        public decimal? PercentMaxPrice { get; set; }

        public short LimitedUse { get; set; }

        public short TypeUse { get; set; }

        public int? PeriodNo { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public string FullTextSearch { get; set; }

        public virtual ICollection<DiscountTranslation> DiscountTranslations { get; set; } = new List<DiscountTranslation>();

        public virtual ICollection<DiscountWebUser> DiscountWebUsers { get; set; } = new List<DiscountWebUser>();
    }
}
