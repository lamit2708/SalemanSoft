using System;
using TodoData.DVO.Enums;
using TodoData.Entity.Base.Paging;

namespace TodoData.DVO.Models
{
    public class TaskListSearch : PagingParameters
    {
        public string Name { get; set; }

        public Guid? AssigneeId { get; set; }

        public Priority? Priority { get; set; }
    }
}
