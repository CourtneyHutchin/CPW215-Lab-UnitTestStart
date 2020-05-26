using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        private string instructorName;
        private string courseName;
        private byte numCredits;

        public Course(string courseName)
        {
            CourseName = courseName;
            instructorName = "STAFF";
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { 
            get => instructorName; 
            set => instructorName = value; 
        }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName { 
            get => courseName; 
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException();
                }
                courseName = value;
            }
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits { 
            get => numCredits; 
            set
            {
                if(value < 30 && value > 0)
                {
                    numCredits = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}
