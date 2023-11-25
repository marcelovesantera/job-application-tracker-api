﻿using JobApplicationTrackerApi.Domain;

namespace JobApplicationTrackerApi.Presentation.Models
{
    public class UserInputModel
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
