using KodlamaDev.Business;
using KodlamaDev.DataAccess.Concretes;
using KodlamaDev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaDev
{
    public class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.CourseId = 1;
            course1.CourseName = "Java";
            course1.CourseDescription = "Java Yazılım Geliştirici Yetiştirme Kursu";
            course1.InstructorId = 1;

            Course course2 = new Course();
            course2.CourseId = 2;
            course2.CourseName = "C#";
            course2.CourseDescription = "C# Yazılım Geliştirici Yetiştirme Kursu";
            course2.InstructorId = 1;

            Course course3 = new Course();
            course3.CourseId = 3;
            course3.CourseName = "C++";
            course3.CourseDescription = "C++ Yazılım Geliştirici Yetiştirme Kursu";
            course3.InstructorId = 2;

            CourseManager courseManager = new CourseManager(new CourseDal());
            courseManager.AddCourse(course1);
            courseManager.AddCourse(course2);
            courseManager.AddCourse(course3);

            Console.WriteLine("\n--- Kurs Listesi ---");
            courseManager.GetCourseList();

            courseManager.DeleteCourse(course3);

            Console.WriteLine("\n--- Kurs Listesi ---");
            courseManager.GetCourseList();

            Console.WriteLine("\n--- ID'ye göre Kurs Arama ---");
            Console.WriteLine(courseManager.GetCourseById(1).CourseName);

            Console.WriteLine("\n--- İsme göre Kurs Arama ---");
            Console.WriteLine(courseManager.GetCourseByName("Java").CourseName);
            //Console.WriteLine(courseManager.GetCourseByName("java").CourseName);

            Console.WriteLine("\n--- Kurs Güncelleme ---");
            courseManager.UpdateCourse(new Course
            {
                CourseId = 1,
                CourseName = "Yeni Java",
                CourseDescription = "Spring Boot JAVA",
                InstructorId = 5,
            });

            Console.WriteLine("\n--- Kurs Listesi ---");
            courseManager.GetCourseList();

            Console.ReadLine();

        }
    }
}
