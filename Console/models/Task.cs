﻿namespace models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string State { get; set;}
        public DateTime Created { get; set;}
    }
}