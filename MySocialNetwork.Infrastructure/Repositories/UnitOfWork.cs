﻿using MySocialNetwork.Core.Entities;
using MySocialNetwork.Core.Interfaces;
using MySocialNetwork.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SocialMediaContext _context;
        private readonly IPostRepository _postRepository;
        private readonly IRepository<Comment> _commentRepository;
        private readonly IRepository<User> _userRepository;
        private readonly ISecurityRepository _securityRepository;
        public UnitOfWork(SocialMediaContext context)
        {
            _context = context;
        }
        public IPostRepository PostRepository => _postRepository ?? new PostRepository(_context);

        public IRepository<User> UserRepository => _userRepository ?? new BaseRepository<User>(_context);

        public IRepository<Comment> CommentRepository => _commentRepository ?? new BaseRepository<Comment>(_context);

        public ISecurityRepository SecurityRepository => _securityRepository ?? new SecurityRepository(_context);

        public void Dispose()
        {
            if (_context!=null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
