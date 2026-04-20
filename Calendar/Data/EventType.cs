namespace Calendar.Data
{
    public class EventType
    {
        /// <summary>
        /// Gets or sets the unique identifier for the event type.
        /// </summary>
        /// <value>
        /// A <see cref="long"/> representing the unique identifier.
        /// </value>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user who owns this event type.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> representing the owner user ID.
        /// </value>
        public string OwnerId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the booking link GUID associated with this event type.
        /// </summary>
        /// <value>
        /// A <see cref="Guid"/> representing the booking link.
        /// </value>
        public Guid BookingLinkId { get; set; }

        /// <summary>
        /// Gets or sets the name of the event type.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> representing the event type name.
        /// </value>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the duration of events of this type.
        /// </summary>
        /// <value>
        /// A <see cref="TimeOnly"/> representing the event duration.
        /// </value>
        public TimeOnly Duration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is the default event type.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if this is the default event type; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or sets the owner of this event type.
        /// </summary>
        /// <value>
        /// An <see cref="ApplicationUser"/> representing the owner.
        /// </value>
        public ApplicationUser Owner { get; set; } = null!;
    }
}