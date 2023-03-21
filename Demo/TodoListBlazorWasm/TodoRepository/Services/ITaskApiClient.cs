using System;
using System.Threading.Tasks;
using TodoData.DVO.Models;
using TodoData.Entity.Base.Paging;

namespace TodoRepository.Services
{
    public interface ITaskApiClient
    {
        Task<PagedList<DVOTask>> GetTaskList(TaskListSearch taskListSearch);

        Task<PagedList<DVOTask>> GetMyTasks(TaskListSearch taskListSearch);


        Task<DVOTask> GetTaskDetail(string id);

        Task<bool> CreateTask(TaskCreateRequest request);
        Task<bool> UpdateTask(Guid id, TaskUpdateRequest request);

        Task<bool> AssignTask(Guid id, AssignTaskRequest request);

        Task<bool> DeleteTask(Guid id);
    }
}
