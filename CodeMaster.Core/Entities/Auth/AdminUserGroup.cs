namespace CodeMaster.Core.Entities.Auth
{
    public class AdminUserGroup
    {
        public Guid GroupId { get; set; }
        public Guid UserId { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }

        public virtual AdminGroup AdminGroup { get; set; }
        public virtual AdminUser AdminUser { get; set; }
    }
}
