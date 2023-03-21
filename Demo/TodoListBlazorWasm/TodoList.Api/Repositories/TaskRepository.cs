using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoData.DVO.Models;
using TodoList.Api.Data;
using TodoData.Entity.Base.Paging;
using TaskEntity = TodoData.DVO.Entities.Task;

namespace TodoList.Api.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TodoListDbContext _context;

        public TaskRepository(TodoListDbContext context)
        {
            _context = context;
        }
        public async Task<PagedList<TaskEntity>> GetTaskList(TaskListSearch taskListSearch)
        {
            var query = _context.Tasks
                .Include(x => x.Assignee).AsQueryable();

            if (!string.IsNullOrEmpty(taskListSearch.Name))
                query = query.Where(x => x.Name.Contains(taskListSearch.Name));

            if (taskListSearch.AssigneeId.HasValue)
                query = query.Where(x => x.AssigneeId == taskListSearch.AssigneeId.Value);

            if (taskListSearch.Priority.HasValue)
                query = query.Where(x => x.Priority == taskListSearch.Priority.Value);

            var count = await query.CountAsync();

            var data = await query.OrderByDescending(x => x.CreatedDate)
                .Skip((taskListSearch.PageNumber - 1) * taskListSearch.PageSize)
                .Take(taskListSearch.PageSize)
                .ToListAsync();
            return new PagedList<TaskEntity>(data, count, taskListSearch.PageNumber, taskListSearch.PageSize);

        }

        public async Task<TaskEntity> Create(TaskEntity task)
        {
            await _context.Tasks.AddAsync(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<TaskEntity> Update(TaskEntity task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<TaskEntity> Delete(TaskEntity task)
        {
            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<TaskEntity> GetById(Guid id)
        {
            return await _context.Tasks.FindAsync(id);
        }

        public async Task<PagedList<TaskEntity>> GetTaskListByUserId(Guid userId, TaskListSearch taskListSearch)
        {
            var query = _context.Tasks
                    .Where(x => x.AssigneeId == userId)
                 .Include(x => x.Assignee).AsQueryable();

            if (!string.IsNullOrEmpty(taskListSearch.Name))
                query = query.Where(x => x.Name.Contains(taskListSearch.Name));

            if (taskListSearch.AssigneeId.HasValue)
                query = query.Where(x => x.AssigneeId == taskListSearch.AssigneeId.Value);

            if (taskListSearch.Priority.HasValue)
                query = query.Where(x => x.Priority == taskListSearch.Priority.Value);

            var count = await query.CountAsync();

            var data = await query.OrderByDescending(x => x.CreatedDate)
                .Skip((taskListSearch.PageNumber - 1) * taskListSearch.PageSize)
                .Take(taskListSearch.PageSize)
                .ToListAsync();
            return new PagedList<TaskEntity>(data, count, taskListSearch.PageNumber, taskListSearch.PageSize);
        }
    }
}
