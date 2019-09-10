using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static mTwitter.API.Models.UserModel;

namespace mTwitter.API.Services
{
    public interface IUserService
    {
        UserDTO CreateNewUser(string firstName, string lastName, string email, string password, string phoneNumber);
        UserDTO Authenticate(string email, string password);
        UserDTO GetUserById(Guid id);
    }
}
