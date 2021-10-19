using Microsoft.EntityFrameworkCore;
using MySocialNetwork.Core.Entities;
using MySocialNetwork.Core.Interfaces;
using MySocialNetwork.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Infrastructure.Repositories
{
    public class SecurityRepository : BaseRepository<Security> , ISecurityRepository
    {
        public SecurityRepository(SocialMediaContext context) : base(context) { }

        public async Task<Security> GetLoginByCredentials(UserLogin login)
        {
            return await _entities.FirstOrDefaultAsync(x => x.User == login.User && x.Password == login.Password);
        }
      
    }
}
