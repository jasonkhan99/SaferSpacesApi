using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaferSpacesApi.Migrations
{
    public partial class NewJoins : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventTestimonial",
                columns: table => new
                {
                    EventTestimonialId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TestimonialId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTestimonial", x => x.EventTestimonialId);
                    table.ForeignKey(
                        name: "FK_EventTestimonial_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventTestimonial_Testimonials_TestimonialId",
                        column: x => x.TestimonialId,
                        principalTable: "Testimonials",
                        principalColumn: "TestimonialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlaceTestimonial",
                columns: table => new
                {
                    PlaceTestimonialId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PlaceId = table.Column<int>(nullable: false),
                    TestimonialId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceTestimonial", x => x.PlaceTestimonialId);
                    table.ForeignKey(
                        name: "FK_PlaceTestimonial_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "PlaceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaceTestimonial_Testimonials_TestimonialId",
                        column: x => x.TestimonialId,
                        principalTable: "Testimonials",
                        principalColumn: "TestimonialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventTestimonial_EventId",
                table: "EventTestimonial",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTestimonial_TestimonialId",
                table: "EventTestimonial",
                column: "TestimonialId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceTestimonial_PlaceId",
                table: "PlaceTestimonial",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceTestimonial_TestimonialId",
                table: "PlaceTestimonial",
                column: "TestimonialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventTestimonial");

            migrationBuilder.DropTable(
                name: "PlaceTestimonial");
        }
    }
}
