using KodlamaDev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaDev.Business.Abstracts
{
    public interface ICourseSevice
    {
        void AddCourse(Course course);
        void GetCourseList();
        void DeleteCourse(Course course);
        Course GetCourseById(int Id);
        Course GetCourseByName(string Name);
        void UpdateCourse(Course course);
    }
}
