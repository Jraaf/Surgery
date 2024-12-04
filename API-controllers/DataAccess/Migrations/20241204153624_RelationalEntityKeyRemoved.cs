using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RelationalEntityKeyRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Case_Oper__Case___66603565",
                table: "Case_Operations");

            migrationBuilder.DropForeignKey(
                name: "FK__Case_Oper__Opera__6754599E",
                table: "Case_Operations");

            migrationBuilder.DropForeignKey(
                name: "FK__Doctors_I__Case___693CA210",
                table: "Doctors_In_Case_Operation");

            migrationBuilder.DropForeignKey(
                name: "FK__Doctors_I__Docto__6A30C649",
                table: "Doctors_In_Case_Operation");

            migrationBuilder.DropForeignKey(
                name: "FK__Doctors_I__Case___628FA481",
                table: "Doctors_In_Charge_of_Case");

            migrationBuilder.DropForeignKey(
                name: "FK__Doctors_I__Docto__6383C8BA",
                table: "Doctors_In_Charge_of_Case");

            migrationBuilder.DropForeignKey(
                name: "FK__Medical_C__Diagn__60A75C0F",
                table: "Medical_Cases");

            migrationBuilder.DropForeignKey(
                name: "FK__Medical_C__Insur__5FB337D6",
                table: "Medical_Cases");

            migrationBuilder.DropForeignKey(
                name: "FK__Medical_C__Patie__5EBF139D",
                table: "Medical_Cases");

            migrationBuilder.DropForeignKey(
                name: "FK__Researche__Case___6D0D32F4",
                table: "Researches_In_Case");

            migrationBuilder.DropForeignKey(
                name: "FK__Researche__Resea__6E01572D",
                table: "Researches_In_Case");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Doctors_In_Charge_of_Case",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Doctors_In_Case_Operation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Case_Operations_Medical_Cases_Case_ID",
                table: "Case_Operations",
                column: "Case_ID",
                principalTable: "Medical_Cases",
                principalColumn: "Case_ID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Case_Operations_Operations_Operation_ID",
                table: "Case_Operations",
                column: "Operation_ID",
                principalTable: "Operations",
                principalColumn: "Operation_ID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_In_Case_Operation_Case_Operations_Case_Operation_ID",
                table: "Doctors_In_Case_Operation",
                column: "Case_Operation_ID",
                principalTable: "Case_Operations",
                principalColumn: "Case_Operation_ID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_In_Case_Operation_Doctors_Doctor_ID",
                table: "Doctors_In_Case_Operation",
                column: "Doctor_ID",
                principalTable: "Doctors",
                principalColumn: "Doctor_ID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_In_Charge_of_Case_Doctors_Doctor_ID",
                table: "Doctors_In_Charge_of_Case",
                column: "Doctor_ID",
                principalTable: "Doctors",
                principalColumn: "Doctor_ID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_In_Charge_of_Case_Medical_Cases_Case_ID",
                table: "Doctors_In_Charge_of_Case",
                column: "Case_ID",
                principalTable: "Medical_Cases",
                principalColumn: "Case_ID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_Cases_Diagnoses_Diagnose_ID",
                table: "Medical_Cases",
                column: "Diagnose_ID",
                principalTable: "Diagnoses",
                principalColumn: "Diagnose_ID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_Cases_Insurances_Insurance_ID",
                table: "Medical_Cases",
                column: "Insurance_ID",
                principalTable: "Insurances",
                principalColumn: "Insurance_ID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_Cases_Patients_Patient_ID",
                table: "Medical_Cases",
                column: "Patient_ID",
                principalTable: "Patients",
                principalColumn: "Patient_ID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Researches_In_Case_Medical_Cases_Case_ID",
                table: "Researches_In_Case",
                column: "Case_ID",
                principalTable: "Medical_Cases",
                principalColumn: "Case_ID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Researches_In_Case_Researches_Research_ID",
                table: "Researches_In_Case",
                column: "Research_ID",
                principalTable: "Researches",
                principalColumn: "Research_ID",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Case_Operations_Medical_Cases_Case_ID",
                table: "Case_Operations");

            migrationBuilder.DropForeignKey(
                name: "FK_Case_Operations_Operations_Operation_ID",
                table: "Case_Operations");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_In_Case_Operation_Case_Operations_Case_Operation_ID",
                table: "Doctors_In_Case_Operation");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_In_Case_Operation_Doctors_Doctor_ID",
                table: "Doctors_In_Case_Operation");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_In_Charge_of_Case_Doctors_Doctor_ID",
                table: "Doctors_In_Charge_of_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_In_Charge_of_Case_Medical_Cases_Case_ID",
                table: "Doctors_In_Charge_of_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_Medical_Cases_Diagnoses_Diagnose_ID",
                table: "Medical_Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Medical_Cases_Insurances_Insurance_ID",
                table: "Medical_Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Medical_Cases_Patients_Patient_ID",
                table: "Medical_Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Researches_In_Case_Medical_Cases_Case_ID",
                table: "Researches_In_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_Researches_In_Case_Researches_Research_ID",
                table: "Researches_In_Case");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Doctors_In_Charge_of_Case");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Doctors_In_Case_Operation");

            migrationBuilder.AddForeignKey(
                name: "FK__Case_Oper__Case___66603565",
                table: "Case_Operations",
                column: "Case_ID",
                principalTable: "Medical_Cases",
                principalColumn: "Case_ID");

            migrationBuilder.AddForeignKey(
                name: "FK__Case_Oper__Opera__6754599E",
                table: "Case_Operations",
                column: "Operation_ID",
                principalTable: "Operations",
                principalColumn: "Operation_ID");

            migrationBuilder.AddForeignKey(
                name: "FK__Doctors_I__Case___693CA210",
                table: "Doctors_In_Case_Operation",
                column: "Case_Operation_ID",
                principalTable: "Case_Operations",
                principalColumn: "Case_Operation_ID");

            migrationBuilder.AddForeignKey(
                name: "FK__Doctors_I__Docto__6A30C649",
                table: "Doctors_In_Case_Operation",
                column: "Doctor_ID",
                principalTable: "Doctors",
                principalColumn: "Doctor_ID");

            migrationBuilder.AddForeignKey(
                name: "FK__Doctors_I__Case___628FA481",
                table: "Doctors_In_Charge_of_Case",
                column: "Case_ID",
                principalTable: "Medical_Cases",
                principalColumn: "Case_ID");

            migrationBuilder.AddForeignKey(
                name: "FK__Doctors_I__Docto__6383C8BA",
                table: "Doctors_In_Charge_of_Case",
                column: "Doctor_ID",
                principalTable: "Doctors",
                principalColumn: "Doctor_ID");

            migrationBuilder.AddForeignKey(
                name: "FK__Medical_C__Diagn__60A75C0F",
                table: "Medical_Cases",
                column: "Diagnose_ID",
                principalTable: "Diagnoses",
                principalColumn: "Diagnose_ID");

            migrationBuilder.AddForeignKey(
                name: "FK__Medical_C__Insur__5FB337D6",
                table: "Medical_Cases",
                column: "Insurance_ID",
                principalTable: "Insurances",
                principalColumn: "Insurance_ID");

            migrationBuilder.AddForeignKey(
                name: "FK__Medical_C__Patie__5EBF139D",
                table: "Medical_Cases",
                column: "Patient_ID",
                principalTable: "Patients",
                principalColumn: "Patient_ID");

            migrationBuilder.AddForeignKey(
                name: "FK__Researche__Case___6D0D32F4",
                table: "Researches_In_Case",
                column: "Case_ID",
                principalTable: "Medical_Cases",
                principalColumn: "Case_ID");

            migrationBuilder.AddForeignKey(
                name: "FK__Researche__Resea__6E01572D",
                table: "Researches_In_Case",
                column: "Research_ID",
                principalTable: "Researches",
                principalColumn: "Research_ID");
        }
    }
}
