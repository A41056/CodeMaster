using CodeMaster.Core.Models;

namespace CodeMaster.Core.Services.Interfaces;
public interface IAuthService
{
    Task<string> Authenticate(LoginRequest request);
}
