using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }
        public int TokenReward { get; set; }
        public virtual Course Course { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<TokenTransaction> TokenTransactions { get; set; }
    }
}
