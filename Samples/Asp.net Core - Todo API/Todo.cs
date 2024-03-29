﻿using System.Text.Json.Serialization;

namespace Asp.net_Core___Todo_API
{
    public class Todo
    {
        /// <summary>
        /// the identifier of the todo
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// the title of the todo
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// the description of the todo (can be null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Is the task completed True or false
        /// </summary>
        public bool IsDone { get; set; } 
    }
}
