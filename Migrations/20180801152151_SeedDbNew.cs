using Microsoft.EntityFrameworkCore.Migrations;

namespace VanBox.Migrations
{
    public partial class SeedDbNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("delete from Makes where Name in('BMW','TOYOTA','Ford')");

            migrationBuilder.Sql("insert into Makes(Name) values ('BMW')");
            migrationBuilder.Sql("insert into Makes(Name) values ('TOYOTA')");
            migrationBuilder.Sql("insert into Makes(Name) values ('Ford')");

            migrationBuilder.Sql("insert into Models(Name,MakeId) values ('BMW-1', (select Id from Makes where Name = 'BMW'))");
            migrationBuilder.Sql("insert into Models(Name,MakeId) values ('BMW-2', (select Id from Makes where Name = 'BMW'))");
            migrationBuilder.Sql("insert into Models(Name,MakeId) values ('BMW-3', (select Id from Makes where Name = 'BMW'))");

            migrationBuilder.Sql("insert into Models(Name,MakeId) values ('Toyota-1', (select Id from Makes where Name = 'TOYOTA'))");
            migrationBuilder.Sql("insert into Models(Name,MakeId) values ('Toyota-2', (select Id from Makes where Name = 'TOYOTA'))");
            migrationBuilder.Sql("insert into Models(Name,MakeId) values ('Toyota-3', (select Id from Makes where Name = 'TOYOTA'))");

            migrationBuilder.Sql("insert into Models(Name,MakeId) values ('Ford-1', (select Id from Makes where Name = 'Ford'))");
            migrationBuilder.Sql("insert into Models(Name,MakeId) values ('Ford-2', (select Id from Makes where Name = 'Ford'))");
            migrationBuilder.Sql("insert into Models(Name,MakeId) values ('Ford-3', (select Id from Makes where Name = 'Ford'))");
           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Makes where Name in('BMW','TOYOTA','Ford')");

        }
    }
}
