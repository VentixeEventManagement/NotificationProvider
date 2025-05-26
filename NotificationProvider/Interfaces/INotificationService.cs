namespace NotificationProvider.Interfaces;

// Genererat med hjälp av ChatGPT – OpenAI.
public interface INotificationService
{
    List<string> GetNotificationsForUser(string userId);
}
