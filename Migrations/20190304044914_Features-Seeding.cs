using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoMax.Migrations
{
    public partial class FeaturesSeeding : Migration
    {
        string[] features = new string[] { "Remote Keyless Entry", "Anti-Lock Brakes (ABS)", "Electronic Stability/Skid-Control System", "Telescoping Steering Wheel/Adjustable Pedals", "Rear-Seat DVD Player", "GPS Navigation System", "Side Airbags", "Center Console With a Power Outlet", "Roadside Assistance" };
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             foreach(var feature in features){
                 migrationBuilder.Sql($"INSERT INTO FEATURES(NAME) VALUES( '{feature}' )");
             }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            foreach(var feature in features){
                 migrationBuilder.Sql($"DELETE FROM FEATURES WHERE NAME='{feature}'");
            }
        }
    }
}
