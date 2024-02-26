using KodlamaDev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaDev.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        void AddInstructor(Instructor instructor);
        void DeleteInstructor(Instructor instructor);
        List<Instructor> GetAll();
        Instructor GetInstructorById(int Id);
        Instructor GetInstructorByName(string Name);
        void UpdateInstructor(Instructor instructor);
    }
}
