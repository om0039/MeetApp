using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetApp.DTOs;
using MeetApp.Entities;
using MeetApp.Helpers;

namespace MeetApp.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);
        
    }
}