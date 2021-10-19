using MySocialNetwork.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPostRepository PostRepository { get; }
        IRepository<User> UserRepository { get; }
        IRepository<Comment> CommentRepository { get; }
        ISecurityRepository SecurityRepository { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
