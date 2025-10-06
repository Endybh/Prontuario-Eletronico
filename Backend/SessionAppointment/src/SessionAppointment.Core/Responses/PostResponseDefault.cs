// ReSharper disable All
namespace SessionAppointment.Core.Application.Responses;

public class PostResponseDefault
{
    public Guid EntityId { get; set; }
    public string Message { get; set; } = string.Empty;
}
