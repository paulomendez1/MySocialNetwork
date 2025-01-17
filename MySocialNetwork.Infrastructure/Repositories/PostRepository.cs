﻿using Microsoft.EntityFrameworkCore;
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
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(SocialMediaContext context) : base(context){ }
        public async Task<IEnumerable<Post>> GetPostsByUser(int iduser)
        {
            return await _entities.Where(x => x.IdUser == iduser).ToListAsync();
        }
    }
}
