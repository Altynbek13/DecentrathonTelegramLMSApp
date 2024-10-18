using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<LLMIntegration> LLMIntegrations { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuestTask> QuestTasks { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TokenTransaction> TokenTransactions { get; set; }
        public DbSet<User> User { get; set; }
        public int SaveChanges();
    }
}
