using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using EventManagementSystem.Models;

namespace EventManagementSystem.DataAccess
{
    public class JsonDataAccess
    {
        private const string UsersFilePath = "users.json";
        private const string EventsFilePath = "events.json";

        public List<User> LoadUsers()
        {
            if (!File.Exists(UsersFilePath)) return new List<User>();
            return JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(UsersFilePath)) ?? new List<User>();
        }

        public void SaveUsers(List<User> users)
        {
            File.WriteAllText(UsersFilePath, JsonConvert.SerializeObject(users, Formatting.Indented));
        }

        public List<Event> LoadEvents()
        {
            if (!File.Exists(EventsFilePath)) return new List<Event>();
            return JsonConvert.DeserializeObject<List<Event>>(File.ReadAllText(EventsFilePath)) ?? new List<Event>();
        }

        public void SaveEvents(List<Event> events)
        {
            File.WriteAllText(EventsFilePath, JsonConvert.SerializeObject(events, Formatting.Indented));
        }
    }
}
