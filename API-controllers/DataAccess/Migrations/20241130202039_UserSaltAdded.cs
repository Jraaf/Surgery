using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UserSaltAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
/*
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Doctor_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medical_Cases",
                columns: table => new
                {
                    Case_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Case_Start_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Case_End_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Patient_ID = table.Column<int>(type: "int", nullable: true),
                    Insurance_ID = table.Column<int>(type: "int", nullable: true),
                    Diagnose_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Medical___D062FC05E7749D43", x => x.Case_ID);
                    table.ForeignKey(
                        name: "FK__Medical_C__Diagn__60A75C0F",
                        column: x => x.Diagnose_ID,
                        principalTable: "Diagnoses",
                        principalColumn: "Diagnose_ID");
                    table.ForeignKey(
                        name: "FK__Medical_C__Insur__5FB337D6",
                        column: x => x.Insurance_ID,
                        principalTable: "Insurances",
                        principalColumn: "Insurance_ID");
                    table.ForeignKey(
                        name: "FK__Medical_C__Patie__5EBF139D",
                        column: x => x.Patient_ID,
                        principalTable: "Patients",
                        principalColumn: "Patient_ID");
                });

            migrationBuilder.CreateTable(
                name: "Case_Operations",
                columns: table => new
                {
                    Case_Operation_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Case_ID = table.Column<int>(type: "int", nullable: true),
                    Operation_ID = table.Column<int>(type: "int", nullable: true),
                    Start_of_Operation = table.Column<DateTime>(type: "datetime", nullable: false),
                    End_of_Operation = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Case_Ope__EA267F41F48FC149", x => x.Case_Operation_ID);
                    table.ForeignKey(
                        name: "FK__Case_Oper__Case___66603565",
                        column: x => x.Case_ID,
                        principalTable: "Medical_Cases",
                        principalColumn: "Case_ID");
                    table.ForeignKey(
                        name: "FK__Case_Oper__Opera__6754599E",
                        column: x => x.Operation_ID,
                        principalTable: "Operations",
                        principalColumn: "Operation_ID");
                });

            migrationBuilder.CreateTable(
                name: "Doctors_In_Charge_of_Case",
                columns: table => new
                {
                    Case_ID = table.Column<int>(type: "int", nullable: true),
                    Doctor_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__Doctors_I__Case___628FA481",
                        column: x => x.Case_ID,
                        principalTable: "Medical_Cases",
                        principalColumn: "Case_ID");
                    table.ForeignKey(
                        name: "FK__Doctors_I__Docto__6383C8BA",
                        column: x => x.Doctor_ID,
                        principalTable: "Doctors",
                        principalColumn: "Doctor_ID");
                });

            migrationBuilder.CreateTable(
                name: "Researches_In_Case",
                columns: table => new
                {
                    Laboratory_Research_In_Case_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Case_ID = table.Column<int>(type: "int", nullable: true),
                    Research_ID = table.Column<int>(type: "int", nullable: true),
                    Research_Datetime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Research_Result = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Research__9C185E944840DA64", x => x.Laboratory_Research_In_Case_ID);
                    table.ForeignKey(
                        name: "FK__Researche__Case___6D0D32F4",
                        column: x => x.Case_ID,
                        principalTable: "Medical_Cases",
                        principalColumn: "Case_ID");
                    table.ForeignKey(
                        name: "FK__Researche__Resea__6E01572D",
                        column: x => x.Research_ID,
                        principalTable: "Researches",
                        principalColumn: "Research_ID");
                });

            migrationBuilder.CreateTable(
                name: "Doctors_In_Case_Operation",
                columns: table => new
                {
                    Case_Operation_ID = table.Column<int>(type: "int", nullable: true),
                    Doctor_ID = table.Column<int>(type: "int", nullable: true),
                    Start_of_Operating = table.Column<DateTime>(type: "datetime", nullable: false),
                    End_of_Operating = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__Doctors_I__Case___693CA210",
                        column: x => x.Case_Operation_ID,
                        principalTable: "Case_Operations",
                        principalColumn: "Case_Operation_ID");
                    table.ForeignKey(
                        name: "FK__Doctors_I__Docto__6A30C649",
                        column: x => x.Doctor_ID,
                        principalTable: "Doctors",
                        principalColumn: "Doctor_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Case_Operations_Case_ID",
                table: "Case_Operations",
                column: "Case_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Case_Operations_Operation_ID",
                table: "Case_Operations",
                column: "Operation_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_In_Case_Operation_Case_Operation_ID",
                table: "Doctors_In_Case_Operation",
                column: "Case_Operation_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_In_Case_Operation_Doctor_ID",
                table: "Doctors_In_Case_Operation",
                column: "Doctor_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_In_Charge_of_Case_Case_ID",
                table: "Doctors_In_Charge_of_Case",
                column: "Case_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_In_Charge_of_Case_Doctor_ID",
                table: "Doctors_In_Charge_of_Case",
                column: "Doctor_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Medical_Cases_Diagnose_ID",
                table: "Medical_Cases",
                column: "Diagnose_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Medical_Cases_Insurance_ID",
                table: "Medical_Cases",
                column: "Insurance_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Medical_Cases_Patient_ID",
                table: "Medical_Cases",
                column: "Patient_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Researches_In_Case_Case_ID",
                table: "Researches_In_Case",
                column: "Case_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Researches_In_Case_Research_ID",
                table: "Researches_In_Case",
                column: "Research_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DoctorId",
                table: "Users",
                column: "DoctorId");
*/
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors_In_Case_Operation");

            migrationBuilder.DropTable(
                name: "Doctors_In_Charge_of_Case");

            migrationBuilder.DropTable(
                name: "Researches_In_Case");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Case_Operations");

            migrationBuilder.DropTable(
                name: "Researches");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Medical_Cases");

            migrationBuilder.DropTable(
                name: "Operations");

            migrationBuilder.DropTable(
                name: "Diagnoses");

            migrationBuilder.DropTable(
                name: "Insurances");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
