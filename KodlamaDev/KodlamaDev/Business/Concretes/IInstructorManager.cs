using KodlamaDev.Business.Abstracts;
using KodlamaDev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaDev.Business.Concretes
{
    public class IInstructorManager: IInstructorService
    {
        private readonly IInstructorManager _instructorManager;
        public IInstructorManager(IInstructorManager instructorManager) {
            _instructorManager = instructorManager;
        }

        public void AddInstructor(Instructor instructor)
        {
            _instructorManager.AddInstructor(instructor);
            Console.WriteLine("\n" + instructor.FirstName + " Eklendi...");
        }

        public void DeleteInstructor(Instructor instructor)
        {
            _instructorManager.DeleteInstructor(instructor);
            Console.WriteLine("\n" + instructor.FirstName + " Silindi...");
        }

        public List<Instructor> GetAll()
        {
            return _instructorManager.GetAll();
        }

        public Instructor GetInstructorById(int Id)
        {
            return _instructorManager.GetInstructorById(Id);
        }

        public Instructor GetInstructorByName(string Name)
        {
            return _instructorManager.GetInstructorByName(Name);
        }

        public void UpdateInstructor(Instructor instructor)
        {
            _instructorManager.UpdateInstructor(instructor);
        }
    }
}
