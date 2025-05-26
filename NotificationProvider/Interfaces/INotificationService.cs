namespace NotificationProvider.Interfaces;

public interface INotificationService
{
    List<string> GetNotificationsForUser(string userId);
}
