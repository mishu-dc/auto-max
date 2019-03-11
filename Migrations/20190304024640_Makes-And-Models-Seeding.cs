using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoMax.Migrations
{
    public partial class MakesAndModelsSeeding : Migration
    {
        string[] _makes = new string[] { "Acura", "Audi", "BMW", "Buick", "Cadillac", "Chevrole", "Chrysler", "Dodge", "FIAT", "Ford", "GMC", "Honda", "Hyundai", "INFINITI", "Jaguar", "Jeep", "Kia", "Lexus", "Lincoln", "Maserati", "Mazda", "Mercedes", "Mercury", "MINI", "Mitsubis", "Nissan", "Pontiac", "Porsche", "Ram", "Scion", "Subaru", "Toyota", "Volkswag", "Volvo" };

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            InsertMakes(migrationBuilder);
            InsertModels(migrationBuilder);
        }

        private void InsertModels(MigrationBuilder migrationBuilder)
        {
            string[] models = new string[] { "LX", "LS", "EX" , "EXL" , "Sedan", "CRV", "Truck" };
            foreach(var make in _makes){
                foreach(var model in models){
                    migrationBuilder.Sql($"INSERT INTO MODELS (NAME, MAKEID) VALUES('{model}', (SELECT ID FROM MAKES WHERE NAME='{make}'))");
                }
            }
        }

        private void InsertMakes(MigrationBuilder migrationBuilder)
        {
            foreach(var make in _makes){
                migrationBuilder.Sql($"INSERT INTO MAKES(NAME) VALUES ('{make}')");
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            foreach(var make in _makes){
                migrationBuilder.Sql($"DELETE FROM MAKES WHERE NAME='{make}'");
            }
        }
    }
}
