using System.Threading.Tasks;
using MeetApp.Entities;

namespace MeetApp.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}