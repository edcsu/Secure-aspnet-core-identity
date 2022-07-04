using RazorPagesPizza.Areas.Identity.Data;
using RazorPagesPizza.Models;

namespace RazorPagesPizza.Services
{
    public class AuditEventService : IEventService
    {
        private readonly RazorPagesPizzaAuth _pizzaAuth;

        public AuditEventService(RazorPagesPizzaAuth pizzaAuth)
        {
            _pizzaAuth = pizzaAuth;
        }

        public void Raise(EventTypes evt)
        {
            var auditEvent = UserAudit.CreateAuditEvent(
                userId: string.Empty,
                auditEventType: evt,
                ipAddress: string.Empty
                );
            //_pizzaAuth.UserAuditEvents.Add(auditEvent);
            _pizzaAuth.SaveChangesAsync();
        }
    }
}
