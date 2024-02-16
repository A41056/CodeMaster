using CodeMaster.Core.Entities.Auth;

namespace CodeMaster.Core.Entities
{
    public class Permission
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ParentId { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public bool IsPermission { get; set; }
        public string Reference { get; set; }
        public virtual ICollection<AdminGroupPermission> AdminGroupPermissions { get; set; } = new List<AdminGroupPermission>();

        public virtual ICollection<Permission> InverseParent { get; set; } = new List<Permission>();

        public virtual Permission Parent { get; set; }

    }
}
