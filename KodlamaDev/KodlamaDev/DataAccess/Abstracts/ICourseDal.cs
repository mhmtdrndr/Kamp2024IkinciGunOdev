using KodlamaDev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KodlamaDev.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        void AddCourse(Course course);
        void DeleteCourse(Course course);
        List<Course> GetAll();
        Course GetCourseById(int id);
        Course GetCourseByName(string name);
        void UpdateCourse(Course course);
    }
}
