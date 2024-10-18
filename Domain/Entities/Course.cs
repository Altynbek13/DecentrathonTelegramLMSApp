using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TokenReward {  get; set; }

        public virtual ICollection<Module> Modules { get; set; }
        public virtual ICollection<Quest> Quests { get; set; }
        public virtual ICollection<TokenTransaction> TokenTransaction { get; set; }
    }
}
