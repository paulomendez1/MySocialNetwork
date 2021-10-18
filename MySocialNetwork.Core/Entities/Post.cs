using System;
using System.Collections.Generic;

#nullable disable

namespace MySocialNetwork.Core.Entities
{
    public partial class Post : BaseEntity
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }
        public int IdUser { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public virtual User IdUserNavigation { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
