using DevFreelaOne.Application.InputViewModels;
using DevFreelaOne.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreelaOne.Application.Services.Interfaces
{
    public interface IUserService
    {
        UserViewModel GetUserById(int id);
        int CreateUser(CreateUserInputModel inputModel);
    }
}
