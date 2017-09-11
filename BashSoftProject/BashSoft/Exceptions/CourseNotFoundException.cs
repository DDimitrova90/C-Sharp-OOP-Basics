﻿namespace BashSoft.Exceptions
{
    using System;

    public class CourseNotFoundException : Exception
    {
        private const string NotEnrolledInCourse = 
            "Student must be enrolled in a course before you set his mark.";

        public CourseNotFoundException(string message) 
            : base(message)
        {
        }

        public CourseNotFoundException() 
            : base(NotEnrolledInCourse)
        {
        }
    }
}
