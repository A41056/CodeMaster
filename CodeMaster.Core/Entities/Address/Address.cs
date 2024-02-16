namespace CodeMaster.Core.Entities.Address
{
    public class Address
    {
        public Guid Id { get; set; }
        public int SortOrder { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public virtual ICollection<AddressTranslation> AddressTranslations { get; set; } = new List<AddressTranslation>();
    }
}
