using Ink.Core.Repositories;
using System;

namespace Ink.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICompanyRepository Companys { get; }
        ICenterRepository Centers { get; }
        ITakingRepository Takings { get; }
        int Complete();
    }
}
