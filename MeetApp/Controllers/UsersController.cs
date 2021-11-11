using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MeetApp.Data;
using MeetApp.DTOs;
using MeetApp.Entities;
using MeetApp.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeetApp.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository _userRespository;
        private readonly IMapper _mapper;
        public UsersController(IUserRepository userRespository, IMapper mapper)
        {
            _mapper = mapper;
            _userRespository = userRespository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
            var users = await _userRespository.GetMembersAsync();


            return Ok(users);
        }

        
        [HttpGet("{username}")]
        public async Task<ActionResult<MemberDto>> GetUser(string username)
        {
            return await _userRespository.GetMemberAsync(username);
        }
    }
}