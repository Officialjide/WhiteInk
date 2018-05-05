using Ink.Core.Domain;
using System.Collections.Generic;

namespace Ink.Core.Repositories
{
    public interface ICompanyRepository : IRepository<Company>
    {
        //IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize);
        IEnumerable<Company> GetAllCompaniesWithCenters(int pageIndex, int pageSize); //for superadmin
        //Author GetAuthorWithCourses(int id);
        Company GetCompanyWithCenters(int Companyid);
        Company GetCompanyWithUsers(int Companyid);// id is the company id
        //getuserwithcompany

    }
}
