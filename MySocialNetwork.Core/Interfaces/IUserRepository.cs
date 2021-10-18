using MySocialNetwork.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUser(int id);

        Task<IEnumerable<User>> GetUsers();
    }
}
