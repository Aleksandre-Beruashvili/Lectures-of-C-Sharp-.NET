using System;

namespace EventManagementSystem.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Location { get; set; }
        public EventStatus Status { get; set; }
    }

    public enum EventStatus
    {
        Active, Postponed, Completed, Cancelled
    }
}
