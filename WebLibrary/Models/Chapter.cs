﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebLibrary.Models
{
    public partial class Chapter
    {
        public Chapter()
        {
            Lessons = new HashSet<Lesson>();
        }

        public int ChapterId { get; set; }
        public int? CourseId { get; set; }
        public string ChapterName { get; set; }
        public int? Index { get; set; }
        public string Description { get; set; }
        public int? TotalTime { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
