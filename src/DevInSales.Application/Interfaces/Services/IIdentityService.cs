namespace DevInSales.Application.Interfaces.Services
{
    public class IIdentityService
    {
        Task<UserRegisterResponse> UserRegister(UserRegisterRequest userRegister);
        Task<UserLoginResponse> Login(UserLoginRequest userLogin);
    }
}