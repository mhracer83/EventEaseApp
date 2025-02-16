using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Data
{
    public class EventModel
    {
        [Required(ErrorMessage = "Event Name is required.")]
        public string EventName { get; set; }

        [Required(ErrorMessage = "Event Date is required.")]
        public DateTime EventDate { get; set; }

        [Required(ErrorMessage = "Event Location is required.")]
        public string EventLocation { get; set; }

        public List<Attendee> Attendees { get; set; } = new List<Attendee>();
    }

    public class Attendee
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        public bool IsAttending { get; set; }
    }
}
