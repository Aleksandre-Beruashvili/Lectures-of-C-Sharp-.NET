using System;
using EventManagementSystem.Models;

namespace EventManagementSystem.Validation
{
    public static class EventValidation
    {
        public static void ValidateEvent(Event evt)
        {
            if (string.IsNullOrWhiteSpace(evt.Name) || evt.Name.Length > 100)
                throw new Exception("Event name must be between 1 and 100 characters.");

            if (string.IsNullOrWhiteSpace(evt.Description) || evt.Description.Length > 4000)
                throw new Exception("Event description must be between 1 and 4000 characters.");

            if (evt.DateAndTime < DateTime.Now)
                throw new Exception("Event date cannot be in the past.");

            if (string.IsNullOrWhiteSpace(evt.Location) || evt.Location.Length > 200)
                throw new Exception("Event location must be between 1 and 200 characters.");
        }
    }
}
