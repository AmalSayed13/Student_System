using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_System.Migrations
{
    /// <inheritdoc />
    public partial class relationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseStudents",
                table: "CourseStudents");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CourseStudents");

            migrationBuilder.RenameColumn(
                name: "DeptName",
                table: "Departments",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "DeptName",
                table: "Instructors",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DeptName",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseStudents",
                table: "CourseStudents",
                columns: new[] { "CourseId", "StudentId" });

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_DeptName",
                table: "Instructors",
                column: "DeptName");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudents_StudentId",
                table: "CourseStudents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessions_CourseId",
                table: "CourseSessions",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessions_InstractorId",
                table: "CourseSessions",
                column: "InstractorId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessionAttendances_CourseSessionId",
                table: "CourseSessionAttendances",
                column: "CourseSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessionAttendances_StudentId",
                table: "CourseSessionAttendances",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DeptName",
                table: "Courses",
                column: "DeptName");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InsId",
                table: "Courses",
                column: "InsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DeptName",
                table: "Courses",
                column: "DeptName",
                principalTable: "Departments",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_InsId",
                table: "Courses",
                column: "InsId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSessionAttendances_CourseSessions_CourseSessionId",
                table: "CourseSessionAttendances",
                column: "CourseSessionId",
                principalTable: "CourseSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSessionAttendances_Students_StudentId",
                table: "CourseSessionAttendances",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSessions_Courses_CourseId",
                table: "CourseSessions",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSessions_Instructors_InstractorId",
                table: "CourseSessions",
                column: "InstractorId",
                principalTable: "Instructors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudents_Courses_CourseId",
                table: "CourseStudents",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudents_Students_StudentId",
                table: "CourseStudents",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DeptName",
                table: "Instructors",
                column: "DeptName",
                principalTable: "Departments",
                principalColumn: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DeptName",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Instructors_InsId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseSessionAttendances_CourseSessions_CourseSessionId",
                table: "CourseSessionAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseSessionAttendances_Students_StudentId",
                table: "CourseSessionAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseSessions_Courses_CourseId",
                table: "CourseSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseSessions_Instructors_InstractorId",
                table: "CourseSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudents_Courses_CourseId",
                table: "CourseStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudents_Students_StudentId",
                table: "CourseStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DeptName",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_DeptName",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseStudents",
                table: "CourseStudents");

            migrationBuilder.DropIndex(
                name: "IX_CourseStudents_StudentId",
                table: "CourseStudents");

            migrationBuilder.DropIndex(
                name: "IX_CourseSessions_CourseId",
                table: "CourseSessions");

            migrationBuilder.DropIndex(
                name: "IX_CourseSessions_InstractorId",
                table: "CourseSessions");

            migrationBuilder.DropIndex(
                name: "IX_CourseSessionAttendances_CourseSessionId",
                table: "CourseSessionAttendances");

            migrationBuilder.DropIndex(
                name: "IX_CourseSessionAttendances_StudentId",
                table: "CourseSessionAttendances");

            migrationBuilder.DropIndex(
                name: "IX_Courses_DeptName",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_InsId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Departments",
                newName: "DeptName");

            migrationBuilder.AlterColumn<string>(
                name: "DeptName",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CourseStudents",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "DeptName",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseStudents",
                table: "CourseStudents",
                column: "Id");
        }
    }
}
