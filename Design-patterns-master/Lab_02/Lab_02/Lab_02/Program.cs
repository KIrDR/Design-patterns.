using LabPP2;

namespace Lab_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University university = new University("БГТУ", "Свердлова 13а", typeof(string));
            Faculty faculty = new Faculty("ФИТ", "Деканат", typeof(string));

            JobTitle jobTitle = new JobTitle();
            Department department = new Department();

            Organization organization = new Organization();
            Console.WriteLine(organization.Id);
            Console.WriteLine(organization.Name);

            //organization.Id = 2;
            //organization.Name = "a";


            university.PrintInfo();

            university.AddFaculty(faculty);
            try
            {
                university.AddJobTitle(jobTitle);
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                faculty.AddDepartment(department);
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                faculty.AddJobTitle(jobTitle);
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                university.Dismiss(new Reason());
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}