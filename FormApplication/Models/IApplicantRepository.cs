namespace FormApplication.Models
{
    public interface IApplicantRepository
    {
        Applicant CreateApplicant(Applicant applicant);
        Applicant GetApplicant(int id);
    }
}
