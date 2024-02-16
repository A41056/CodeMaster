namespace CodeMaster.Core.Entities
{
    public partial class Districts
    {
        public Guid Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public Guid ProvinceId { get; set; }

        public Guid CreatedByUserId { get; set; }

        public Guid LastModifiedByUserId { get; set; }

        public DateTime LastModifiedOnDate { get; set; }

        public DateTime CreatedOnDate { get; set; }
    }
}
