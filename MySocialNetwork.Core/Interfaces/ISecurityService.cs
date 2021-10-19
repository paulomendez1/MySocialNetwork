using MySocialNetwork.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Core.Interfaces
{
    public interface ISecurityService
    {
        Task<Security> GetLoginByCredentials(UserLogin login);

        Task RegisterUser(Security security);


    }
}
