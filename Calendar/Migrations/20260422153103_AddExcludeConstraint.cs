using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calendar.Migrations
{
    /// <inheritdoc />
    public partial class AddExcludeConstraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("CREATE EXTENSION IF NOT EXISTS btree_gist");
            migrationBuilder.Sql(@"ALTER TABLE ""Bookings"" ADD CONSTRAINT ""no_overlap"" EXCLUDE USING gist (""BookingLinkId"" WITH =, tstzrange(""StartTimeUtc"", ""EndTimeUtc"") WITH &&);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"ALTER TABLE ""Bookings"" DROP CONSTRAINT ""no_overlap""");
        }
    }
}
