namespace CodeMaster.Core.Entities.Auth
{
    public class AdminGroup
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string Identifier { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public string FullTextSearch { get; set; }
        public virtual ICollection<AdminGroupPermission> AdminGroupPermissions { get; set; } = new List<AdminGroupPermission>();

        public virtual ICollection<AdminUserGroup> AdminUserGroups { get; set; } = new List<AdminUserGroup>();
    }
}
