using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TokenTransaction
    {
        public int Id { get; set; }
        public int AmountTokens { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public int? QuestId { get; set; }
        public virtual Quest Quest { get; set; }
        public int? CourseId { get; set; }
        public virtual Course Course { get; set; }
        public int? ModuleId { get; set; }
        public virtual Module Module { get; set; }
        public int? LectureId { get; set; }
        public virtual Lecture Lecture { get; set; }
        public int? AssignmentId { get; set; }
        public virtual Assignment Assignment { get; set; }
        public int? QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }
        public int? TestId { get; set; }
        public virtual Test Test { get; set; }
    }
}
