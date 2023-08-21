using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(" insert into employees(name,email,phone) values('Hager' , 'hager@gmail.com' , '010562312136') ");
            migrationBuilder.Sql(" insert into employees(name,email,phone) values('Ahmed' , 'Ahmed@gmail.com' , '010549666548') ");
            migrationBuilder.Sql(" insert into employees(name,email,phone) values('Leel' , 'Leel@gmail.com' , '0112541548') ");
            migrationBuilder.Sql(" insert into employees(name,email,phone) values('Hany' , 'Hany@gmail.com' , '0125183548') ");
            migrationBuilder.Sql(" insert into employees(name,email,phone) values('Mostafa' , 'Mostafa@gmail.com' , '0101131548') ");
            migrationBuilder.Sql(" insert into employees(name,email,phone) values('Mohamed' , 'Mohamed@gmail.com' , '0154862548') ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from employees where name in ('Hager' ,'Ahmed' , 'Leel')");
        }
    }
}
