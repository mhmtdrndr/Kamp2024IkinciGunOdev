using KodlamaDev.Business.Abstracts;
using KodlamaDev.DataAccess.Abstracts;
using KodlamaDev.DataAccess.Concretes;
using KodlamaDev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaDev.Business
{
    public class CourseManager: ICourseSevice
    {
        private readonly ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void AddCourse(Course course)
        {
            _courseDal.AddCourse(course);
            Console.WriteLine("\n" + course.CourseName + " Eklendi...");
        }

        public void GetCourseList()
        {
            foreach (var course in _courseDal.GetAll())
            {
                Console.WriteLine(course.CourseName + ": " + course.CourseDescription);
            }
        }

        public void DeleteCourse(Course course)
        {
            _courseDal.DeleteCourse(course);
            Console.WriteLine("\n" + course.CourseName + " Silindi...");
        }

        public Course GetCourseById(int Id)
        {
            return _courseDal.GetCourseById(Id);            
        }

        public Course GetCourseByName(string Name)
        {
            return _courseDal.GetCourseByName(Name);
        }

        public void UpdateCourse(Course course)
        {
            _courseDal.UpdateCourse(course);
            Console.WriteLine("\n" + course.CourseName + " Kursu Update Edildi...");
        }
    }
}
