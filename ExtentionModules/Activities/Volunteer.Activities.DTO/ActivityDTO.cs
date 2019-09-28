﻿namespace Volunteer.Activities.DTO
{
    using System.Collections.Generic;
    using BLModels.Entities;
    using Comments.Entity;

    public class ActivityDTO
    {
        public Activity Activity { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public int Mark { get; set; }
    }
}
