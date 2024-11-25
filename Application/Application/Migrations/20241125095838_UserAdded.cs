using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Migrations
{
    /// <inheritdoc />
    public partial class UserAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Diagnoses",
            //    columns: table => new
            //    {
            //        Diagnose_ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Diagnose_Description = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Diagnose__E7B4E19532AF3369", x => x.Diagnose_ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Doctors",
            //    columns: table => new
            //    {
            //        Doctor_ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Doctor_Name = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: false),
            //        Doctor_Surname = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Doctors__E59B530F9FFBCB71", x => x.Doctor_ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Insurances",
            //    columns: table => new
            //    {
            //        Insurance_ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Insurance_Name = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
            //        Insurance_Coverage_Amount = table.Column<decimal>(type: "money", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Insuranc__FFF09853E0CE8523", x => x.Insurance_ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Operations",
            //    columns: table => new
            //    {
            //        Operation_ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Operation_Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        Operation_Cost = table.Column<decimal>(type: "money", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Operatio__D9469EE7C7BA71EA", x => x.Operation_ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Patients",
            //    columns: table => new
            //    {
            //        Patient_ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Patient_Name = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: false),
            //        Patient_Surname = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
            //        Patient_Patronymic = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
            //        Patient_Date_of_Birth = table.Column<DateOnly>(type: "date", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Patients__C1A88B597C7CA551", x => x.Patient_ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Researches",
            //    columns: table => new
            //    {
            //        Research_ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Research_Name = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: false),
            //        Research_Normal_Values = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        Research_Cost = table.Column<decimal>(type: "money", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Research__7B1735FA1A989E0C", x => x.Research_ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Medical_Cases",
            //    columns: table => new
            //    {
            //        Case_ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Case_Start_Date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Case_End_Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Patient_ID = table.Column<int>(type: "int", nullable: true),
            //        Insurance_ID = table.Column<int>(type: "int", nullable: true),
            //        Diagnose_ID = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Medical___D062FC05E7749D43", x => x.Case_ID);
            //        table.ForeignKey(
            //            name: "FK__Medical_C__Diagn__60A75C0F",
            //            column: x => x.Diagnose_ID,
            //            principalTable: "Diagnoses",
            //            principalColumn: "Diagnose_ID");
            //        table.ForeignKey(
            //            name: "FK__Medical_C__Insur__5FB337D6",
            //            column: x => x.Insurance_ID,
            //            principalTable: "Insurances",
            //            principalColumn: "Insurance_ID");
            //        table.ForeignKey(
            //            name: "FK__Medical_C__Patie__5EBF139D",
            //            column: x => x.Patient_ID,
            //            principalTable: "Patients",
            //            principalColumn: "Patient_ID");
            //    });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Doctor_ID");
                    table.ForeignKey(
                        name: "FK_Users_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Patient_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.CreateTable(
            //    name: "Case_Operations",
            //    columns: table => new
            //    {
            //        Case_Operation_ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Case_ID = table.Column<int>(type: "int", nullable: true),
            //        Operation_ID = table.Column<int>(type: "int", nullable: true),
            //        Start_of_Operation = table.Column<DateTime>(type: "datetime", nullable: false),
            //        End_of_Operation = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Case_Ope__EA267F41F48FC149", x => x.Case_Operation_ID);
            //        table.ForeignKey(
            //            name: "FK__Case_Oper__Case___66603565",
            //            column: x => x.Case_ID,
            //            principalTable: "Medical_Cases",
            //            principalColumn: "Case_ID");
            //        table.ForeignKey(
            //            name: "FK__Case_Oper__Opera__6754599E",
            //            column: x => x.Operation_ID,
            //            principalTable: "Operations",
            //            principalColumn: "Operation_ID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Doctors_In_Charge_of_Case",
            //    columns: table => new
            //    {
            //        Case_ID = table.Column<int>(type: "int", nullable: true),
            //        Doctor_ID = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.ForeignKey(
            //            name: "FK__Doctors_I__Case___628FA481",
            //            column: x => x.Case_ID,
            //            principalTable: "Medical_Cases",
            //            principalColumn: "Case_ID");
            //        table.ForeignKey(
            //            name: "FK__Doctors_I__Docto__6383C8BA",
            //            column: x => x.Doctor_ID,
            //            principalTable: "Doctors",
            //            principalColumn: "Doctor_ID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Researches_In_Case",
            //    columns: table => new
            //    {
            //        Laboratory_Research_In_Case_ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Case_ID = table.Column<int>(type: "int", nullable: true),
            //        Research_ID = table.Column<int>(type: "int", nullable: true),
            //        Research_Datetime = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Research_Result = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Research__9C185E944840DA64", x => x.Laboratory_Research_In_Case_ID);
            //        table.ForeignKey(
            //            name: "FK__Researche__Case___6D0D32F4",
            //            column: x => x.Case_ID,
            //            principalTable: "Medical_Cases",
            //            principalColumn: "Case_ID");
            //        table.ForeignKey(
            //            name: "FK__Researche__Resea__6E01572D",
            //            column: x => x.Research_ID,
            //            principalTable: "Researches",
            //            principalColumn: "Research_ID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Doctors_In_Case_Operation",
            //    columns: table => new
            //    {
            //        Case_Operation_ID = table.Column<int>(type: "int", nullable: true),
            //        Doctor_ID = table.Column<int>(type: "int", nullable: true),
            //        Start_of_Operating = table.Column<DateTime>(type: "datetime", nullable: false),
            //        End_of_Operating = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.ForeignKey(
            //            name: "FK__Doctors_I__Case___693CA210",
            //            column: x => x.Case_Operation_ID,
            //            principalTable: "Case_Operations",
            //            principalColumn: "Case_Operation_ID");
            //        table.ForeignKey(
            //            name: "FK__Doctors_I__Docto__6A30C649",
            //            column: x => x.Doctor_ID,
            //            principalTable: "Doctors",
            //            principalColumn: "Doctor_ID");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Case_Operations_Case_ID",
            //    table: "Case_Operations",
            //    column: "Case_ID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Case_Operations_Operation_ID",
            //    table: "Case_Operations",
            //    column: "Operation_ID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Doctors_In_Case_Operation_Case_Operation_ID",
            //    table: "Doctors_In_Case_Operation",
            //    column: "Case_Operation_ID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Doctors_In_Case_Operation_Doctor_ID",
            //    table: "Doctors_In_Case_Operation",
            //    column: "Doctor_ID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Doctors_In_Charge_of_Case_Case_ID",
            //    table: "Doctors_In_Charge_of_Case",
            //    column: "Case_ID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Doctors_In_Charge_of_Case_Doctor_ID",
            //    table: "Doctors_In_Charge_of_Case",
            //    column: "Doctor_ID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Medical_Cases_Diagnose_ID",
            //    table: "Medical_Cases",
            //    column: "Diagnose_ID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Medical_Cases_Insurance_ID",
            //    table: "Medical_Cases",
            //    column: "Insurance_ID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Medical_Cases_Patient_ID",
            //    table: "Medical_Cases",
            //    column: "Patient_ID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Researches_In_Case_Case_ID",
            //    table: "Researches_In_Case",
            //    column: "Case_ID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Researches_In_Case_Research_ID",
            //    table: "Researches_In_Case",
            //    column: "Research_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DoctorId",
                table: "Users",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PatientId",
                table: "Users",
                column: "PatientId");
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
