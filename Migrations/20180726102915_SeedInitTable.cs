using Microsoft.EntityFrameworkCore.Migrations;

namespace VanBox.Migrations
{
    public partial class SeedInitTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Makes (Name) values ('aston martin')");
            migrationBuilder.Sql("insert into Makes (Name) values ('bmw')");
            migrationBuilder.Sql("insert into Makes (Name) values ('cevrolet')");

            migrationBuilder.Sql("insert into Models (Name,MakeId) values ('AS 1',(select Id from Makes where Name='aston martin'))");
            migrationBuilder.Sql("insert into Models (Name,MakeId) values ('AS 2',(select Id from Makes where Name='aston martin'))");
            migrationBuilder.Sql("insert into Models (Name,MakeId) values ('AS 3',(select Id from Makes where Name='aston martin'))");

            migrationBuilder.Sql("insert into Models (Name,MakeId) values ('B 1',(select Id from Makes where Name='bmw'))");
            migrationBuilder.Sql("insert into Models (Name,MakeId) values ('B 2',(select Id from Makes where Name='bmw'))");
            migrationBuilder.Sql("insert into Models (Name,MakeId) values ('B 3',(select Id from Makes where Name='bmw'))");

            migrationBuilder.Sql("insert into Models (Name,MakeId) values ('CV 1',(select Id from Makes where Name='cevrolet'))");
            migrationBuilder.Sql("insert into Models (Name,MakeId) values ('CV 2',(select Id from Makes where Name='cevrolet'))");
            migrationBuilder.Sql("insert into Models (Name,MakeId) values ('CV 3',(select Id from Makes where Name='cevrolet'))");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Makes where Name in ('aston martin','bmw','cevrolet')");

        }
    }
}
