using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaferSpacesApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    PlaceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    RestroomFeatures = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.PlaceId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    EventDate = table.Column<DateTime>(nullable: false),
                    EventTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    PlaceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "PlaceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    TestimonialId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Story = table.Column<string>(nullable: true),
                    Management = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    EventId = table.Column<int>(nullable: true),
                    PlaceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.TestimonialId);
                    table.ForeignKey(
                        name: "FK_Testimonials_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Testimonials_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "PlaceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Description", "EventDate", "EventTime", "Name", "PlaceId" },
                values: new object[,]
                {
                    { 1, "A queer dance party focused on building community through nightlife", new DateTime(2020, 9, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), "Judy on Duty", null },
                    { 2, "An outer space themed karaoke dance night", new DateTime(2020, 9, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), "Cosmic Cafe", null },
                    { 3, "A monthly live music event", new DateTime(2020, 9, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), "Live in the Depths", null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "PlaceId", "Address", "Description", "Name", "RestroomFeatures", "Type" },
                values: new object[,]
                {
                    { 1, "1305 SE 8th Ave, Portland, OR 97214", "A bar with DJ's and Live Music and an outdoor patio.", "White Owl Social Club", 1, "Bar" },
                    { 2, "727 SE Grand Ave, Portland, OR 97214", "A bar with a dance floor upstairs nightky events.", "Bit House Saloon", 3, "Bar" },
                    { 3, "1709 SE Hawthorne Blvd, Portland, OR, 97214", "A bar with live music and events.", "No Fun", 2, "Bar" },
                    { 4, "5040 SE Milwaukie Ave, Portland, OR, 97202", "A large warehouse to throw all kinds of events", "Watershed", 1, "Event Space" },
                    { 5, "1332 W Burnside, Portland, OR, 97209", "Historic Building with a stage for live music", "Crystal Ballroom", 1, "Concert Venue" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "TestimonialId", "EventId", "Management", "Other", "PlaceId", "Story" },
                values: new object[] { 1, null, "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate", "velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua" });

            migrationBuilder.CreateIndex(
                name: "IX_Events_PlaceId",
                table: "Events",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Testimonials_EventId",
                table: "Testimonials",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Testimonials_PlaceId",
                table: "Testimonials",
                column: "PlaceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Places");
        }
    }
}
