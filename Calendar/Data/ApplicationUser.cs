using Microsoft.AspNetCore.Identity;

namespace Calendar.Data
{
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// Gets or sets the public booking link GUID for this user.
        /// </summary>
        /// <value>
        /// A <see cref="Guid"/> representing the public booking link.
        /// </value>
        public Guid BookingLinkId { get; set; }

        /// <summary>
        /// Gets or sets the user's preferred timezone.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> representing the IANA timezone ID.
        /// </value>
        public string TimeZoneId { get; set; } = "UTC";

        /// <summary>
        /// Gets or sets the start time for Monday.
        /// </summary>
        /// <value>
        /// A <see cref="TimeOnly"/> representing the start time, or default if not working.
        /// </value>
        public TimeOnly MonStart { get; set; }

        /// <summary>
        /// Gets or sets the end time for Monday.
        /// </summary>
        /// <value>
        /// A <see cref="TimeOnly"/> representing the end time, or default if not working.
        /// </value>
        public TimeOnly MonEnd { get; set; }

        /// <summary>Gets or sets the start time for Tuesday.</summary>
        public TimeOnly TueStart { get; set; }

        /// <summary>Gets or sets the end time for Tuesday.</summary>
        public TimeOnly TueEnd { get; set; }

        /// <summary>Gets or sets the start time for Wednesday.</summary>
        public TimeOnly WedStart { get; set; }

        /// <summary>Gets or sets the end time for Wednesday.</summary>
        public TimeOnly WedEnd { get; set; }

        /// <summary>Gets or sets the start time for Thursday.</summary>
        public TimeOnly ThuStart { get; set; }

        /// <summary>Gets or sets the end time for Thursday.</summary>
        public TimeOnly ThuEnd { get; set; }

        /// <summary>Gets or sets the start time for Friday.</summary>
        public TimeOnly FriStart { get; set; }

        /// <summary>Gets or sets the end time for Friday.</summary>
        public TimeOnly FriEnd { get; set; }

        /// <summary>Gets or sets the start time for Saturday.</summary>
        public TimeOnly SatStart { get; set; }

        /// <summary>Gets or sets the end time for Saturday.</summary>
        public TimeOnly SatEnd { get; set; }

        /// <summary>Gets or sets the start time for Sunday.</summary>
        public TimeOnly SunStart { get; set; }

        /// <summary>Gets or sets the end time for Sunday.</summary>
        public TimeOnly SunEnd { get; set; }

        /// <summary>Gets or sets the event types owned by this user.</summary>
        public ICollection<EventType> EventTypes { get; set; } = new List<EventType>();

        /// <summary>Gets or sets the bookings owned by this user.</summary>
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}