using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Services
{
    public class PasswordService : IPasswordService
    {
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password, string HashPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, HashPassword);
        }
    }
}
