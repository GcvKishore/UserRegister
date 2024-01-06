using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using UserRegister.Models;

namespace UserRegister.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> ChangePasswordAsync(ChangePasswordModel model);
    }
}
