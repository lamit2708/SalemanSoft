﻿using System;
using System.ComponentModel.DataAnnotations;
using TodoData.DVO.Enums;

namespace TodoData.DVO.Models
{
    public class TaskCreateRequest
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [MaxLength(20, ErrorMessage = "You cannot fill task name over than 20 characters")]
        [Required(ErrorMessage = "Please enter your task name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select your task priority")]
        public Priority? Priority { get; set; }
    }
}
