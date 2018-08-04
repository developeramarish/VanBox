using Microsoft.EntityFrameworkCore.Migrations;

namespace VanBox.Migrations
{
    public partial class SeedVehicleFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Vehicles");
            migrationBuilder.Sql("insert into Vehicles(Name,ModelId) values ('Toyota Vec 1', (select Id from Models where Name = 'Toyota-2'))");
            migrationBuilder.Sql("insert into Vehicles(Name,ModelId) values ('Toyota Vec 2', (select Id from Models where Name = 'Toyota-2'))");
            migrationBuilder.Sql("insert into Vehicles(Name,ModelId) values ('BMW X 1', (select Id from Models where Name = 'BMW-2'))");
            migrationBuilder.Sql("insert into Vehicles(Name,ModelId) values ('BMW X 2', (select Id from Models where Name = 'BMW-1'))");
            migrationBuilder.Sql("insert into Vehicles(Name,ModelId) values ('Mustang', (select Id from Models where Name = 'Ford-2'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Vehicles");

        }
    }
}
