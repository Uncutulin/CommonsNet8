using System.Threading.Tasks;

namespace CommonsNET8.Identity.Services
{
    public interface ISignInService
    {
        Task SignOutAsync();
        Task SignInAsync(string username);
    }
}