using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoData.Entity.Base.Entities;

namespace TodoListBlazorWasm.Services
{
    public interface IAuthService
    {
        Task<LoginResponse> Login(LoginRequest loginRequest);
        Task Logout();
    }
}
