using CodeMaster.Core.Entities.Auth;
using CodeMaster.Core.Models;

namespace CodeMaster.Core.Interfaces;
public interface IAuthRepository : IBaseRepository<AdminUser>
{
    Task<string> Authenticate(LoginRequest request);
}
