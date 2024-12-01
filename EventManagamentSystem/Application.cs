using System;
using EventManagementSystem.Commands;
using EventManagementSystem.DataAccess;
using EventManagementSystem.Models;
using EventManagementSystem.Services;
using EventManagementSystem.Interfaces;

namespace EventManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataAccess = new JsonDataAccess();
            var userService = new UserService(dataAccess);
            var eventService = new EventService(dataAccess);

            while (true)
            {
                Console.WriteLine("\nEvent Management System");
                Console.WriteLine("1. Register User");
                Console.WriteLine("2. Add Event");
                Console.WriteLine("3. Search Event by Title");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                var choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            RegisterUser(userService);
                            break;
                        case "2":
                            AddEvent(eventService);
                            break;
                        case "3":
                            SearchEvent(eventService);
                            break;
                        case "4":
                            return;
                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        static void RegisterUser(IUserService userService)
        {
            Console.Write("Enter Name: ");
            var name = Console.ReadLine();

            Console.Write("Enter Email: ");
            var email = Console.ReadLine();

            Console.Write("Enter Password: ");
            var password = Console.ReadLine();

            var user = new User { Name = name, Email = email, Password = password };
            var command = new RegisterUserCommand(userService, user);
            command.Execute();

            Console.WriteLine("User registered successfully.");
        }

        static void AddEvent(IEventService eventService)
        {
            Console.Write("Enter Event Name: ");
            var name = Console.ReadLine();

            Console.Write("Enter Description: ");
            var description = Console.ReadLine();

            Console.Write("Enter Location: ");
            var location = Console.ReadLine();

            Console.Write("Enter Date and Time (yyyy-MM-dd HH:mm): ");
            var dateTime = DateTime.Parse(Console.ReadLine());

            var evt = new Event { Name = name, Description = description, Location = location, DateAndTime = dateTime };
            var command = new AddEventCommand(eventService, evt);
            command.Execute();

            Console.WriteLine("Event added successfully.");
        }

        static void SearchEvent(IEventService eventService)
        {
            Console.Write("Enter Event Title to Search: ");
            var title = Console.ReadLine();

            var events = eventService.SearchEventByTitle(title);

            if (events.Count > 0)
            {
                Console.WriteLine("\nMatching Events:");
                foreach (var evt in events)
                {
                    Console.WriteLine($"ID: {evt.EventId}, Name: {evt.Name}, Date: {evt.DateAndTime}, Status: {evt.Status}");
                }
            }
            else
            {
                Console.WriteLine("No matching events found.");
            }
        }
    }
}
