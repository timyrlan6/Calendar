using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Calendar.Migrations
{
    /// <inheritdoc />
    public partial class AddBookingTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BookingLinkId",
                table: "AspNetUsers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "FriEnd",
                table: "AspNetUsers",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "FriStart",
                table: "AspNetUsers",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "MonEnd",
                table: "AspNetUsers",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "MonStart",
                table: "AspNetUsers",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "SatEnd",
                table: "AspNetUsers",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "SatStart",
                table: "AspNetUsers",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "SunEnd",
                table: "AspNetUsers",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "SunStart",
                table: "AspNetUsers",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "ThuEnd",
                table: "AspNetUsers",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "ThuStart",
                table: "AspNetUsers",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "TimeZoneId",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeOnly>(
                name: "TueEnd",
                table: "AspNetUsers",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "TueStart",
                table: "AspNetUsers",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "WedEnd",
                table: "AspNetUsers",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "WedStart",
                table: "AspNetUsers",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BookingLinkId = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<string>(type: "text", nullable: false),
                    GuestName = table.Column<string>(type: "text", nullable: false),
                    GuestEmail = table.Column<string>(type: "text", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    StartTimeUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTimeUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EventTypeName = table.Column<string>(type: "text", nullable: false),
                    EventDuration = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    GuestTimeZoneId = table.Column<string>(type: "text", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OwnerId = table.Column<string>(type: "text", nullable: false),
                    BookingLinkId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Duration = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    IsDefault = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventTypes_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BookingLinkId",
                table: "AspNetUsers",
                column: "BookingLinkId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BookingLinkId",
                table: "Bookings",
                column: "BookingLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_OwnerId",
                table: "Bookings",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTypes_BookingLinkId",
                table: "EventTypes",
                column: "BookingLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTypes_OwnerId",
                table: "EventTypes",
                column: "OwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BookingLinkId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BookingLinkId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FriEnd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FriStart",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MonEnd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MonStart",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SatEnd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SatStart",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SunEnd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SunStart",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ThuEnd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ThuStart",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TimeZoneId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TueEnd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TueStart",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "WedEnd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "WedStart",
                table: "AspNetUsers");
        }
    }
}
