﻿namespace FormApplication.Models
{
    public class Applicant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Dept Department { get; set; }
    }
}
