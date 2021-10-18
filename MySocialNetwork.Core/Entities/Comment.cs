using System;
using System.Collections.Generic;

#nullable disable

namespace MySocialNetwork.Core.Entities
{
    public partial class Comment : BaseEntity
    {
        public int IdPost { get; set; }
        public int IdUser { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool State { get; set; }

        public virtual Post IdPostNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
