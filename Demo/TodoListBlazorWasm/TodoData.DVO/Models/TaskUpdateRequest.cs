using TodoData.DVO.Enums;

namespace TodoData.DVO.Models
{
    public class TaskUpdateRequest
    {
        public string Name { get; set; }

        public Priority Priority { get; set; }

    }
}
