using System;
using System.Threading.Tasks;
using TodoData.DVO.Models;
using TodoData.Entity.Base.Paging;
using TaskEntity = TodoData.DVO.Entities.Task;

namespace TodoList.Api.Repositories
{
    public interface ITaskRepository
    {
        Task<PagedList<TaskEntity>> GetTaskList(TaskListSearch taskListSearch);

        Task<PagedList<TaskEntity>> GetTaskListByUserId(Guid userId, TaskListSearch taskListSearch);

        Task<TaskEntity> Create(TaskEntity task);

        Task<TaskEntity> Update(TaskEntity task);

        Task<TaskEntity> Delete(TaskEntity task);

        Task<TaskEntity> GetById(Guid id);
    }
}
