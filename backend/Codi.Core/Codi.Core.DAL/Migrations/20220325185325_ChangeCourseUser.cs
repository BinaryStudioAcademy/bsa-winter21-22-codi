using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Codi.Core.DAL.Migrations
{
    public partial class ChangeCourseUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
				BEGIN TRANSACTION
				SET QUOTED_IDENTIFIER ON
				SET ARITHABORT ON
				SET NUMERIC_ROUNDABORT OFF
				SET CONCAT_NULL_YIELDS_NULL ON
				SET ANSI_NULLS ON
				SET ANSI_PADDING ON
				SET ANSI_WARNINGS ON
				COMMIT
				BEGIN TRANSACTION
				GO
				ALTER TABLE dbo.CourseUsers
					DROP CONSTRAINT FK_CourseUsers_Users_UserId
				GO
				ALTER TABLE dbo.Users SET (LOCK_ESCALATION = TABLE)
				GO
				COMMIT
				select Has_Perms_By_Name(N'dbo.Users', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Users', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Users', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
				GO
				ALTER TABLE dbo.CourseUsers
					DROP CONSTRAINT FK_CourseUsers_Courses_CourseId
				GO
				ALTER TABLE dbo.Courses SET (LOCK_ESCALATION = TABLE)
				GO
				COMMIT
				select Has_Perms_By_Name(N'dbo.Courses', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Courses', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Courses', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
				GO
				ALTER TABLE dbo.CourseUsers
					DROP CONSTRAINT DF__CourseUse__IsDel__6A30C649
				GO
				ALTER TABLE dbo.CourseUsers
					DROP CONSTRAINT DF__CourseUse__Cours__75A278F5
				GO
				CREATE TABLE dbo.Tmp_CourseUsers
					(
					UserId bigint NOT NULL,
					CourseId bigint NOT NULL,
					Id bigint NOT NULL IDENTITY (1, 1),
					CreatedBy bigint NULL,
					CreatedAt datetime2(7) NOT NULL,
					IsDeleted bit NOT NULL,
					CourseRole int NOT NULL
					)  ON [PRIMARY]
				GO
				ALTER TABLE dbo.Tmp_CourseUsers SET (LOCK_ESCALATION = TABLE)
				GO
				ALTER TABLE dbo.Tmp_CourseUsers ADD CONSTRAINT
					DF__CourseUse__IsDel__6A30C649 DEFAULT (CONVERT([bit],(0))) FOR IsDeleted
				GO
				ALTER TABLE dbo.Tmp_CourseUsers ADD CONSTRAINT
					DF__CourseUse__Cours__75A278F5 DEFAULT ((0)) FOR CourseRole
				GO
				SET IDENTITY_INSERT dbo.Tmp_CourseUsers ON
				GO
				IF EXISTS(SELECT * FROM dbo.CourseUsers)
					 EXEC('INSERT INTO dbo.Tmp_CourseUsers (UserId, CourseId, Id, CreatedBy, CreatedAt, IsDeleted, CourseRole)
						SELECT UserId, CourseId, Id, CreatedBy, CreatedAt, IsDeleted, CourseRole FROM dbo.CourseUsers WITH (HOLDLOCK TABLOCKX)')
				GO
				SET IDENTITY_INSERT dbo.Tmp_CourseUsers OFF
				GO
				DROP TABLE dbo.CourseUsers
				GO
				EXECUTE sp_rename N'dbo.Tmp_CourseUsers', N'CourseUsers', 'OBJECT' 
				GO
				ALTER TABLE dbo.CourseUsers ADD CONSTRAINT
					PK_CourseUsers_1 PRIMARY KEY CLUSTERED 
					(
					Id
					) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

				GO
				CREATE NONCLUSTERED INDEX IX_CourseUsers_CourseId ON dbo.CourseUsers
					(
					CourseId
					) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
				GO
				ALTER TABLE dbo.CourseUsers ADD CONSTRAINT
					FK_CourseUsers_Courses_CourseId FOREIGN KEY
					(
					CourseId
					) REFERENCES dbo.Courses
					(
					Id
					) ON UPDATE  NO ACTION 
					 ON DELETE  CASCADE 
	
				GO
				ALTER TABLE dbo.CourseUsers ADD CONSTRAINT
					FK_CourseUsers_Users_UserId FOREIGN KEY
					(
					UserId
					) REFERENCES dbo.Users
					(
					Id
					) ON UPDATE  NO ACTION 
					 ON DELETE  NO ACTION 
	
				GO
				COMMIT
				select Has_Perms_By_Name(N'dbo.CourseUsers', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.CourseUsers', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.CourseUsers', 'Object', 'CONTROL') as Contr_Per");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseUsers",
                table: "CourseUsers");

            migrationBuilder.DropIndex(
                name: "IX_CourseUsers_UserId",
                table: "CourseUsers");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "CourseUsers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseUsers",
                table: "CourseUsers",
                columns: new[] { "UserId", "CourseId" });
        }
    }
}
