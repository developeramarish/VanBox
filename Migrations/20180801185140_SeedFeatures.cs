using Microsoft.EntityFrameworkCore.Migrations;

namespace VanBox.Migrations
{
    public partial class SeedFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Features(Name,ModelId) values ('BMW-ABS', (select Id from Models where Name = 'BMW-1'))");
            migrationBuilder.Sql("insert into Features(Name,ModelId) values ('BMW-Auto', (select Id from Models where Name = 'BMW-1'))");
            
            migrationBuilder.Sql("insert into Features(Name,ModelId) values ('Toyota-2 Drum Break', (select Id from Models where Name = 'Toyota-2'))");
            migrationBuilder.Sql("insert into Features(Name,ModelId) values ('Power STD', (select Id from Models where Name = 'Toyota-1'))");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Features where Name in('BMW-ABS','BMW-Auto','oyota-2 Drum Break','Power STD')");


        }
    }
}
