using OBS.DataAccess;
using OBS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OBS.Core.DTOs;

namespace OBS.Service.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;

        public UserService()
        {
            _context = new AppDbContext();
        }

        public IQueryable<UserDto> GetAll()
        {
            var usersDtos = from x in _context.Users
                            select new UserDto()
                            {
                                Id = x.Id,
                                FirstName = x.FirstName,
                                LastName = x.LastName,
                                Password = x.Password,
                                UserName = x.UserName
                            };
            return usersDtos;
        }
    }
}
