using System.Collections.Generic;
using System.Linq;

namespace FormApplication.Models
{
    public class MockApplicantRepository : IApplicantRepository
    {
        private readonly List<Applicant> _applicantList;

        public MockApplicantRepository()
        {
            _applicantList = new List<Applicant>()
            {
                new Applicant() {Id = 1, Name = "John", Email = "johndoe@gmail.com", Department = Dept.Security}
            };
        }

        public Applicant CreateApplicant(Applicant applicant)
        {
            applicant.Id = _applicantList.Max(e => e.Id) + 1;
            _applicantList.Add(applicant);
            return applicant;
        }

        public Applicant GetApplicant(int id)
        {
            return _applicantList.FirstOrDefault(e => e.Id == id);
        }
    }
}
