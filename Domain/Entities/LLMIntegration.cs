using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class LLMIntegration
    {
        public int Id { get; set; } // Уникальный идентификатор интеграции

        public string ModelName { get; set; } // Название используемой модели LLM (например, GPT-3, GPT-4 и т. д.)

        public string ApiKey { get; set; } // API-ключ для доступа к сервису LLM

        public string ApiEndpoint { get; set; } // Эндпоинт для выполнения запросов к сервису LLM

        public string PromptTemplate { get; set; } // Шаблон запросов, отправляемых в LLM

        public DateTime CreatedDate { get; set; } // Дата создания интеграции

        // Опционально: аналитика или настройки
        public int MaxTokens { get; set; } // Максимальное количество токенов для генерации
        public double Temperature { get; set; } // Температура выборки для генерации ответов
        public string UserId { get; set; } // Опционально: связь с пользователем, настроившим интеграцию
        public virtual User User { get; set; } // Навигационное свойство для пользователя
    }
}
