namespace Calendar.Data
{
    public class Booking
    {
        /// <summary>
        /// Gets or sets the unique identifier for the booking.
        /// </summary>
        /// <value>
        /// A <see cref="Guid"/> representing the unique identifier of the booking.
        /// </value>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets or sets the unique identifier associated with the booking link.
        /// </summary>
        /// <remarks>
        /// This property is used to associate a booking with a specific booking link.
        /// It is indexed for efficient lookups and is used in relationships with other entities.
        /// </remarks>
        public Guid BookingLinkId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user who owns this booking.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> representing the owner user ID.
        /// </value>
        public string OwnerId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the guest who made the booking.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> representing the guest name.
        /// </value>
        public string GuestName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the email of the guest who made the booking.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> representing the guest email.
        /// </value>
        public string GuestEmail { get; set; } = null!;

        /// <summary>
        /// Gets or sets additional notes from the guest.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> containing notes, or <see langword="null"/> if none.
        /// </value>
        public string? Notes { get; set; }

        /// <summary>
        /// Gets or sets the start time of the booking in UTC.
        /// </summary>
        /// <value>
        /// A <see cref="DateTime"/> representing the start time in UTC.
        /// </value>
        public DateTime StartTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets the end time of the booking in UTC.
        /// </summary>
        /// <value>
        /// A <see cref="DateTime"/> representing the end time in UTC.
        /// </value>
        public DateTime EndTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets the name of the event type for this booking.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> representing the event type name.
        /// </value>
        public string EventTypeName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the duration of the booked event.
        /// </summary>
        /// <value>
        /// A <see cref="TimeOnly"/> representing the event duration.
        /// </value>
        public TimeOnly EventDuration { get; set; }

        /// <summary>
        /// Gets or sets the timezone of the guest.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> representing the IANA timezone ID.
        /// </value>
        public string GuestTimeZoneId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the timestamp when the booking was created in UTC.
        /// </summary>
        /// <value>
        /// A <see cref="DateTime"/> representing the creation timestamp in UTC.
        /// </value>
        public DateTime CreatedAtUtc { get; set; }

        /// <summary>
        /// Gets or sets the owner of this booking.
        /// </summary>
        /// <value>
        /// An <see cref="ApplicationUser"/> representing the booking owner.
        /// </value>
        public ApplicationUser Owner { get; set; } = null!;
    }
}