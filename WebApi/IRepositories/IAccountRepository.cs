using ClassLibrary;

namespace WebApi.IRepositories
{
    public interface IAccountRepository
    {
        Task<Register> RegisterUser(Register obj);
        Register Authenticate(Register obj);


    }
}
