using Application;
using Persistence;
using Persistence.Mocks;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ITelegramBotClient>(new TelegramBotClient("8027671136:AAEALMGVbDxK2EiFpBmKMkk92Cl29G6c-84"));
builder.Services.AddApplication();
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddSingleton<CourseMockRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Запуск Long Polling 
StartBotPolling(app.Services);

app.Run();

void StartBotPolling(IServiceProvider services)
{
    var botClient = services.GetRequiredService<ITelegramBotClient>();

    botClient.StartReceiving(
        HandleUpdateAsync,
        HandleErrorAsync,
        new Telegram.Bot.Polling.ReceiverOptions(),
        cancellationToken: CancellationToken.None
    );

    Console.WriteLine("Bot is running... Press any key to exit.");
}

async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
{
    if (update.Type == UpdateType.Message && update.Message is not null)
    {
        var chatId = update.Message.Chat.Id;

        if (update.Message.Text == "/start")
        {
            var replyMarkup = new InlineKeyboardMarkup(new[]
            {
                InlineKeyboardButton.WithUrl("Перейти к мини-приложению", "https://altynbek13.github.io/DecentrathonTelegramLMSApp/")
            });

            await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Добро пожаловать! Нажмите на кнопку ниже, чтобы перейти в мини-приложение:",
                replyMarkup: replyMarkup,
                cancellationToken: cancellationToken
            );
        }
    }
}

// Обработчик ошибок
Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
{
    Console.WriteLine($"Ошибка: {exception.Message}");
    return Task.CompletedTask;
}
