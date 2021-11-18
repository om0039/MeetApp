using MeetApp.Entities;

namespace MeetApp.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}