using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class TestViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ModuleId { get; set; }
        public int TokenReward { get; set; }
        public Module Module { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<TokenTransaction> TokenTransactions { get; set; }
    }
}
