using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TodoData.DVO.Enums;
using TodoData.Entity.Base.Entities;

namespace TodoData.DVO.Entities
{
    public class Task
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(250)]
        [Required]
        public string Name { get; set; }

        public Guid? AssigneeId { get; set; }

        [ForeignKey("AssigneeId")]
        public User Assignee { get; set; }

        public DateTime CreatedDate { get; set; }

        public Priority Priority { get; set; }

        public Status Status { get; set; }

    }
}
