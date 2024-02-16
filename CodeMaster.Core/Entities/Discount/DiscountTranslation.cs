namespace CodeMaster.Core.Entities.Discount
{
    public partial class DiscountTranslation
    {
        public string LanguageCode { get; set; }

        public string DiscountCode { get; set; }

        public string Name { get; set; }

        public virtual Discount Discount { get; set; }

        public virtual LanguageTag Language { get; set; }
    }
}
