using Microsoft.AspNetCore.Mvc;
using NotificationProvider.Interfaces;

[ApiController]
[Route("api/[controller]")]
public class NotificationsController : ControllerBase
{
    private readonly INotificationService _notificationService;

    public NotificationsController(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    [HttpGet]
    public IActionResult Get([FromQuery] string userId)
    {
        var notifications = _notificationService.GetNotificationsForUser(userId);
        return Ok(new
        {
            hasNew = notifications.Any(),
            notifications = notifications.Select(n => new { message = n })
        });
    }
}