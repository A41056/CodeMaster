using CodeMaster.Core.Interfaces;
using CodeMaster.Core.Models;
using CodeMaster.Core.Services.Interfaces;

namespace CodeMaster.Core.Services.Impls;
public class AuthService : IAuthService
{
    private readonly IAuthRepository _authRepository;

    public AuthService(IAuthRepository authRepository)
    {
        _authRepository = authRepository;
    }

    public async Task<string> Authenticate(LoginRequest request)
    {
        return await _authRepository.Authenticate(request);
    }
}
