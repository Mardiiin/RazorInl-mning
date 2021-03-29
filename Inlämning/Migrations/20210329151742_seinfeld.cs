using Microsoft.EntityFrameworkCore.Migrations;

namespace Inlämning.Migrations
{
    public partial class seinfeld : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Organizer_OrganizerID",
                table: "Event");

            migrationBuilder.DropTable(
                name: "EventJoined");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Organizer",
                table: "Organizer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Event",
                table: "Event");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendee",
                table: "Attendee");

            migrationBuilder.RenameTable(
                name: "Organizer",
                newName: "Organizers");

            migrationBuilder.RenameTable(
                name: "Event",
                newName: "Events");

            migrationBuilder.RenameTable(
                name: "Attendee",
                newName: "Attendees");

            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "Organizers",
                newName: "PhoneNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Event_OrganizerID",
                table: "Events",
                newName: "IX_Events_OrganizerID");

            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organizers",
                table: "Organizers",
                column: "OrganizerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "EventID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendees",
                table: "Attendees",
                column: "AttendeeID");

            migrationBuilder.CreateTable(
                name: "AttendeeEvent",
                columns: table => new
                {
                    AttendeeID = table.Column<int>(type: "int", nullable: false),
                    EventsEventID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendeeEvent", x => new { x.AttendeeID, x.EventsEventID });
                    table.ForeignKey(
                        name: "FK_AttendeeEvent_Attendees_AttendeeID",
                        column: x => x.AttendeeID,
                        principalTable: "Attendees",
                        principalColumn: "AttendeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttendeeEvent_Events_EventsEventID",
                        column: x => x.EventsEventID,
                        principalTable: "Events",
                        principalColumn: "EventID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttendeeEvent_EventsEventID",
                table: "AttendeeEvent",
                column: "EventsEventID");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Organizers_OrganizerID",
                table: "Events",
                column: "OrganizerID",
                principalTable: "Organizers",
                principalColumn: "OrganizerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Organizers_OrganizerID",
                table: "Events");

            migrationBuilder.DropTable(
                name: "AttendeeEvent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Organizers",
                table: "Organizers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendees",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "Place",
                table: "Events");

            migrationBuilder.RenameTable(
                name: "Organizers",
                newName: "Organizer");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "Event");

            migrationBuilder.RenameTable(
                name: "Attendees",
                newName: "Attendee");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Organizer",
                newName: "phoneNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Events_OrganizerID",
                table: "Event",
                newName: "IX_Event_OrganizerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organizer",
                table: "Organizer",
                column: "OrganizerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Event",
                table: "Event",
                column: "EventID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendee",
                table: "Attendee",
                column: "AttendeeID");

            migrationBuilder.CreateTable(
                name: "EventJoined",
                columns: table => new
                {
                    EventJoinID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendeeID = table.Column<int>(type: "int", nullable: false),
                    EventID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventJoined", x => x.EventJoinID);
                    table.ForeignKey(
                        name: "FK_EventJoined_Attendee_AttendeeID",
                        column: x => x.AttendeeID,
                        principalTable: "Attendee",
                        principalColumn: "AttendeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventJoined_Event_EventID",
                        column: x => x.EventID,
                        principalTable: "Event",
                        principalColumn: "EventID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventJoined_AttendeeID",
                table: "EventJoined",
                column: "AttendeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EventJoined_EventID",
                table: "EventJoined",
                column: "EventID");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Organizer_OrganizerID",
                table: "Event",
                column: "OrganizerID",
                principalTable: "Organizer",
                principalColumn: "OrganizerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
