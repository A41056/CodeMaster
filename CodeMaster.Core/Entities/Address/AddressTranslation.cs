namespace CodeMaster.Core.Entities.Address
{
    public class AddressTranslation
    {
        public string LanguageCode { get; set; }
        public Guid AddressId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public virtual Address Address { get; set; }
        public virtual LanguageTag Language { get; set; }
    }
}
