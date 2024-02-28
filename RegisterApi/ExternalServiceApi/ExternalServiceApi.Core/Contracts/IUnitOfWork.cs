using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalServiceApi.Core.Contracts
{
    public interface IUnitOfWork
    {
        IUserDataRepository UserDataRepository { get; }
    }
}
