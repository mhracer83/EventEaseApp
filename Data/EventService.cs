
namespace EventEaseApp.Data
{
    public class EventService
    {
        private List<EventModel> events = new List<EventModel>
        {
            new EventModel { EventName = "Corporate Meeting", EventDate = DateTime.Now.AddDays(10), EventLocation = "New York" },
            new EventModel { EventName = "Product Launch", EventDate = DateTime.Now.AddDays(20), EventLocation = "San Francisco" },
            new EventModel { EventName = "Team Building Retreat", EventDate = DateTime.Now.AddDays(30), EventLocation = "Miami" }
        };

        public List<EventModel> GetEvents()
        {
            return events;
        }

        public void AddEvent(EventModel newEvent)
        {
            events.Add(newEvent);
        }

        public void DeleteEvent(string eventName)
        {
            var eventToDelete = events.FirstOrDefault(e => e.EventName == eventName);
            if (eventToDelete != null)
            {
                events.Remove(eventToDelete);
            }
        }

        public void AddAttendee(string eventName, Attendee attendee)
        {
            var eventModel = events.FirstOrDefault(e => e.EventName == eventName);
            if (eventModel != null)
            {
                eventModel.Attendees.Add(attendee);
            }
        }
    }
}
