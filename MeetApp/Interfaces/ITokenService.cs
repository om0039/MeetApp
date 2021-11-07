using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetApp.Entities;

namespace MeetApp.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}