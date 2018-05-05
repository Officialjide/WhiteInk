using Ink.Core;
using Ink.Core.Domain;
using Ink.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ink.Infrastructure.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(TakesContext context) 
            : base(context)
        {

        }

        public TakesContext TakesContext
        {
            get { return Context as TakesContext; }
        }

        //for superadmin
        public IEnumerable<Company> GetAllCompaniesWithCenters(int pageIndex, int pageSize = 10)
        {
            return TakesContext.Companys
            .Include(c=> c.Centers)
            .OrderBy(c => c.Name)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToList();
            /*var blogs = context.Blogs
        .Include(blog => blog.Posts)
            .ThenInclude(post => post.Author)
        .ToList();*/
            //OR
            /*var blogs = context.Blogs
            .Include(blog => blog.Posts)
                .ThenInclude(post => post.Author)
                    .ThenInclude(author => author.Photo)
            .ToList();*/
        }

        public Company GetCompanyWithCenters(int Companyid)
        {
            return TakesContext.Companys
            .Include(ct => ct.Centers)
            .SingleOrDefault(cm => cm.Id == Companyid);
            
        }

        public Company GetCompanyWithUsers(int Companyid)
        {
            return TakesContext.Companys            
            .Include(c=> c.CompanyUsers)
            //.Include(c=> c.User) // maybe not work
            .SingleOrDefault(c => c.Id == Companyid);
            
        }
    }
}
