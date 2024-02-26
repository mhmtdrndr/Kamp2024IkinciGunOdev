using KodlamaDev.DataAccess.Abstracts;
using KodlamaDev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaDev.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        public List<Instructor> instructors;
        public InstructorDal()
        {

            //inmemory data örnek
            Instructor instructor = new Instructor();
            instructor.Id = 100;
            instructor.FirstName = "Engin";
            instructor.LastName = "Demiroğ";
            instructor.Email = "engin@kodlama.io";

            instructors = new List<Instructor> { instructor };
        }

        public void AddInstructor(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public void DeleteInstructor(Instructor instructor)
        {
            instructors.Remove(instructor);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public Instructor GetInstructorById(int Id)
        {
            foreach (var i in instructors)
            {
                if (i.Id == Id)
                {
                    return i;

                }
            }
            throw new Exception(Id + " id'li Eğitmen bulunamadı ....");
        }

        public Instructor GetInstructorByName(string Name)
        {
            foreach (var i in instructors)
            {
                if (i.FirstName == Name)
                {
                    return i;

                }
            }
            throw new Exception(Name + " isimli Eğitmen bulunamadı ....");
        }

        public void UpdateInstructor(Instructor instructor)
        {
            var UpdateInstructor = GetInstructorById(instructor.Id);
            if (UpdateInstructor != null)
            {
                UpdateInstructor.Id = instructor.Id;
                UpdateInstructor.FirstName = instructor.FirstName;
                UpdateInstructor.LastName = instructor.LastName;
                UpdateInstructor.Email = instructor.Email;
            }
            else
            {
                throw new Exception(instructor.Id + " id'li Eğitmen bulunamadı ....");
            }
        }
    }
}
