using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mTwitter.API.Models;
using mTwitter.API.Helpers;
using mTwitter.API.Models.DatabaseModels.mTwitter;
using static mTwitter.API.Models.UserModel;

namespace mTwitter.API.Services
{
    public class UserService : IUserService
    {
        private readonly mTwitterContext _context;

        public UserService(mTwitterContext context)
        {
            _context = context;
        }

        public UserDTO CreateNewUser(string firstName, string lastName, string email, string password, string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ApplicationException("Password is required");

            if (_context.ApplicationUser.Any(x => x.Email == email))
                throw new ApplicationException("Email \"" + email + "\" is already taken");

            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            string roleAdmin = "C30E2B4E-37E6-41DF-99CF-1A93447335A6";
            string roleUser = "F33A5033-16AE-4033-89F9-9D2DD72E5EB5";

            ApplicationUser u = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                RoleId = new Guid(roleUser),
                PhoneNumber = phoneNumber,
                IsActive = true,
                IsDeleted = false,
                CreatedOn = DateTime.Now,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };

            _context.ApplicationUser.Add(u);
            _context.SaveChanges();

            return new UserDTO()
            {
                Id = u.Id,
                DisplayName = $"{u.FirstName} {u.LastName}",
                Email = u.Email,
                Role = u.Role,
                PhoneNumber = u.PhoneNumber,
                CreatedOn = u.CreatedOn
            };
        }

        public UserDTO Authenticate(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return null;
            }

            ApplicationUser user = _context.ApplicationUser
                .SingleOrDefault(u => u.Email == email);

            if(user == null)
            {
                return null;
            }

            // check if password is correct
            if(!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                return null;
            }

            // authentication successful
            return new UserDTO()
            {
                Id = user.Id,
                DisplayName = $"{user.FirstName} {user.LastName}",
                Email = user.Email,
                Role = user.Role,
                PhoneNumber = user.PhoneNumber,
                CreatedOn = user.CreatedOn
            };
        }

        public UserDTO GetUserById(Guid id)
        {
            UserDTO user = _context.ApplicationUser
                .Where(u => u.Id == id && u.IsActive == true && u.IsDeleted == false)
                .Select(u => new UserDTO()
                {
                    Id = u.Id,
                    DisplayName = $"{u.FirstName} {u.LastName}",
                    Email = u.Email,
                    Role = u.Role,
                    PhoneNumber = u.PhoneNumber,
                    CreatedOn = u.CreatedOn
                })
                .SingleOrDefault();

            return user;
        }

        // Private helper methods
        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for(int i = 0; i < computedHash.Length; i++)
                {
                    if(computedHash[i] != storedHash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
