using EventManagementSystem.Interfaces;
using EventManagementSystem.Models;

namespace EventManagementSystem.Commands
{
    public class AddEventCommand : ICommand
    {
        private readonly IEventService _eventService;
        private readonly Event _event;

        public AddEventCommand(IEventService eventService, Event evt)
        {
            _eventService = eventService;
            _event = evt;
        }

        public void Execute()
        {
            _eventService.AddEvent(_event);
        }
    }
}
