namespace CodeMaster.Core.Entities.Auth
{
    public class AdminGroupPermission
    {
        public string PermissionId { get; set; }
        public Guid GroupId { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public virtual AdminGroup AdminGroup { get; set; }
        public virtual Permission Permission { get; set; }
    }
}
