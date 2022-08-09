using DevFreelaOne.Application.InputViewModels;
using DevFreelaOne.Application.Services.Interfaces;
using DevFreelaOne.Application.ViewModels;
using DevFreelaOne.Core.Entities;
using DevFreelaOne.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreelaOne.Application.Services.Implementarions
{
    public class UserService : IUserService
    {
        private readonly DevFreelaOneDbContext _context;
        public UserService(DevFreelaOneDbContext context)
        {
            _context = context;
        }

        public int CreateUser(CreateUserInputModel inputModel)
        {
            var user = new User(inputModel.FullName, inputModel.Email, inputModel.BirthDate);

            _context.Users.Add(user);

            return user.Id;
        }

        public UserViewModel GetUserById(int id)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == id);
            if(user == null)
            {
                return null;
            }

            return new UserViewModel(user.FullName, user.Email);            
        }
    }
}
