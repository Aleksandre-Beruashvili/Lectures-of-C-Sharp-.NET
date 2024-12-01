using System;
using System.Collections.Generic;
using EventManagementSystem.Models;

namespace EventManagementSystem.Interfaces
{
    public interface IEventService
    {
        void AddEvent(Event evt);
        List<Event> SearchEventByTitle(string title);
        List<Event> FilterEventsByDate(DateTime date);
    }
}
