using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class QuestTask
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Status { get; set; } 

        public int QuestId { get; set; }
        public virtual Quest Quest { get; set; }
    }
}
