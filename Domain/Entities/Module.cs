using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Module
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }
        public int TokenReward { get; set; }
        public virtual Course Course { get; set; }
        public virtual ICollection<Lecture> Lectures { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<TokenTransaction> TokenTransactions { get; set; }
    }
}
