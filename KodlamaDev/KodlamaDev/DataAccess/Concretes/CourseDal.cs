using KodlamaDev.DataAccess.Abstracts;
using KodlamaDev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaDev.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;

        public CourseDal()
        {
            // inmemory data örnek
            Course course = new Course();
            course.CourseId = 001;
            course.CourseName = "Python";
            course.CourseDescription = "Python 3.12...";
            course.InstructorId = 10;

            courses = new List<Course> { course };
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public void DeleteCourse(Course course)
        {
            courses.Remove(course);
        }

        public Course GetCourseById(int Id)
        {
            foreach (var course in courses)
            {
                if (course.CourseId == Id)
                {
                    return course;
                }

            }
            throw new Exception(Id + " id'li kurs bulunamadı...");
        }

        public Course GetCourseByName(string Name)
        {
            foreach (var course in courses)
            {
                if (course.CourseName == Name)
                {
                    return course;
                }
            }
            throw new Exception(Name + " isimli kurs bulunamadı...");
        }

        public void UpdateCourse(Course course)
        {
            var updateCourse = GetCourseById(course.CourseId);
            if (updateCourse != null)
            {
                updateCourse.CourseId = course.CourseId;
                updateCourse.CourseName = course.CourseName;
                updateCourse.CourseDescription = course.CourseDescription;
                updateCourse.InstructorId = course.InstructorId;
            }
            else
            {
                throw new Exception(course.CourseId + " id'li kurs bulunamadı...");
            }
        }
    }
}
