using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPP2
{
    public class Organization : IStaff
    {
        public int Id { get; private set; }
        public string Name { get; protected set; }
        public Type ShortName { get; protected set; }
        public string Address { get; protected set; }
        public DateTime TimeStamp { get; protected set; }

        public Organization()
        {

        }

        public Organization(Organization organization)
        {
            Name = organization.Name;
            ShortName = organization.ShortName;
            Address = organization.Address;
        }

        public Organization(string _name, string address, Type shortName)
        {
            Name = _name;
            ShortName = shortName;
            Address = address;
        }

        public void PrintInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Address);
            Console.WriteLine(ShortName);
        }

        public List<JobVacancy> GetJobVacancies()
        {
            throw new NotImplementedException();
        }

        public int OpenJobVacancy(JobVacancy jobVacancy)
        {
            throw new NotImplementedException();
        }

        public bool CloseJobVacancy(int index)
        {
            throw new NotImplementedException();
        }

        public int AddJobTitle(JobTitle jobTitle)
        {
            throw new NotImplementedException();
        }

        public bool DelJobTitle(int index)
        {
            throw new NotImplementedException();
        }

        public Emploee Recruit(JobVacancy job, Person person)
        {
            throw new NotImplementedException();
        }

        public void Dismiss(Reason reason)
        {
            throw new NotImplementedException();
        }
    }
}
