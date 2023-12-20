using JwtDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtDemo.Services
{
    public interface IAuthenticateService
    {
        User Authenticate(string userName, string password);
    }
}
