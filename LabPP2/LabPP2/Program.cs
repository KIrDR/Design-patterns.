using System;

namespace LabPP2
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University("Кирилл Алексеевич", "Жлобин", typeof(string));
            Faculty faculty = new Faculty("Павел ВОлк", "Минск", typeof(string));

            JobTitle jobTitle = new JobTitle();
            Department department = new Department();

            university.PrintInfo();

            university.AddFaculty(faculty);
            university.AddJobTitle(jobTitle);

            faculty.AddDepartment(department);
            faculty.AddJobTitle(jobTitle);
        }
    }
}
