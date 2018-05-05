using Ink.Core;
using Ink.Core.Repositories;
using Ink.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ink.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        //private readonly PlutoContext _context;
        private readonly TakesContext _context;
              
        public UnitOfWork(TakesContext context)
        {
            _context = context;
            Companys = new CompanyRepository(_context);
            Companys = new CompanyRepository(_context);
            Centers = new CenterRepository(_context);
            Takings = new TakingRepository(_context);
            
        }
        public ICompanyRepository Companys { get ; private set; }
        public ICenterRepository Centers { get ; private set; }
        public ITakingRepository Takings { get; private set; }
        
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
