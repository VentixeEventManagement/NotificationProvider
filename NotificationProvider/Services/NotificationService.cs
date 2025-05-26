using NotificationProvider.Interfaces;

namespace NotificationProvider.Services;

public class NotificationService : INotificationService
{
    public List<string> GetNotificationsForUser(string userId)
    { 
        return userId == "cookie-userId"
            ? new List<string> { "Du har en ny bokning", "Faktura tillgänglig" }
            : new List<string>();
    }
}
