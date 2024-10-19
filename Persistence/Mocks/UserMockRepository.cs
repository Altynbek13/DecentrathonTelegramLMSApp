using Domain.Entities;

namespace Persistence.Mocks
{
    public class UserMockRepository
    {
        public List<User> Users { get; set; } = new();
        public UserMockRepository() 
        {
            // Инициализация пользователей
            Users.Add(new User { Id = 1, Username = "@meirkhan03", EarnedTokens = 100 });
            Users.Add(new User { Id = 2, Username = "@raydan03", EarnedTokens = 200 });
            Users.Add(new User { Id = 3, Username = "@agataikk", EarnedTokens = 250 });
            Users.Add(new User { Id = 4, Username = "@altoshzh", EarnedTokens = 150 });
            Users.Add(new User { Id = 5, Username = "@kurmash", EarnedTokens = 80 });
        }
    }
}
