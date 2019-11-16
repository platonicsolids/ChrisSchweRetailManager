using System.Threading.Tasks;
using CSRMDesktopUI.Models;

namespace CSRMDesktopUI.Helpers
{
    public interface IAPIHelpers
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}