using EventManagementSystem.DataAccess;
using EventManagementSystem.Interfaces;
using EventManagementSystem.Models;
using EventManagementSystem.Validation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EventManagementSystem.Services
{
    public class EventService : IEventService
    {
        private readonly JsonDataAccess _dataAccess;

        public EventService(JsonDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void AddEvent(Event evt)
        {
            EventValidation.ValidateEvent(evt);

            var events = _dataAccess.LoadEvents();

            evt.EventId = events.Any() ? events.Max(e => e.EventId) + 1 : 1;
            evt.Status = EventStatus.Active;
            events.Add(evt);
            _dataAccess.SaveEvents(events);
        }

        public List<Event> SearchEventByTitle(string title)
        {
            var events = _dataAccess.LoadEvents();
            return events
                .Where(e => e.Status == EventStatus.Active && e.Name.Contains(title, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<Event> FilterEventsByDate(DateTime date)
        {
            var events = _dataAccess.LoadEvents();
            return events.Where(e => e.Status == EventStatus.Active && e.DateAndTime.Date == date.Date).ToList();
        }
    }
}
