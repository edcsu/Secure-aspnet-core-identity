using RazorPagesPizza.Models;

namespace RazorPagesPizza.Services
{
    public interface IEventService
    {
        public void Raise(EventTypes evt);
    }
}
