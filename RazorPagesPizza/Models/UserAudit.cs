using System.ComponentModel.DataAnnotations;

namespace RazorPagesPizza.Models
{
    public class UserAudit
    {
        [Key]
        public Guid Id { get; private set; }

        [Required]
        public string UserId { get; private set; } = string.Empty;

        [Required]
        public DateTime Timestamp { get; private set; } = DateTime.UtcNow;

        [Required]
        public EventTypes AuditEvent { get; set; }

        public string IpAddress { get; private set; } = string.Empty;

        public static UserAudit CreateAuditEvent(string userId, EventTypes auditEventType, string ipAddress)
        {
            return new UserAudit { UserId = userId, AuditEvent = auditEventType, IpAddress = ipAddress };
        }
    }

    public enum EventTypes 
    { 
        Success = 1,
        Failure = 2,
        Information = 3,
        Error = 4
    }
}
