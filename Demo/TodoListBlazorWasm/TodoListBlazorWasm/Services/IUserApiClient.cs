using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoData.DVO.Models;

namespace TodoListBlazorWasm.Services
{
    public interface IUserApiClient
    {
        Task<List<AssigneeDto>> GetAssignees();
    }
}
